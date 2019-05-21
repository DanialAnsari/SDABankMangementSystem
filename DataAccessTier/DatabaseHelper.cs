using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessTier
{
    class DatabaseHelper
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;

        public DatabaseHelper()
        {
            string connectionString = "Data Source=LAPTOP-N3NU3IOC\\MSSQLSERVER14;Initial Catalog=SDA_BANK_MANAGEMENT_DATABASE;Integrated Security=True";
            conn = new SqlConnection(connectionString);
        }

        public DataTable Select(string q)
        {
            try
            {

                cmd = new SqlCommand(q, conn);
                conn.Open();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public bool insertUpdateDelete(string query)
        {
            try
            {
                cmd = new SqlCommand(query, conn);
                conn.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    conn.Close();
                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            conn.Close();
            return false;

        }
    }
}
