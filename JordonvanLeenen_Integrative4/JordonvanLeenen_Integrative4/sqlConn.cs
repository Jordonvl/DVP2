using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JordonvanLeenen_Integrative4
{
    class sqlConn
    {
        public void GetNames()
        {
            // MySQL Database Connection String
            string cs = @"server=192.168.0.38;userid=jordonvl;database=Restaurant;port=8889";

            // Declare a MySQL Connection
            MySqlConnection conn = null;

            try
            {
                // Open a connection to MySQL
                conn = new MySqlConnection(cs);
                conn.Open();

                // Form SQL Statement
                string stm = "Select first, last from RestaurantReviewers limit 4;";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                // Execute SQL Statement and Convert Results to a String
                //string version = Convert.ToString(cmd.ExecuteScalar());

                // Output Results
                while (rdr.Read())
                {
                    Console.WriteLine(rdr["first"]);
                    Console.WriteLine(rdr["last"]);
                    Console.WriteLine("---------------------");
                }

                //rdr.Close();
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

        public void LogInCheck(MySqlConnection conn, string email, string password)
        {
            //Form SQL Statement
            string stm = "Select email, password from Users where email=@email and password=@password;";

            // Prepare SQL Statement
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Console.WriteLine(rdr["email"]);
                    Console.WriteLine(rdr["password"]);
                }
            }
            else
            {
                Console.WriteLine("User does not exist");
            }
            rdr.Close();
        }
    }
}
