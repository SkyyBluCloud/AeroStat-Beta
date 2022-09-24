using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace AeroStat_Beta
{
    public class DataAccess
    {
        public List<Traffic> getFlights (Traffic.Direction dir, bool hasPPR)
        {
            using (IDbConnection connection = new SqlConnection(SQLHelper.cnnVal("testAeroStat")))
            {
                var output = connection.Query<Traffic>($"SELECT * FROM tblTraffic WHERE direction = '{ dir }' AND (PPR Is Not Null) = { hasPPR }").ToList();
                return output;
            }
        }
        public List<User> getUsers()
        {
            using (IDbConnection connection = new SqlConnection(SQLHelper.cnnVal("testAeroStat")))
            {
                var output = connection.Query<User>($"SELECT * FROM tblUserAuth;").ToList();
                return output;
            }
        }
    }
}
