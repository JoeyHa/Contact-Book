using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace ContactsBook
{
    public static class CmdExtensions
    {
        public static void AddParam(this SqlCommand cmd, string paramName, SqlDbType dbType, object value)
        {
            var p = cmd.Parameters.Add(paramName, dbType);
            p.Value = value;
        }
    }
}
