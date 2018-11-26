using SQLiteBAL.Common.DataShapes;
using SQLiteBAL.Persistence;
using SQLiteBAL.Services.WhatAppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using WhatsAppApi.Response;

namespace SQLiteBAL.Services
{
    public class WhatsAppService
    {
            #region Registro

        public string RequestCode(string phone)
        {
           

            string identity = string.Empty;
            string number = string.Empty;
            string cc = string.Empty;            
            string password = string.Empty;
            string language = string.Empty;
            string locale = string.Empty;
            string mcc = string.Empty;
            string code = string.Empty;
            string method = "sms";            


            if (!String.IsNullOrEmpty(phone))
            {                
                try
                {
                    number = phone;
                    number = TrimNumber(number);
                    WhatsAppApi.Parser.PhoneNumber phonenumber = new WhatsAppApi.Parser.PhoneNumber(number);
                    identity = WhatsAppApi.Register.WhatsRegisterV2.GenerateIdentity(phonenumber.Number, "");
                    cc = phonenumber.CC;
                    phone = phonenumber.Number;
                    language = phonenumber.ISO639;
                    locale = phonenumber.ISO3166;
                    mcc = phonenumber.MCC;

                    CountryHelper chelp = new CountryHelper();
                    string country = string.Empty;
                    if (!chelp.CheckFormat(cc, phone, out country))
                    {
                       return string.Format("Error: Provided number does not match any known patterns for {0}", country);
                    }
                }
                catch (Exception ex)
                {                   
                    return String.Format("Error: {0}", ex.Message);                   
                    
                }
                string request = null;
                string response = null;

                bool registerResult = WhatsAppApi.Register.WhatsRegisterV2.RequestCode(cc, phone, out password, out request, out response, method, identity, language, locale, mcc);

                if (registerResult)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        //password received
                        return String.Format("Password: {0}", password);
                    }
                    else
                    {
                        return String.Format("Info: Aguarde o código por SMS e informe o Passo 2");  
                    }
                }
                else
                {
                    return String.Format("Error: Não foi possível verificar o code: {0}", response);                        
                }
            }
            else
            {
                return string.Format("Error: Informe o numero do telefone.");
            }
        }

        public string ConfimCode(string code, string phone )
        {
            string identity = string.Empty;
            string number = string.Empty;
            string cc = string.Empty;            
            string password = string.Empty;
            string language = string.Empty;
            string locale = string.Empty;
            string mcc = string.Empty;


            if (!String.IsNullOrEmpty(code) && code.Length == 6)
            {
                number = phone;
                number = TrimNumber(number);
                WhatsAppApi.Parser.PhoneNumber phonenumber = new WhatsAppApi.Parser.PhoneNumber(number);
                identity = WhatsAppApi.Register.WhatsRegisterV2.GenerateIdentity(phonenumber.Number, "");
                cc = phonenumber.CC;
                phone = phonenumber.Number;
                language = phonenumber.ISO639;
                locale = phonenumber.ISO3166;
                mcc = phonenumber.MCC;

                string response = string.Empty;
                password = WhatsAppApi.Register.WhatsRegisterV2.RegisterCode(cc, phone, code, out response, identity);
                if (!String.IsNullOrEmpty(password))
                {
                    return String.Format("Password: {0}", password);
                }
                else
                {
                    return string.Format("Error: Codigo verificação não aceito.");
                }
            }
            else
            {
                return string.Format("Error: Formato do código é inválido.");
            }
        }

            #endregion

            #region Conexão
            WhatsAppApi.WhatsApp _instance;

            public WhatsAppApi.WhatsApp Instance
            {
                get
                {
                    return _instance;
                }
            }    

            public CONNECTION_STATUS Status
            {
                get
                {
                    
                    try
                    {
                        switch (_instance.ConnectionStatus)
                        {
                            case WhatsAppApi.WhatsApp.CONNECTION_STATUS.CONNECTED:
                                return CONNECTION_STATUS.CONNECTED;
                            case WhatsAppApi.WhatsApp.CONNECTION_STATUS.DISCONNECTED:
                                return CONNECTION_STATUS.DISCONNECTED;
                            case WhatsAppApi.WhatsApp.CONNECTION_STATUS.LOGGEDIN:
                                return CONNECTION_STATUS.LOGGEDIN;
                            case WhatsAppApi.WhatsApp.CONNECTION_STATUS.UNAUTHORIZED:
                                return CONNECTION_STATUS.UNAUTHORIZED;
                            default:
                                return CONNECTION_STATUS.DISCONNECTED;
                        }
                    }
                    catch (Exception ex)
                    {
                        return CONNECTION_STATUS.DISCONNECTED;
                    }
                }
            }

            public enum CONNECTION_STATUS
            {
                UNAUTHORIZED = 0,
                DISCONNECTED = 1,
                CONNECTED = 2,
                LOGGEDIN = 3,
            }

            public void Conect(string username, string password, string nickname, bool debug = false)
            {
                _instance = new WhatsAppApi.WhatsApp(username, password, nickname, debug);
                _instance.Connect();
                _instance.Login();
            }

            public void Desconectar()
            {
                if (_instance != null)
                {
                    if (_instance.ConnectionStatus == WhatsAppApi.WhatsApp.CONNECTION_STATUS.CONNECTED || _instance.ConnectionStatus == WhatsAppApi.WhatsApp.CONNECTION_STATUS.LOGGEDIN)
                    {
                        _instance.Disconnect();
                    }
                }
            }

            private string TrimNumber(string number)
            {
                return number.TrimStart(new char[] { '+', '0' });
            }

            #endregion

            #region Mensagens
        
            public void EnviarMensagem(WhatsAppUser user, string texto )
            {                
                _instance.Message(user.Jid, texto);
            }

            public void EnviarMensagem(string Jid, string texto)
            {
                _instance.Message(Jid, texto);
            }


            #endregion

            #region Usuarios

            public List<WhatsAppUser> WhatsAppUsers { get; private set; }
            public class WhatsAppUser
            {
                string _username = "";

                public string Jid { get; private set; }
                public string Username
                {
                    get { return _username; } 
                    set {
                        if (!String.IsNullOrEmpty(value))
                            Jid = WhatsAppApi.WhatsApp.GetJID(value);
                        else
                            Jid = String.Empty;

                        _username = value;
                       } 
                }
                public string Nickname { get; set; }
            }

            public List<WhatsAppGroup> WhatsAppGroups { get; private set; }
            public class WhatsAppGroup
            {
                string _groupid = "";

                public string Jid { get; private set; }
                public string GroupId
                {
                    get { return _groupid; }
                    set
                    {
                        if (Regex.IsMatch(value, "^[0-9]*-[0-9]*$"))
                            Jid = WhatsAppApi.WhatsApp.GetJID(value);
                        else
                            Jid = String.Empty;

                        _groupid = value;
                   
                    } 

                }
                public string Grupo { get; set; }
                public List<WhatsAppUser> Users { get; set; }
            }

            public void UpdateListUser()
            {
                SqlDao dao = new SqlDao();
                string _sql = @"SELECT username
		                        ,nickname
		                        ,tpserver from tb_contatos order by nickname asc";

                List<TbContatos> tbcontatos = null;

                using (System.Data.SQLite.SQLiteCommand command = dao.GetSqlCommand(_sql))
                {                

                    tbcontatos = dao.GetList<TbContatos>(command);
                    
                    List<WhatsAppUser> w = new List<WhatsAppUser>();

                    foreach (TbContatos t in tbcontatos)
                    {
                        w.Add(new WhatsAppUser()
                        {
                            Nickname = t.nickname,
                            Username = t.username
                        });
                    }

                    WhatsAppUsers = w;
                }

                dao = null;
            }

            public void UpdateListGroup()
            {
                SqlDao dao = new SqlDao();
                string _sql = @"SELECT *
                                FROM (
	                                SELECT tgc.groupid
		                                ,(
			                                SELECT tg.groupname
			                                FROM tb_group tg
			                                WHERE tg.groupid = tgc.groupid
				                                AND tg.tpserver = tgc.tpserver
			                                ) AS groupname
		                                ,tgc.username
		                                ,(
			                                SELECT tc.nickname
			                                FROM tb_contatos tc
			                                WHERE tc.username = tgc.username
				                                AND tc.tpserver = tgc.tpserver
			                                ) AS nickname
		                                ,tgc.tpserver
	                                FROM tb_group_contatos tgc
	
	                                UNION ALL
	
	                                SELECT tg.groupid
		                                ,tg.groupname
		                                ,NULL
		                                ,NULL
		                                ,tg.tpserver
	                                FROM tb_group tg
	                                WHERE tg.tpserver = 0
		                                AND groupid LIKE '%-%'
	                                ) t
                                ORDER BY t.groupname
	                                ,t.nickname ASC";


                using (System.Data.SQLite.SQLiteCommand command = dao.GetSqlCommand(_sql))
                {
                    System.Data.SQLite.SQLiteDataReader rs = dao.ExecuteReader(command);

                    if (rs != null)
                    {
                        List<WhatsAppUser> wu = null;
                        List<WhatsAppGroup> wg = new List<WhatsAppGroup>();                        
                        WhatsAppGroup w = null;

                        while (rs.Read())
                        { 
                            if(wu != null && w != null && !w.GroupId.Equals(rs["groupid"].ToString())){
                                w.Users = wu;
                                wg.Add(w);

                                w = null;
                                wu = null;
                            }
                            
                            if (!wg.Exists(x => x.GroupId == rs["groupid"].ToString()) && wu == null)
                            {
                               w = new WhatsAppGroup(){
                                    GroupId = rs["groupid"].ToString(),
                                    Grupo = rs["groupname"].ToString()                                    
                                };

                               if (!rs.IsDBNull(2))
                                   wu = new List<WhatsAppUser>();
                               else
                                   wu = null;
                            }

                            if (!rs.IsDBNull(2))
                            {
                                wu.Add(new WhatsAppUser
                                {
                                    Nickname = rs["nickname"].ToString(),
                                    Username = rs["username"].ToString()

                                });
                            }

                        }

                        //ultima linha
                        if (w != null)
                        {
                            w.Users = wu;
                            wg.Add(w);
                        }

                        WhatsAppGroups = wg;
                        
                    }

                    command.Connection.Close();

                    
                }

                dao = null;
            }
            #endregion
        
       

     
    
    }
}
