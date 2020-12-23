using System;

namespace MyCrane
{
    class Program
    {
        public static void WriteToDo()
        {
            Console.WriteLine("Construction crane. What to do: ");
            Console.WriteLine("1-Turn on.");
            Console.WriteLine("2-Turn off.");
            Console.WriteLine("3-Get the cargo");
            Console.WriteLine("4-Turn to the right.");
            Console.WriteLine("5-Turn to the left.");
            Console.WriteLine("6-Check crane.");
            Console.WriteLine("7-Exit.");

        }

        public static void PrintException(string massage)
        {
            Console.WriteLine(massage);
        }

        static void Main(string[] args)
        {
            bool isOpen = true;
            Crane crane = new Crane();
            WriteToDo();

            while (isOpen)
            {
                int action = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (action)
                    {
                        case 1:
                            crane.ToOn();
                            Console.WriteLine(crane.CraneNow());
                            break;

                        case 2:
                            crane.ToOff();
                            Console.WriteLine(crane.CraneNow());
                            break;

                        case 3:
                            Console.WriteLine("Insert waight of your cargo.");
                            int weight = Convert.ToInt32(Console.ReadLine());
                            crane.GetCargo(weight);
                            Console.WriteLine(crane.CraneNow());
                            break;

                        case 4:
                            crane.ToRight();
                            Console.WriteLine(crane.CraneNow());
                            break;

                        case 5:
                            crane.ToLeft();
                            Console.WriteLine(crane.CraneNow());
                            break;

                        case 6:
                            Console.WriteLine(crane.CraneNow());
                            break;

                        case 7:
                            isOpen = false;
                            break;
                    }
                }
                catch (FormatException)
                {
                    WriteToDo();
                }
                catch (InvalidOperationException ex)
                {
                    PrintException(ex.Message);
                }
            }
        }
    }
}
