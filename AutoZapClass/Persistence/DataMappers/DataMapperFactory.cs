using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteBAL.Persistence.DataMappers
{
    class DataMapperFactory
    {
        //permite mapear todos cas classes
        public IDataMapper GetMapper(Type dtoType)
        {
            switch (dtoType.Name)
            {
                case "TbConfig":
                    return new TbConfigMapper();
                case "TbContatos":
                    return new TbContatosMapper();
                case "TbGatilho":
                    return new TbGatilhoMapper();
                case "TbGatilhoGrupo":
                    return new TbGatilhoGrupoMapper();
                case "TbGroup":
                    return new TbGroupMapper();
                case "TbGroupContatos":
                    return new TbGroupContatosMapper();
                default:
                    return new GenericMapper(dtoType);
            }
        }
    }
}
