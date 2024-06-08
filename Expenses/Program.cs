namespace Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string response;
            string otherResponse="y";
            int weekDays = 7;
            int typeOfExpense;
            int[,] nutrition = new int[7, 10];
            int[,] transport = new int[7, 10];
            int[,] education = new int[7, 10];
            int[,] communication = new int[7, 10];
            int[,] utilities = new int[7, 10];
            int[,] others = new int[7, 10];

            for (int i = 0; i < weekDays; i++)
            {
                Console.WriteLine("ENTER DAY OF THE WEEK: ");
                int numberOfDay = int.Parse(Console.ReadLine());
                

                Console.WriteLine($"IS THERE ANY EXPENSE ON DAY {numberOfDay}? (y - yes / n - no)");
                response = Console.ReadLine(); 
                if(response == "y")
                {
                    Console.WriteLine("1 . Nutrition");
                    Console.WriteLine("2 . Transport");
                    Console.WriteLine("3 . Education");
                    Console.WriteLine("4 . Communication");
                    Console.WriteLine("5 . Utilities");
                    Console.WriteLine("6 . Others");

                    Console.WriteLine("ENTER TYPE OF EXPENSE: ");
                    typeOfExpense = int.Parse(Console.ReadLine());

                    switch (typeOfExpense) 
                    {
                        case 1:
                            {
                                Console.WriteLine($"ENTER THE AMOUNT SPEND FOR EXPENSE {typeOfExpense} ON DAY {numberOfDay}");
                                int j = 0;
                                while (otherResponse == "y" && j < 10)
                                {
                                    nutrition[numberOfDay, j] = int.Parse(Console.ReadLine());
                                    Console.WriteLine("IS THERE OTHER EXPENSE TODAY? (y - yes / n - no)");
                                    otherResponse = Console.ReadLine();
                                    j++;
                                }   

                            } break;
                        case 2:
                            {
                                Console.WriteLine($"ENTER THE AMOUNT SPEND FOR EXPENSE {typeOfExpense} ON DAY {numberOfDay}");
                                int j = 0;
                                while (otherResponse == "y" && j < 10)
                                {
                                    transport[numberOfDay, j] = int.Parse(Console.ReadLine());
                                    Console.WriteLine("IS THERE OTHER EXPENSE TODAY? (y - yes / n - no)");
                                    otherResponse = Console.ReadLine();
                                    j++;
                                }
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine($"ENTER THE AMOUNT SPEND FOR EXPENSE {typeOfExpense} ON DAY {numberOfDay}");
                                int j = 0;
                                while (otherResponse == "y" && j < 10)
                                {
                                    education[numberOfDay, j] = int.Parse(Console.ReadLine());
                                    Console.WriteLine("IS THERE OTHER EXPENSE TODAY? (y - yes / n - no)");
                                    otherResponse = Console.ReadLine();
                                    j++;
                                }   
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine($"ENTER THE AMOUNT SPEND FOR EXPENSE {typeOfExpense} ON DAY {numberOfDay}");
                                int j = 0;
                                while (otherResponse == "y" && j < 10)
                                {
                                    communication[numberOfDay, j] = int.Parse(Console.ReadLine());
                                    Console.WriteLine("IS THERE OTHER EXPENSE TODAY? (y - yes / n - no)");
                                    otherResponse = Console.ReadLine();
                                    j++;
                                }   
                            }
                            break;
                        case 5:
                            {
                                Console.WriteLine($"ENTER THE AMOUNT SPEND FOR EXPENSE {typeOfExpense} ON DAY {numberOfDay}");
                                int j = 0;
                                while (otherResponse == "y" && j < 10)
                                {
                                    utilities[numberOfDay, j] = int.Parse(Console.ReadLine());
                                    Console.WriteLine("IS THERE OTHER EXPENSE TODAY? (y - yes / n - no)");
                                    otherResponse = Console.ReadLine();
                                    j++;
                                }
                            }
                            break;
                        case 6:
                            {
                                Console.WriteLine($"ENTER THE AMOUNT SPEND FOR EXPENSE {typeOfExpense} ON DAY {numberOfDay}");
                                int j = 0;
                                while (otherResponse == "y" && j < 10)
                                {
                                    others[numberOfDay, j] = int.Parse(Console.ReadLine());
                                    Console.WriteLine("IS THERE OTHER EXPENSE TODAY? (y - yes / n - no)");
                                    otherResponse = Console.ReadLine();
                                    j++;
                                }
                            }
                            break;
                    }
                }

            }


        }
    }
}
