using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FinalProject
{
    class Connection
    {
        Utility myUtility = new Utility();

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

        public void RequestMoney(MySqlConnection conn, string firstname, string lastname, string sender, string reciever, string amount)
        {
            //Form SQL Statement
            string stm = "insert into Transactions(firstName, lastName, sender, reciever, amount) values (@firstName, @lastName, @sender, @reciever, @amount)";

            // Prepare SQL Statement
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            cmd.Parameters.AddWithValue("@firstName", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@sender", sender);
            cmd.Parameters.AddWithValue("@reciever", reciever);
            cmd.Parameters.AddWithValue("@amount", amount);
            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Close();
        }

        public void SendMoney(MySqlConnection conn, string firstname, string lastname, string sender, string reciever, string amount)
        {
            //Form SQL Statement
            string stm = "insert into Transactions(firstName, lastName, sender, reciever, amount) values (@firstName, @lastName, @sender, @reciever, @amount)";

            // Prepare SQL Statement
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            cmd.Parameters.AddWithValue("@firstName", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@sender", sender);
            cmd.Parameters.AddWithValue("@reciever", reciever);
            cmd.Parameters.AddWithValue("@amount", amount);
            MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Close();
        }
    }
}
