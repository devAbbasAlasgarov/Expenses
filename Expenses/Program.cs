using System.Runtime.CompilerServices;

namespace Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string response;
            int WEEK_DAYS = 7;
            int typeOfExpense;
            double totalSpendingForNutrition = 0;
            double totalSpendingForTransport = 0;
            double totalSpendingForEducation = 0;
            double totalSpendingForCommunication = 0;
            double totalSpendingForUtilities = 0;
            double totalSpendingForOthers = 0;
            double[] totalExpensePerDay = new double[7];
            int[,] nutrition = new int[7, 10];
            int[,] transport = new int[7, 10];
            int[,] education = new int[7, 10];
            int[,] communication = new int[7, 10];
            int[,] utilities = new int[7, 10];
            int[,] others = new int[7, 10];

            for (int i = 0; i < WEEK_DAYS; i++)
            {
                int numberOfDay = i+1;
                
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
                                        nutrition[i, j] = int.Parse(Console.ReadLine());
                                        totalSpendingForNutrition = totalSpendingForNutrition + nutrition[i, j];    
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        transport[i, j] = int.Parse(Console.ReadLine());
                                        totalSpendingForTransport = totalSpendingForTransport + transport[i, j];
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        education[i, j] = int.Parse(Console.ReadLine());
                                        totalSpendingForEducation = totalSpendingForEducation + education[i, j];
                                    }
                                    break;
                                case 4:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        communication[i, j] = int.Parse(Console.ReadLine());
                                        totalSpendingForCommunication = totalSpendingForCommunication + communication[i, j];
                                    }
                                    break;
                                case 5:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        utilities[i, j] = int.Parse(Console.ReadLine());
                                        totalSpendingForUtilities = totalSpendingForUtilities + utilities[i, j];
                                    }
                                    break;
                                case 6:
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        others[i, j] = int.Parse(Console.ReadLine());
                                        totalSpendingForOthers = totalSpendingForOthers + others[i, j];
                                    }
                                    break;
                            }
                        
                        Console.WriteLine($"IS THERE OTHER EXPENSE ON DAY {numberOfDay}? (y - yes / n - no)");
                        expenseResponseForTheDay = Console.ReadLine();
                        totalExpensePerDay[j] = nutrition[i, j] + transport[i, j] + education[i, j]
                                                + communication[i, j] + utilities[i, j] + others[i, j];
                        j++;
                    }
                }
                else if(response == "n")
                {
                    Console.WriteLine($"THERE IS NO ANY EXPENSE ON DAY {numberOfDay}.");
                }
            }
            //////////////////  Həftə ərzində toplam xərc  ///////////////////////////////////
            double totalWeeklySpending = 0;
            int[][,] allExpenses = new int[6][,] { nutrition, transport, education, communication, utilities, others };
            totalWeeklySpending = TotalSpendingPerWeek(allExpenses);
            Console.WriteLine($"TOTAL WEEKLY SPENDING IS {totalWeeklySpending}");
            //////////////////  Ən çox hansı növ üçün xərc çəkilib və miqdarı////////////////
            double[] ArrayOfSpendingPerExpense = new double[] { totalSpendingForNutrition,
                                                                totalSpendingForTransport,
                                                                totalSpendingForEducation,
                                                                totalSpendingForCommunication,
                                                                totalSpendingForUtilities,
                                                                totalSpendingForOthers };
            maxSpentAmountPerExpense(ArrayOfSpendingPerExpense);
            //////////////////// Ən az hansı növ üçün xərc çəkilib və miqdarı///////////////
            minSpentAmountPerExpense(ArrayOfSpendingPerExpense);
            ////////////////////  Günlük ortalama xərc nə qədərdir///////////////
            double averageDailySpending = 0;
            for(int i = 0; i < WEEK_DAYS; i++)
            {
                averageDailySpending = averageDailySpending + totalExpensePerDay[i];
            }
            Console.WriteLine($"THE AVERAGE DAILY SPENDING IS {averageDailySpending/7}");
            //////////////////// Ən çox hansı gün xərc edilib və miqdarı///////////////
            maxSpentAmountPerDay(totalExpensePerDay);
            //////////////////// Ən az hansı gün xərc edilib və miqdarı///////////////
            minSpentAmountPerDay(totalExpensePerDay);
            
            Print(nutrition, "Nutrition : ");
            Print(transport, "Transport : ");
            Print(education, "Education : ");
            Print(communication, "Communication: ");
            Print(utilities, "Utilities: ");
            Print(others, " Others: ");
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
                //for (int i = 0; i < 7; i++)
                //{
                //    for (int j = 0; j < 10; j++)
                //    {
                //        total += expense[x][i, j];
                //    }
                //}
                total += TotalSpendingPerExpenseType(expense[x]);
            }
            return total;
        }
        public static double TotalSpendingPerExpenseType(int[,] expense)
        { 
            double total = 0;

            for(int i = 0; i < 7; i++)
            {
                for(int j = 0;j < 10; j++)
                {
                    total += expense[i, j];
                }
            }
            return total;
        }
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
                else
                {
                    index = i - 1;
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
        public static void maxSpentAmountPerDay(double[] maxArray)
        {
            double max = 0;
            int index = 0;
            string dayOfWeek = "";
            for (int i = 0; i < 7; i++)
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
                        dayOfWeek = "MONDAY";
                    }
                    break;
                case 1:
                    {
                        dayOfWeek = "TUESDAY";
                    }
                    break;
                case 2:
                    {
                        dayOfWeek = "WEDNESDAY";
                    }
                    break;
                case 3:
                    {
                        dayOfWeek = "THURSDAY";
                    }
                    break;
                case 4:
                    {
                        dayOfWeek = "FRIDAY";
                    }
                    break;
                case 5:
                    {
                        dayOfWeek = "SATURDAY";
                    }
                    break;
                case 6:
                    {
                        dayOfWeek = "SUNDAY";
                    }
                    break;
            }

            Console.WriteLine($"THE HIGHEST AMOUNT IS SPENT ON {dayOfWeek} IN A WEEK IS {max}");
        }
        public static void minSpentAmountPerDay(double[] minArray)
        {
            double min = 0;
            int index = 0;
            string dayOfWeek = "";
            for (int i = 0; i < 7; i++)
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
                        dayOfWeek = "MONDAY";
                    }
                    break;
                case 1:
                    {
                        dayOfWeek = "TUESDAY";
                    }
                    break;
                case 2:
                    {
                        dayOfWeek = "WEDNESDAY";
                    }
                    break;
                case 3:
                    {
                        dayOfWeek = "THURSDAY";
                    }
                    break;
                case 4:
                    {
                        dayOfWeek = "FRIDAY";
                    }
                    break;
                case 5:
                    {
                        dayOfWeek = "SATURDAY";
                    }
                    break;
                case 6:
                    {
                        dayOfWeek = "SUNDAY";
                    }
                    break;
            }

            Console.WriteLine($"THE LEAST AMOUNT IS SPENT ON {dayOfWeek} IN A WEEK IS {min}");
        }
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
    }
}