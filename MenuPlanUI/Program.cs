using static System.Runtime.InteropServices.JavaScript.JSType;
using MenuDataLayer;
using MenuBusinessLogic;
using MenuModel;
namespace MenuPlanUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            { 
                Console.WriteLine("WELCOME TO MENU PLAN FOR BULKING AND CUTTING");
                Console.WriteLine("Select Which Menu Plan You Want: ");
                Console.WriteLine("1. Bulking");
                Console.WriteLine("2. Cutting");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter Number:");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        {
                            SelectBulkDay();
                            break;
                        }

                    case "2":
                        {
                            SelectCutDay();
                            break;
                        }

                    case "3":
                        {
                            exit = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("ERROR WRONG INPUT!");
                            break;
                        }
                }
            }

        }

        static void Display(Menu menu)
        {

            Console.WriteLine("Meal: " + menu.meal);
            Console.WriteLine("Name of the Dish: " + menu.dish);
            Console.WriteLine("\nSelect Beverage: " + menu.beverage);
            Console.WriteLine("\nOptional: " + menu.preference);
            Console.WriteLine("\nNutritional Value: " + menu.nutrition);
            Console.WriteLine("\nTime to eat: " + menu.time);

        }

        public static void SelectBulkDay()
        {
            Console.WriteLine("Select Day: ");
            Console.WriteLine("1. Day 1");
            Console.WriteLine("2. Day 2");
            Console.WriteLine("3. Day 3");
            Console.WriteLine("Please Enter Which Day");
            string selectd = Console.ReadLine();

            switch (selectd)
            {
                case "1":
                    BulkMenu1();
                    break;

                case "2":
                    BulkMenu2();
                    break;

                case "3":
                    BulkMenu3();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        public static void SelectCutDay()
        {
            Console.WriteLine("Select Day: ");
            Console.WriteLine("1. Day 1");
            Console.WriteLine("2. Day 2");
            Console.WriteLine("3. Day 3");
            Console.WriteLine("Please Enter Which Day");
            string selectd = Console.ReadLine();

            switch (selectd)
            {
                case "1":
                    CutMenu1();
                    break;

                case "2":
                    CutMenu2();
                    break;

                case "3":
                    CutMenu3();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        static void BulkMenu1()
        {
            Data data = new Data();

            Console.WriteLine("\nSelect Meal Option:");
            Console.WriteLine("1. Breakfast");
            Console.WriteLine("2. Lunch");
            Console.WriteLine("3. Dinner");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Display(data.menus[0]);
                    break;

                case "2":
                    Display(data.menus[1]);
                    break;

                case "3":
                    Display(data.menus[2]);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        static void BulkMenu2()
        {
            Data data = new Data();

            Console.WriteLine("\nSelect Meal Option:");
            Console.WriteLine("1. Breakfast");
            Console.WriteLine("2. Lunch");
            Console.WriteLine("3. Dinner");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Display(data.menus[3]);
                    break;

                case "2":
                    Display(data.menus[4]);
                    break;

                case "3":
                    Display(data.menus[5]);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        static void BulkMenu3()
        {
            Data data = new Data();

            Console.WriteLine("\nSelect Meal Option:");
            Console.WriteLine("1. Breakfast");
            Console.WriteLine("2. Lunch");
            Console.WriteLine("3. Dinner");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Display(data.menus[6]);
                    break;

                case "2":
                    Display(data.menus[7]);
                    break;

                case "3":
                    Display(data.menus[8]);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
        static void CutMenu1()
        {
            Data data = new Data();

            Console.WriteLine("\nSelect Meal Option:");
            Console.WriteLine("1. Breakfast");
            Console.WriteLine("2. Lunch");
            Console.WriteLine("3. Dinner");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Display(data.menus[9]);
                    break;

                case "2":
                    Display(data.menus[10]);
                    break;

                case "3":
                    Display(data.menus[11]);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        static void CutMenu2()
        {
            Data data = new Data();

            Console.WriteLine("\nSelect Meal Option:");
            Console.WriteLine("1. Breakfast");
            Console.WriteLine("2. Lunch");
            Console.WriteLine("3. Dinner");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Display(data.menus[12]);
                    break;

                case "2":
                    Display(data.menus[13]);
                    break;

                case "3":
                    Display(data.menus[14]);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        static void CutMenu3()
        {
            Data data = new Data();

            Console.WriteLine("\nSelect Meal Option:");
            Console.WriteLine("1. Breakfast");
            Console.WriteLine("2. Lunch");
            Console.WriteLine("3. Dinner");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    Display(data.menus[15]);
                    break;

                case "2":
                    Display(data.menus[16]);
                    break;

                case "3":
                    Display(data.menus[17]);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
