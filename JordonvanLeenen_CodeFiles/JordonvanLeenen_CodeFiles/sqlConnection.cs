using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JordonvanLeenen_CodeFiles
{
    class sqlConnection
    {
        public sqlConnection()
        {
            // MySQL Database Connection String
            string cs = @"server=192.168.0.18;userid=jordonvl;database=JordonvanLeenen_MDV229_Database_12019;port=8889";

            // Declare a MySQL Connection
            MySqlConnection conn = null;

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);
                conn.Open();

                // Form SQL Statement
                string stm = "Select category_description from activity_categories;";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                // Execute SQL Statement and Convert Results to a String
                //string version = Convert.ToString(cmd.ExecuteScalar());

                // Output Results
                while (rdr.Read())
                {
                    Console.WriteLine(rdr["category_description"]);
                }


            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            Console.WriteLine("Done");
        }
    }
}
