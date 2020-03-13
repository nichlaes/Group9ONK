using NPoco;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Delopgaveprojekt.DbFactory
{
    public class DbFactory : IDbFactory
    {
        private SqlConnection con = new SqlConnection(Constants.Constants.sqlConnectionString);
        public IDatabase GetConnection()
        {
            con.Open();
            //Database db=new Database(con);
            //db.OpenSharedConnection();

            return new Database(con);
        }
    }
}
