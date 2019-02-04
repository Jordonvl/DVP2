using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordonvanLeenen_Integrative4
{
    class Menu
    {
        sqlConn myConn = new sqlConn();

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
                Console.WriteLine("1. List Restaurants Alphabetically");
                Console.WriteLine("2. List Restaurants in Reverse Alphabetical");
                Console.WriteLine("3. Sort Restaurants From Best/Most Stars to Worst");
                Console.WriteLine("4. Sort Restaurants From Worst/Least Stars to Best");
                Console.WriteLine("5. Show Only X and Up");
                Console.WriteLine("6. Play a Fun Card Game!");
                Console.WriteLine("7. Exit");
                Console.Write("Enter a selection: (1 - 6): ");
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
                    case "List Restaurants Alphabetically":

                        Console.Clear();
                        

                        break;
                    case "2":
                    case "List Restaurants in Reverse Alphabetical":

                        Console.Clear();
                        

                        break;
                    case "3":
                    case "Sort Restaurants From Best/Most Stars to Worst":

                        Console.Clear();
                        

                        break;
                    case "4":
                    case "Sort Restaurants From Worst/Least Stars to Best":

                        Console.Clear();
                        

                        break;
                    case "5":
                    case "Show Only X and Up":

                        Console.Clear();
                        SubMenu();

                        break;
                    case "6":
                    case "Play a Fun Card Game!":

                        Console.Clear();
                        Console.WriteLine("This game has 4 players, 13 cards per player. Whoever has the highest total hand value will win the game.");
                        myConn.GetNames();

                        break;
                    case "7":
                    case "Exit":

                        Console.Clear();
                        running = false;

                        break;
                }

                Console.WriteLine("Press a key to continue.");
                Console.ReadKey();
            }
        }

        //Sub Menu Method
        public void SubMenu()
        {
            bool running = true;
            string input = "";

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Sub menu: ");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Show the Best(5 Stars)");
                Console.WriteLine("2. Show 4 Stars and Up");
                Console.WriteLine("3. Show 3 Stars and Up");
                Console.WriteLine("4. Show the Worst(1 Stars)");
                Console.WriteLine("5. Show Unrated");
                Console.WriteLine("6. Back");
                Console.Write("Enter a selection: (1 - 6): ");
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
                    case "Show the Best(5 Stars)":

                        Console.Clear();


                        break;
                    case "2":
                    case "Show 4 Stars and Up":

                        Console.Clear();


                        break;
                    case "3":
                    case "Show 3 Stars and Up":

                        Console.Clear();


                        break;
                    case "4":
                    case "Show the Worst(1 Stars)":

                        Console.Clear();


                        break;
                    case "5":
                    case "Show Unrated":

                        Console.Clear();


                        break;
                    case "6":
                    case "Back":

                        Console.Clear();
                        running = false;

                        break;
                }

                Console.WriteLine("Press a key to continue.");
                Console.ReadKey();
            }
        }
    }
}
