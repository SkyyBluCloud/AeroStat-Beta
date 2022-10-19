using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Dapper;

namespace AeroStat_Beta
{
    public class DataAccess
    {
        public PPR getPPR(string pprNumber)
        {
            using (IDbConnection connection = new SqlConnection(SQLHelper.cnnVal("testAeroStat")))
            {

                var output = connection.QueryFirst<PPR>("dbo.getPPR @ppr", pprNumber);
                return output;

            }
        }
        public List<PPR> getPPRs()
        {
            using (IDbConnection connection = new SqlConnection(SQLHelper.cnnVal("testAeroStat")))
            {
                var output = connection.Query<PPR>("dbo.getPPRs");
                return output.ToList();
            }
        }
        public List<PPRService> getPPRServices ()
        {
            using (IDbConnection connection = new SqlConnection(SQLHelper.cnnVal("testAeroStat")))
            {
                var output = connection.Query<PPRService>("dbo.getPPRServices");
                return output.ToList();
            }
        }
        public List<Traffic> getFlights (string dir, bool hasPPR)
        {
            using (IDbConnection connection = new SqlConnection(SQLHelper.cnnVal("testAeroStat")))
            {
                //SELECT ID, flightRule, Callsign, 
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

        public static DataTable getDataTable(String table)
        {
            using (SqlConnection conn = new SqlConnection(SQLHelper.cnnVal("testAeroStat")))
            {
                string select = $"SELECT * FROM { table }";
                SqlDataAdapter da = new SqlDataAdapter(select, conn);
                DataTable output = new DataTable();
                da.Fill(output);
                return output;
            }
        }
    }
}
