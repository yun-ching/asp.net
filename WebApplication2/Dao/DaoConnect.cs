using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication2.Dao
{
    public class DaoConnect
    {
        public SqlConnection SqlConnect()
        {
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
            return conn;
        }

    }
}