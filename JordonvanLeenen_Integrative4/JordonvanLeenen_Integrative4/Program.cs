using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JordonvanLeenen_Integrative4
{
    class Program
    {
        static void Main(string[] args)
        {
            // MySQL Database Connection String
            string cs = @"server=10.63.11.65;userid=jordonvl;database=Intagrative;port=8889";

            // Declare a MySQL Connection
            MySqlConnection conn = null;

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);
                conn.Open();

                // Form SQL Statement
                string stm = "Select RestaurantName from RestaurantProfiles;";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                // Execute SQL Statement and Convert Results to a String
                //string version = Convert.ToString(cmd.ExecuteScalar());

                // Output Results
                while (rdr.Read())
                {
                    Console.WriteLine(rdr["RestaurantName"]);
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
