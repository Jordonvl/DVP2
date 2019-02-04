using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JordonvanLeenen_CodeFiles
{
    class Menu
    {
        //Constructor statement running the display method
        public Menu()
        {
            Display();
        }

        //Main Menu
        public void Display()
        {
            bool running = true;
            string input = "";

            //looping through the options in my menu
            while (running)
            {
                
                Console.Clear();
                Console.WriteLine("Main menu: ");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1. Enter Activity");
                Console.WriteLine("2. View Tracked Data");
                Console.WriteLine("3. Sort Restaurants From Best/Most Stars to Worst");
                Console.WriteLine("4. Sort Restaurants From Worst/Least Stars to Best");
                Console.WriteLine("5. Show Only X and Up");
                Console.WriteLine("6. Exit");
                Console.Write("Enter a selection: (1 - 6): ");
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
                    case "Enter Activity":

                        Console.Clear();
                        SubMenu1();

                        break;
                    case "2":
                    case "View Tracked Data":

                        Console.Clear();
                        SubMenu2();
                        Console.ReadKey();
                        SubMenu1();

                        break;
                    case "3":
                    case "Run Calculations":

                        Console.Clear();
                        

                        break;
                    case "4":
                    case "Exit":

                        Console.Clear();
                        running = false;

                        break;
                }

                Console.WriteLine("Press a key to continue.");
                Console.ReadKey();
            }
        }

        //Sub Menu #1 Method
        public void SubMenu1()
        {
            bool running = true;
            string input = "";

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Sub menu: ");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Pick a Category of Activity)");
                Console.WriteLine("1. Eat");
                Console.WriteLine("2. Design Class");
                Console.WriteLine("3. Portfolio Class");
                Console.WriteLine("4. Relaxation");
                Console.WriteLine("5. Driving");
                Console.WriteLine("6. Showering");
                Console.WriteLine("7. Sleeping");
                Console.WriteLine("8. Back");
                Console.Write("Enter a selection: (1 - 8): ");
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
                    case "Eat":

                        Console.Clear();
                        SubMenu2();

                        break;
                    case "2":
                    case "Design Class":

                        Console.Clear();
                        SubMenu2();

                        break;
                    case "3":
                    case "Portfolio Class":

                        Console.Clear();
                        SubMenu2();

                        break;
                    case "4":
                    case "Relaxation":

                        Console.Clear();
                        SubMenu2();

                        break;
                    case "5":
                    case "Driving":

                        Console.Clear();
                        SubMenu2();

                        break;
                    case "6":
                    case "Showering":

                        Console.Clear();
                        SubMenu2();

                        break;
                    case "7":
                    case "Sleep":

                        Console.Clear();
                        SubMenu2();

                        break;
                    case "8":
                    case "back":

                        Console.Clear();
                        running = false;

                        break;
                }

                Console.WriteLine("Press a key to continue.");
                Console.ReadKey();
            }
        }

        //Sub Menu #2 Method
        public void SubMenu2()
        {
            bool running = true;
            string input = "";

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Sub menu2: ");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("What Date Did You Perfom the Activity");
                Console.WriteLine("1. 2019-01-08");
                Console.WriteLine("2. 2019-01-09");
                Console.WriteLine("3. 2019-01-10");
                Console.WriteLine("4. 2019-01-11");
                Console.WriteLine("5. 2019-01-12");
                Console.WriteLine("6. 2019-01-13");
                Console.WriteLine("7. 2019-01-14");
                Console.WriteLine("8. 2019-01-15");
                Console.WriteLine("9. 2019-01-16");
                Console.WriteLine("10. 2019-01-17");
                Console.WriteLine("11. 2019-01-18");
                Console.WriteLine("12. 2019-01-19");
                Console.WriteLine("13. 2019-01-20");
                Console.WriteLine("14. 2019-01-21");
                Console.WriteLine("15. 2019-01-22");
                Console.WriteLine("16. 2019-01-23");
                Console.WriteLine("17. 2019-01-24");
                Console.WriteLine("18. 2019-01-25");
                Console.WriteLine("19. 2019-01-26");
                Console.WriteLine("20. 2019-01-27");
                Console.WriteLine("21. 2019-01-28");
                Console.WriteLine("22. 2019-01-29");
                Console.WriteLine("23. 2019-01-30");
                Console.WriteLine("24. 2019-01-31");
                Console.WriteLine("25. 2019-02-01");
                Console.WriteLine("26. 2019-02-02");
                Console.WriteLine("27. Back");
                Console.Write("Enter a selection: (1 - 27): ");
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
                    case "2019-01-08":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "2":
                    case "2019-01-09":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "3":
                    case "2019-01-10":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "4":
                    case "2019-01-11":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "5":
                    case "2019-01-12":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "6":
                    case "2019-01-13":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "7":
                    case "2019-01-14":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "8":
                    case "2019-01-15":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "9":
                    case "2019-01-16":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "10":
                    case "2019-01-17":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "11":
                    case "2019-01-18":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "12":
                    case "2019-01-19":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "13":
                    case "2019-01-20":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "14":
                    case "2019-01-21":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "15":
                    case "2019-01-22":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "16":
                    case "2019-01-23":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "17":
                    case "2019-01-24":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "18":
                    case "2019-01-25":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "19":
                    case "2019-01-26":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "20":
                    case "2019-01-27":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "21":
                    case "2019-01-28":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "22":
                    case "2019-01-29":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "23":
                    case "2019-01-30":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "24":
                    case "2019-01-31":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "25":
                    case "2019-02-01":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "26":
                    case "2019-02-02":

                        Console.Clear();
                        SubMenu3();

                        break;
                    case "27":
                    case "back":

                        Console.Clear();
                        running = false;

                        break;
                }

                Console.WriteLine("Press a key to continue.");
                Console.ReadKey();
            }
        }

        //Sub Menu #3 Method
        public void SubMenu3()
        {
            bool running = true;
            string input = "";

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Sub Menu3: ");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("How long did you perform that activity?");
                string activityLength = Console.ReadLine();
                Console.WriteLine("1. Back");
                Console.Write("Enter a selection: (1): ");
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "1":
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
