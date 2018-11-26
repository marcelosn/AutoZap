using SQLiteBAL.Common.DataShapes;
using SQLiteBAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Timers;

namespace AutoZapService
{
    public partial class AutoZap : System.ServiceProcess.ServiceBase
    {
        TbConfig tbconfig = null;
        bool isAlive = false;
        WhatsAppService ws = null;
        int _tickcount = 0;
        string _pastagatilho = AppDomain.CurrentDomain.BaseDirectory + @"\gatilho";

        //Inicializando o objeto timer
        System.Timers.Timer timer = new System.Timers.Timer();
        Thread thRecv = null; 

        public AutoZap()
        {
            InitializeComponent();

            if (!System.Diagnostics.EventLog.SourceExists("AutoZapService"))
            {
                System.Diagnostics.EventLog.CreateEventSource(
                    "AutoZapService", "Application");
            }

            eventLog1.Source = "AutoZapService";
            eventLog1.Log = "Application";


        }

         public void Run()
         {
             tbconfig = (new OpcoesService()).Get();

             // Folders
             //(new SQLiteBAL.Common.Util()).BackupDatabase();

             Directory.CreateDirectory(_pastagatilho);

             #region WhatsApp //////////////////////////////////////////////////////////
             if (!tbconfig.tpserver)
             {

                 Conectar();          

                 if (ws.Status == WhatsAppService.CONNECTION_STATUS.CONNECTED || ws.Status == WhatsAppService.CONNECTION_STATUS.LOGGEDIN)
                     log("Conectado");

                 if (ws.Status == WhatsAppService.CONNECTION_STATUS.UNAUTHORIZED)
                 {
                     log(String.Format("{0}: Não autorizado - reveja o número ou a senha.", tbconfig.username));
                     this.Stop();
                 }

                 if (ws.Status == WhatsAppService.CONNECTION_STATUS.DISCONNECTED)
                 {
                     log("Desconectado");
                     this.Stop();
                 }

                 // obtem lista de usuarios
                 ws.UpdateListUser();

                 // obtem lista de grupos
                 ws.UpdateListGroup();
             }
             #endregion

             #region XMPP //////////////////////////////////////////////////////////////
             if (tbconfig.tpserver)
             {

             }
             #endregion

             #region Timer
             //Escreve no Visualizador de Evento do Windows
             //EventLog.WriteEntry(“Serviço Inicializado.”, EventLogEntryType.Information);

             //1: Adicionando o evento Elapsed ao objeto Timer
             timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);

             //2: Marcando o como intervalo 1 minuto (= 60,000 milliseconds)
             timer.Interval = 500;

             //3: Habilitando o objeto timer para execução.
             timer.Enabled = true;
             #endregion

             log("Serviço iniciado.");

             KeepAlive();
         }

        protected override void OnStart(string[] args)
        {
            Run();            
        }

        private void KeepAlive()
        {
            thRecv = new Thread(t =>
            {
                try
                {
                    int _tick = 0;

                    while (ws != null && (ws.Status == WhatsAppService.CONNECTION_STATUS.CONNECTED || ws.Status == WhatsAppService.CONNECTION_STATUS.LOGGEDIN))
                    {
                        
                        _tick++;

                        ws.Instance.PollMessages();
                        isAlive = true;
                        Thread.Sleep(1000);

                        if (_tick > 20)
                        {
                            ws.Instance.WhatsSendHandler.SendActive();
                            _tick = 0;
                        }
                        else if (_tick > 3)
                        {
                           
                            //ws.Instance.RequestLastSeen((new WhatsAppService.WhatsAppUser() { Nickname = tbconfig.nickname, Username = tbconfig.username }).Jid);
                        }

                        continue;
                    }

                    isAlive = false;

                }
                catch (ThreadAbortException)
                { }
            }) { IsBackground = true };
            thRecv.Start();
        }

        private void Conectar()
        {
            ws = null;
            
            ws = new WhatsAppService();

            ws.Conect(tbconfig.username, tbconfig.password, tbconfig.nickname);

            ws.Instance.OnGetMessage += Instance_OnGetMessage;
            ws.Instance.OnGetMessageReceivedClient += Instance_OnGetMessageReceivedClient;
            ws.Instance.OnGetMessageReceivedServer += Instance_OnGetMessageReceivedServer;
        }

        private void log(string txt)
        {
            eventLog1.WriteEntry(String.Format("({0}) - {1}", ((tbconfig.tpserver)?"XMPP":"WhatsApp"), txt));
        }

        protected override void OnStop()
        {
            timer.Enabled = false;

            #region WhatsApp //////////////////////////////////////////////////////////
            if (!tbconfig.tpserver)
            {
                if (ws.Status == WhatsAppService.CONNECTION_STATUS.CONNECTED || ws.Status == WhatsAppService.CONNECTION_STATUS.LOGGEDIN)
                {
                    ws.Desconectar();
                    log("Desconectando");
                }
            }
            #endregion

            #region XMPP //////////////////////////////////////////////////////////////
            if (tbconfig.tpserver)
            {

            }
            #endregion

            
            ws = null;
            log("Serviço parado.");
        }


        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            _tickcount++;

            #region Gatilho ///////////////////////////////////////////////////////////
            if (_tickcount % 10 == 0)
            {
                string[] files = Directory.GetFiles(_pastagatilho);
            }
            #endregion

            #region WhatsApp //////////////////////////////////////////////////////////
            if (!tbconfig.tpserver)
            {
                try
                {
                    if (isAlive || ws.Instance.whatsNetwork.SocketStatus)
                    {
                        //coleta mensagens
                        if ((_tickcount % 10) == 0)
                        {
                            //ws.Instance.PollMessages();
                            //System.Threading.Thread.Sleep(300);
                        }

                        //Dispare regras TXT
                        if ((_tickcount % 10) == 0)
                        {
                            
                            //log("Oi Era para ter mensagem");
                            //ws.EnviarMensagem(new WhatsAppService.WhatsAppUser() { Nickname = "Corcino", Username = "557999240037" }, "Mensagem " + _tickcount);
                        }
                    }
                    else
                    {
                        log("Falha: Estou fora por motivo desconhecido. ");
                        //reset conexao
                        thRecv.Abort();
                        thRecv = null;

                        ws.Instance.ClearIncomplete();
                        ws.Desconectar();

                        Conectar();
                        KeepAlive();
                    }
                }
                catch (Exception ex)
                {
                    log("Falha: " + ex.Message + " " + _tickcount.ToString());

                    thRecv.Abort();
                    thRecv = null;

                    //reset conexao
                    ws.Instance.ClearIncomplete();
                    ws.Desconectar();

                    Conectar();
                    KeepAlive();
                }
            }
            #endregion

            #region XMPP //////////////////////////////////////////////////////////////
            if (tbconfig.tpserver)
            {

            }
            #endregion
        }

        private void Instance_OnGetMessage(WhatsAppApi.Helper.ProtocolTreeNode node, string from, string id, string name, string message, bool receipt_sent)
        {
            //log(String.Format("Message from {0} {1}: {2}", name, from, message));
            try
            {
                if (!String.IsNullOrEmpty(tbconfig.autoresponse))
                     ws.EnviarMensagem(from, tbconfig.autoresponse);
            }
            catch (Exception ex)
            {

            }
        }

        private void Instance_OnGetMessageReceivedServer(string from, string id)
        {
            log(String.Format("Message {0} to {1} received by server", id, from));
        }

        private void Instance_OnGetMessageReceivedClient(string from, string id)
        {
            log(String.Format("Message {0} to {1} received by client", id, from));
        }


    }
}
