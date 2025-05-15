using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Hasta_Randevu_Sistemi___PRS
{
    public class dbHelper
    {
        public static string connectionString = "Server=MERTT\\SQLEXPRESS;Database=HastaneKayit;Trusted_Connection=True;TrustServerCertificate=true;";
        private object cmd;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
        public DataTable ExecuteSelectQuery(string query)
        {
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
        public DataTable ExecuteSelectQuery(string query, params SqlParameter[] paramerters)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn)) 
                {
                    if (paramerters != null)
                    {

                        cmd.Parameters.AddRange(paramerters);
                    }
                    SqlDataAdapter dr = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dr.Fill(dt);
                    return dt;
                }
            }


        }
        public void ExecuteInsertQuery(string query, params SqlParameter[] paramerters)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (paramerters != null)
                    {
                        cmd.Parameters.AddRange(paramerters); 
                        cmd.ExecuteNonQuery();
                    }
                    
                   
                }
            }
        }
        public object ExecuteScalar(string query, params SqlParameter[] paramerters)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (paramerters != null)
                    {
                        cmd.Parameters.AddRange(paramerters);
                    }
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
