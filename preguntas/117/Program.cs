/*QUESTION 117
HOTSPOT
You have the following code (line numbers are included for reference only):
*/

using System;
using System.Data;
using System.Data.SqlClient;

namespace _117
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            DataTable dataTable;
            string connString = "Data Source=192.168.1.13;Initial Catalog=AdventureWorks2017;User Id =sa; Password=Zaq11qaz";
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                sqlConn.Open();
                using (SqlCommand sqlCmd = new SqlCommand())
                {
                    sqlCmd.Connection = sqlConn;
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.CommandText = "uspGetBillOfMaterials";
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
}
/* 
 * 
Pregunta:
the database connection gets closed at line 
la conexión de la base de datos se cierra en la línea
Respuesta: Linea 19 del texto original 35 del texto del presente còdigo

the adapter object  get disposed at line 
el objeto adaptador se desecha en la línea
Respuesta: Linea 17 del texto de la pregunta 33 del texto del presente còdigo
*

Dificultad. Para que el código funcione he tenido que añadir el paquete nuget System.Data.SqlClient

Right Click on Project > Manage Nuget Packages > Search & install 'System.Data.SqlClient'

*/

