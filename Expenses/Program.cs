using System.Runtime.CompilerServices;

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

            // Console.WriteLine("IS THERE OTHER EXPENSE TODAY? (y - yes / n - no)");
            // otherResponse == "y" &&
            // otherResponse = Console.ReadLine();
            //j++;

            for (int i = 1; i <= weekDays; i++)
            {
                Console.WriteLine("ENTER DAY OF THE WEEK: ");
                int numberOfDay = int.Parse(Console.ReadLine());
                
                Console.WriteLine($"IS THERE ANY EXPENSE ON DAY {numberOfDay}? (y - yes / n - no)");
                response = Console.ReadLine(); 
                if(response == "y")
                {
                    int j = 0;
                    string expenseResponseForTheDay = "y";
                    while (j < 10 && expenseResponseForTheDay == "y")
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
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        nutrition[numberOfDay-1, j] = int.Parse(Console.ReadLine());
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        transport[numberOfDay-1, j] = int.Parse(Console.ReadLine());
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        education[numberOfDay-1, j] = int.Parse(Console.ReadLine());
                                    }
                                    break;
                                case 4:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        communication[numberOfDay-1, j] = int.Parse(Console.ReadLine());
                                    }
                                    break;
                                case 5:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        utilities[numberOfDay-1, j] = int.Parse(Console.ReadLine());
                                    }
                                    break;
                                case 6:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        others[numberOfDay-1, j] = int.Parse(Console.ReadLine());
                                    }
                                    break;
                            }
                        
                        Console.WriteLine($"IS THERE OTHER EXPENSE ON DAY {numberOfDay}? (y - yes / n - no)");
                        expenseResponseForTheDay = Console.ReadLine();
                        
                            j++;

                    }
                }
                else if(response == "n")
                {
                    Console.WriteLine($"THERE IS NO ANY EXPENSE ON DAY {numberOfDay}.");
                }
            }

            Print(nutrition, "Nutrition : ");
            Print(transport, "Transport : ");
            Print(education, "Education : ");
            Print(communication, "Communication: ");
            Print(utilities, "Utilities: ");
            Print(others, " Others: ");

            Console.WriteLine($"TOTAL AMOUNT SPEND ON NUTRITION IS {TotalAmountOfExpense(nutrition)}");
            Console.WriteLine($"TOTAL AMOUNT SPEND ON TRANSPORT IS {TotalAmountOfExpense(transport)}");
            Console.WriteLine($"TOTAL AMOUNT SPEND ON EDUCATION IS {TotalAmountOfExpense(education)}");
            Console.WriteLine($"TOTAL AMOUNT SPEND ON COMMUNICATION IS {TotalAmountOfExpense(communication)}");
            Console.WriteLine($"TOTAL AMOUNT SPEND ON UTILITIES IS {TotalAmountOfExpense(utilities)}");
            Console.WriteLine($"TOTAL AMOUNT SPEND ON OTHERS IS {TotalAmountOfExpense(others)}");
        }
       
        public static double TotalAmountOfExpense(int[,] nutrition )
        {
            int totalAmount = 0;
            for (int i = 0; i < 7; i++  )
            {
                for(int j = 0; j < 10; j++)
                {
                    totalAmount += nutrition[i, j]; 
                }
            }
            return totalAmount;
        }
        public static void Print(int[,] expenseArray, string expenseName)
        {
            Console.WriteLine($"{ expenseName}");
            Console.WriteLine("M      T      W      T      F      S      S");

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{expenseArray[i, j]}    ");
                }
                Console.WriteLine();

            }
        }

        public static string GetNameOfExpense(int expenseNumber)
        {
            string expenseName;

            switch(expenseNumber)
            {
                case 1 :
                    {
                        expenseName = "NUTRITION";
                    }
                    break;
                case 2:
                    {
                         expenseName =  "TRANSPORT";
                    }
                    break;
                case 3:
                    {
                        expenseName = "EDUCATION";
                    }
                    break;
                case 4:
                    {
                        expenseName = "COMMUNICATION";
                    }
                    break;
                case 5:
                    {
                        expenseName = "UTILITIES";
                    }
                    break;
                default :
                    {
                        expenseName = "OTHERS";
                    }
                    break;
            }
            return expenseName;
        }
    }
}
