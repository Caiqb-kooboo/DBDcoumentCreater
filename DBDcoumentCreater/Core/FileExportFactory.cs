using DBDcoumentCreater.Lib;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBDcoumentCreater.Core
{
    public class FileExportFactory
    {
        public static IExport Create(string dbType, string Conn)
        {
            switch (dbType.ToUpper())
            {
                //case "HTML": return new SqlDAL(Conn);
                //case "PDF": return new OracleDAL(Conn);
                case "CHM": return new CHMFileExport();
                default: return null;
            }
        }
    }
}
