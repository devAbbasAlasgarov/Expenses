using System.Runtime.CompilerServices;

namespace Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string response;
            int weekDays = 7;
            int typeOfExpense;
            double totalSpendingForNutrition = 0;
            double totalSpendingForTransport = 0;
            double totalSpendingForEducation = 0;
            double totalSpendingForCommunication = 0;
            double totalSpendingForUtilities = 0;
            double totalSpendingForOthers = 0;

            int[,] nutrition = new int[7, 10];
            int[,] transport = new int[7, 10];
            int[,] education = new int[7, 10];
            int[,] communication = new int[7, 10];
            int[,] utilities = new int[7, 10];
            int[,] others = new int[7, 10];

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
                                        totalSpendingForNutrition = totalSpendingForNutrition + nutrition[numberOfDay-1, j];    
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        transport[numberOfDay-1, j] = int.Parse(Console.ReadLine());
                                        totalSpendingForTransport = totalSpendingForTransport + transport[numberOfDay - 1, j];
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        education[numberOfDay-1, j] = int.Parse(Console.ReadLine());
                                        totalSpendingForEducation = totalSpendingForEducation + education[numberOfDay - 1, j];
                                    }
                                    break;
                                case 4:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        communication[numberOfDay-1, j] = int.Parse(Console.ReadLine());
                                        totalSpendingForCommunication = totalSpendingForCommunication + communication[numberOfDay - 1, j];
                                    }
                                    break;
                                case 5:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        utilities[numberOfDay-1, j] = int.Parse(Console.ReadLine());
                                        totalSpendingForUtilities = totalSpendingForUtilities + utilities[numberOfDay - 1, j];
                                    }
                                    break;
                                case 6:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        others[numberOfDay-1, j] = int.Parse(Console.ReadLine());
                                        totalSpendingForOthers = totalSpendingForOthers + others[numberOfDay - 1, j];
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
            ///////////////////////////////////////////////////////////////
            // Həftə ərzində toplam xərc
            double totalWeeklySpending = 0;
            int[][,] allExpenses = new int[6][,] { nutrition, transport, education, communication, utilities, others };
            totalWeeklySpending = TotalSpendingPerWeek(allExpenses);
            Console.WriteLine($"TOTAL WEEKLY SPENDING IS {totalWeeklySpending}");
            ///////////////////////////////////////////////////////////////
            //  Ən çox hansı növ üçün xərc çəkilib və miqdarı
            double[] ArrayOfSpendingPerExpense = new double[] { totalSpendingForNutrition,
                                                                totalSpendingForTransport,
                                                                totalSpendingForEducation,
                                                                totalSpendingForCommunication,
                                                                totalSpendingForUtilities,
                                                                totalSpendingForOthers };

            maxSpentAmountPerExpense(ArrayOfSpendingPerExpense);
            ///////////////////////////////////////////////////////////////
            // Ən az hansı növ üçün xərc çəkilib və miqdarı
            minSpentAmountPerExpense(ArrayOfSpendingPerExpense);
            /*   
             * 
               Günlük ortalama xərc nə qədərdir // add counter for every purchase to calculate average dialy spending
               Ən çox hansı gün xərc edilib və miqdarı .
               Ən az hansı gün xərc edilib və miqdarı
            */

            /*
            
            double totalSpendingOnMonday = TotalExpenseOnDay(0, nutrition)
                                                   + TotalExpenseOnDay(0, transport)
                                                   + TotalExpenseOnDay(0, education)
                                                   + TotalExpenseOnDay(0, communication)
                                                   + TotalExpenseOnDay(0, utilities)
                                                   + TotalExpenseOnDay(0, others);
            double totalSpendingOnTuesday = TotalExpenseOnDay(1, nutrition)
                                                    + TotalExpenseOnDay(1, transport)
                                                    + TotalExpenseOnDay(1, education)
                                                    + TotalExpenseOnDay(1, communication)
                                                    + TotalExpenseOnDay(1, utilities)
                                                    + TotalExpenseOnDay(1, others);
            double totalSpendingOnWednesday = TotalExpenseOnDay(2, nutrition)
                                                    + TotalExpenseOnDay(2, transport)
                                                    + TotalExpenseOnDay(2, education)
                                                    + TotalExpenseOnDay(2, communication)
                                                    + TotalExpenseOnDay(2, utilities)
                                                    + TotalExpenseOnDay(2, others);
            double totalSpendingOnThursday = TotalExpenseOnDay(3, nutrition)
                                                    + TotalExpenseOnDay(3, transport)
                                                    + TotalExpenseOnDay(3, education)
                                                    + TotalExpenseOnDay(3, communication)
                                                    + TotalExpenseOnDay(3, utilities)
                                                    + TotalExpenseOnDay(3, others);
            double totalSpendingOnFriday = TotalExpenseOnDay(4, nutrition)
                                                    + TotalExpenseOnDay(4, transport)
                                                    + TotalExpenseOnDay(4, education)
                                                    + TotalExpenseOnDay(4, communication)
                                                    + TotalExpenseOnDay(4, utilities)
                                                    + TotalExpenseOnDay(4, others);
            double totalSpendingOnSaturday = TotalExpenseOnDay(5, nutrition)
                                                    + TotalExpenseOnDay(5, transport)
                                                    + TotalExpenseOnDay(5, education)
                                                    + TotalExpenseOnDay(5, communication)
                                                    + TotalExpenseOnDay(5, utilities)
                                                    + TotalExpenseOnDay(5, others);
            double totalSpendingOnSunday = TotalExpenseOnDay(6, nutrition)
                                                    + TotalExpenseOnDay(6, transport)
                                                    + TotalExpenseOnDay(6, education)
                                                    + TotalExpenseOnDay(6, communication)
                                                    + TotalExpenseOnDay(6, utilities)
                                                    + TotalExpenseOnDay(6, others);
            */
            /*
            totalWeeklySpending = (totalSpendingOnMonday
                                         + totalSpendingOnTuesday
                                         + totalSpendingOnWednesday
                                         + totalSpendingOnThursday
                                         + totalSpendingOnFriday
                                         + totalSpendingOnSaturday
                                         + totalSpendingOnSunday);
            */
            /*
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

           
            double dailyAverageSpending = (totalSpendingOnMonday
                                          + totalSpendingOnTuesday
                                          + totalSpendingOnWednesday
                                          + totalSpendingOnThursday
                                          + totalSpendingOnFriday
                                          + totalSpendingOnSaturday
                                          + totalSpendingOnSunday) / 7;

            Console.WriteLine($"TOTAL AMOUNT SPENT ON MONDAY IS {totalSpendingOnMonday}");
            Console.WriteLine($"TOTAL AMOUNT SPENT ON TUESDAY IS {totalSpendingOnTuesday}");
            Console.WriteLine($"TOTAL AMOUNT SPENT ON WEDNESDAY IS {totalSpendingOnWednesday}");
            Console.WriteLine($"TOTAL AMOUNT SPENT ON THURSDAY IS {totalSpendingOnThursday}");
            Console.WriteLine($"TOTAL AMOUNT SPENT ON FRIDAY IS {totalSpendingOnFriday}");
            Console.WriteLine($"TOTAL AMOUNT SPENT ON SATURDAY IS {totalSpendingOnSaturday}");
            Console.WriteLine($"TOTAL AMOUNT SPENT ON SUNDAY IS {totalSpendingOnSunday}");
            Console.WriteLine($"AVERAGE DAILY SPENDING IS {dailyAverageSpending}");
            */
        }

        public static string GetNameOfExpense(int expenseNumber)
        {
            string expenseName;

            switch (expenseNumber)
            {
                case 1:
                    {
                        expenseName = "NUTRITION";
                    }
                    break;
                case 2:
                    {
                        expenseName = "TRANSPORT";
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
                default:
                    {
                        expenseName = "OTHERS";
                    }
                    break;
            }
            return expenseName;
        }
        public static double TotalSpendingPerWeek(int[][,] expense)
        {
            double total = 0;

            for (int x = 0; x < 6; x++)
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        total += expense[x][i, j];
                    }
                }
            }
            return total;
        }
        /*
        public static void Print(int[,] expenseArray, string expenseName)
        {
            Console.WriteLine($"{ expenseName}");
            Console.WriteLine("                Expense 1  Expense 2  Expense 3  Expense 4  Expense 5  Expense 6  Expense 7  Expense 8  Expense 9  Expense 10");
            string[] weekDayNames = new string[7] { "Monday      ", "Tuesday     ", "Wednesday   ", "Thursday    ", "Friday      ", "Saturday    ", "Sunday      " };
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"  {weekDayNames[i]}");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"    {expenseArray[i, j]}      ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }
        */
        /*
        
        */
        /*
        public static double TotalExpenseOnDay(int dayNumber, int[,] expenseDay)
        {
            double totalSpendingOnDay = 0;
            for(int i = 0; i < 10;i++)
            {
                totalSpendingOnDay += expenseDay[dayNumber, i];
            }
            return totalSpendingOnDay;
        }
        */
        /*
       public static double TotalAmountOfExpense(int[,] expense )
       {
           int totalAmount = 0;
           for (int i = 0; i < 7; i++  )
           {
               for(int j = 0; j < 10; j++)
               {
                   totalAmount += expense[i, j]; 
               }
           }
           return totalAmount;
       }
       */
        ///////////////////////////////
        
        public static void maxSpentAmountPerExpense(double[] maxArray)
        {
            double max = 0;
            int index = 0;
            string nameOfExpense = "";
            for (int i = 0; i < maxArray.Length; i++)
            {
                if (max < maxArray[i])
                {
                    max = maxArray[i];
                    index = i;
                }
            }
            switch (index)
            {
                case 0:
                    { 
                        nameOfExpense = "NUTRITION"; 
                    }break;
                case 1:
                    {
                        nameOfExpense = "TRANSPORT";
                    }
                    break;
                case 2:
                    {
                        nameOfExpense = "EDUCATION";
                    }
                    break;
                case 3:
                    {
                        nameOfExpense = "COMMUNICATION";
                    }
                    break;
                case 4:
                    {
                        nameOfExpense = "UTILITIES";
                    }
                    break;
                case 5:
                    {
                        nameOfExpense = "OTHERS";
                    }
                    break;
            }

            Console.WriteLine($"THE HIGHEST AMOUNT IS SPENT FOR {nameOfExpense} EXPENSE AND TOTAL EXPENSE FOR {nameOfExpense} IN A WEEK IS {max}");
        }

        public static void minSpentAmountPerExpense(double[] minArray)
        {
            double min = 0;
            int index = 0;
            string nameOfExpense = "";
            for (int i = 0; i < minArray.Length; i++)
            {
                if (min > minArray[i])
                {
                    min = minArray[i];
                    index = i;
                }
            }
            switch (index)
            {
                case 0:
                    {
                        nameOfExpense = "NUTRITION";
                    }
                    break;
                case 1:
                    {
                        nameOfExpense = "TRANSPORT";
                    }
                    break;
                case 2:
                    {
                        nameOfExpense = "EDUCATION";
                    }
                    break;
                case 3:
                    {
                        nameOfExpense = "COMMUNICATION";
                    }
                    break;
                case 4:
                    {
                        nameOfExpense = "UTILITIES";
                    }
                    break;
                case 5:
                    {
                        nameOfExpense = "OTHERS";
                    }
                    break;
            }

            Console.WriteLine($"THE LOWEST AMOUNT IS SPENT FOR {nameOfExpense} EXPENSE AND TOTAL EXPENSE FOR {nameOfExpense} IN A WEEK IS {min}");
        }

    }
}
