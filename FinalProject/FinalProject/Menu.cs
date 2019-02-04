using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FinalProject
{
    class Menu
    {
        Connection myConnection = new Connection();
        Utility myUtility = new Utility();

        public Menu()
        {
            Display();
        }
        public void Display()
        {
            bool running = true;
            string input = "";

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Main menu: ");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Log In");
                Console.WriteLine("2. Request");
                Console.WriteLine("3. Send");
                Console.WriteLine("4. Exit");
                Console.Write("Enter a selection: (1 - 4): ");
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
                    case "Log In":

                        Console.Clear();
                        Console.WriteLine("Enter your email");
                        string eName = Console.ReadLine();
                        eName = myUtility.StringValidation(eName);
                        Console.WriteLine("Enter password");
                        string uPass = Console.ReadLine();
                        uPass = myUtility.StringValidation(uPass);

                        string cs = @"server=192.168.0.38;userid=jordonvl;database=Portfolio;port=8889";
                        MySqlConnection conn = new MySqlConnection(cs);
                        conn.Open();
                        myConnection.LogInCheck(conn, eName, uPass);
                        conn.Close();

                        break;
                    case "2":
                    case "Request":

                        Console.Clear();
                        Console.WriteLine("Enter first name");
                        string fName = Console.ReadLine();
                        fName = myUtility.StringValidation(fName);
                        Console.WriteLine("Enter last name");
                        string lName = Console.ReadLine();
                        lName = myUtility.StringValidation(lName);
                        Console.WriteLine("Enter amount");
                        string tAmount = Console.ReadLine();
                        tAmount = myUtility.StringValidation(tAmount);
                        string sender = null;
                        string reciever = "1";

                        cs = @"server=192.168.0.38;userid=jordonvl;database=Portfolio;port=8889";
                        conn = new MySqlConnection(cs);
                        conn.Open();
                        myConnection.RequestMoney(conn, fName, lName, sender, reciever, tAmount);
                        conn.Close();

                        break;
                    case "3":
                    case "Send":

                        Console.Clear();
                        Console.WriteLine("Enter first name");
                        fName = Console.ReadLine();
                        fName = myUtility.StringValidation(fName);
                        Console.WriteLine("Enter last name");
                        lName = Console.ReadLine();
                        lName = myUtility.StringValidation(lName);
                        Console.WriteLine("Enter amount");
                        tAmount = Console.ReadLine();
                        tAmount = myUtility.StringValidation(tAmount);
                        string nSender = "1";
                        string nReciever = null;

                        cs = @"server=192.168.0.38;userid=jordonvl;database=Portfolio;port=8889";
                        conn = new MySqlConnection(cs);
                        conn.Open();
                        myConnection.SendMoney(conn, fName, lName, nSender, nReciever, tAmount);
                        conn.Close();

                        break;
                    case "4":
                    case "exit":

                        running = false;

                        break;
                }

                Console.WriteLine("Press a key to continue.");
                Console.ReadKey();
            }
        }
    }
}
