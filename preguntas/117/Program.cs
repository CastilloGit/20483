
using System;
using System.Data;
using System.Data.SqlClient:

namespace _117
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            DataTable dataTable;
            string connString = "Data Source=192.168.1.13;Initial Catalog=Database1;User Id = sa; Password=Zaq11qaz";
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                sqlConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = sqlConn;
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.CommandText = "p_Procedure1";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd))
                    {
                        using (dataTable = new DataTable())
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
        }
    }
