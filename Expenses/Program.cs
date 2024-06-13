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
                int counter = 0;
                int numberOfDay = i+1;
                
                Console.WriteLine($"IS THERE ANY EXPENSE ON DAY {numberOfDay}? (y - yes / n - no)");
                response = Console.ReadLine(); 
                if(response == "y")
                {
                    int j = 0;
                    int a = 0;
                    int b = 0;
                    int c = 0;
                    int d = 0;
                    int e = 0;
                    int f = 0;

                    string expenseResponseForDay = "y";
                    while (counter < 70 && expenseResponseForDay == "y")
                    {
                        string expenseResponseForExpenseType = "y";
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
                                    while (a < 10 && expenseResponseForExpenseType == "y")
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        nutrition[i, a] = int.Parse(Console.ReadLine());
                                        totalSpendingForNutrition = totalSpendingForNutrition + nutrition[i, a];
                                        
                                        Console.WriteLine($"IS THERE OTHER EXPENSE ON DAY {numberOfDay} FOR {GetNameOfExpense(typeOfExpense)}? (y - yes / n - no)");
                                        expenseResponseForExpenseType = Console.ReadLine();
                                        totalExpensePerDay[i] = nutrition[i, a] + transport[i, a] + education[i, a]
                                                + communication[i, a] + utilities[i, a] + others[i, a];
                                        if (expenseResponseForExpenseType == "n")
                                        {
                                            Console.WriteLine($"IS THERE OTHER EXPENSE ON DAY {numberOfDay}? (y - yes / n - no)");
                                            expenseResponseForDay = Console.ReadLine();
                                        }
                                        a++;
                                        counter++;
                                    }
                                }
                                break;

                            case 2:
                                {
                                    while (b < 10 && expenseResponseForExpenseType == "y")
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        transport[i, b] = int.Parse(Console.ReadLine());
                                        totalSpendingForTransport = totalSpendingForTransport + transport[i, b];
                                        Console.WriteLine($"IS THERE OTHER EXPENSE ON DAY {numberOfDay} FOR {GetNameOfExpense(typeOfExpense)}? (y - yes / n - no)");
                                        expenseResponseForExpenseType = Console.ReadLine();
                                        totalExpensePerDay[i] = nutrition[i, b] + transport[i, b] + education[i, b]
                                                + communication[i, b] + utilities[i, b] + others[i, b];
                                        if (expenseResponseForExpenseType == "n")
                                        {
                                            Console.WriteLine($"IS THERE OTHER EXPENSE ON DAY {numberOfDay}? (y - yes / n - no)");
                                            expenseResponseForDay = Console.ReadLine();
                                        }
                                        b++;
                                        counter++;

                                    }

                                }
                                break;


                            case 3:
                                {
                                    while (c < 10 && expenseResponseForExpenseType == "y")
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        education[i, c] = int.Parse(Console.ReadLine());
                                        totalSpendingForEducation = totalSpendingForEducation + education[i, c];
                                        Console.WriteLine($"IS THERE OTHER EXPENSE ON DAY {numberOfDay} FOR {GetNameOfExpense(typeOfExpense)}? (y - yes / n - no)");
                                        expenseResponseForExpenseType = Console.ReadLine();
                                        totalExpensePerDay[i] = nutrition[i, c] + transport[i, c] + education[i, c]
                                                + communication[i, c] + utilities[i, c] + others[i, c];
                                        if (expenseResponseForExpenseType == "n")
                                        {
                                            Console.WriteLine($"IS THERE OTHER EXPENSE ON DAY {numberOfDay}? (y - yes / n - no)");
                                            expenseResponseForDay = Console.ReadLine();
                                        }
                                        c++;
                                        counter++;

                                    }
                                }
                                break;

                            case 4:
                                {
                                    while (d < 10 && expenseResponseForExpenseType == "y")
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        communication[i, d] = int.Parse(Console.ReadLine());
                                        totalSpendingForCommunication = totalSpendingForCommunication + communication[i, d];
                                        Console.WriteLine($"IS THERE OTHER EXPENSE ON DAY {numberOfDay} FOR {GetNameOfExpense(typeOfExpense)}? (y - yes / n - no)");
                                        expenseResponseForExpenseType = Console.ReadLine();
                                        totalExpensePerDay[i] = nutrition[i, d] + transport[i, d] + education[i, d]
                                                + communication[i, d] + utilities[i, d] + others[i, d];
                                        if (expenseResponseForExpenseType == "n")
                                        {
                                            Console.WriteLine($"IS THERE OTHER EXPENSE ON DAY {numberOfDay}? (y - yes / n - no)");
                                            expenseResponseForDay = Console.ReadLine();
                                        }
                                        d++;
                                        counter++;

                                    }

                                }
                                break;
                            case 5:
                                {
                                    while (e < 10 && expenseResponseForExpenseType == "y")
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        utilities[i, e] = int.Parse(Console.ReadLine());
                                        totalSpendingForUtilities = totalSpendingForUtilities + utilities[i, e];
                                        Console.WriteLine($"IS THERE OTHER EXPENSE ON DAY {numberOfDay} FOR {GetNameOfExpense(typeOfExpense)}? (y - yes / n - no)");
                                        expenseResponseForExpenseType = Console.ReadLine();
                                        totalExpensePerDay[i] = nutrition[i, e] + transport[i, e] + education[i, e]
                                                + communication[i, e] + utilities[i, e] + others[i, e];
                                        if (expenseResponseForExpenseType == "n")
                                        {
                                            Console.WriteLine($"IS THERE OTHER EXPENSE ON DAY {numberOfDay}? (y - yes / n - no)");
                                            expenseResponseForDay = Console.ReadLine();
                                        }
                                        e++;
                                        counter++;

                                    }
                                }
                                break;
                            case 6:
                                {
                                    while (f < 10 && expenseResponseForExpenseType == "y")
                                    {
                                        Console.WriteLine($"ENTER THE AMOUNT SPEND FOR {GetNameOfExpense(typeOfExpense)} ON DAY {numberOfDay}");
                                        others[i, f] = int.Parse(Console.ReadLine());
                                        totalSpendingForOthers = totalSpendingForOthers + others[i, f];
                                        Console.WriteLine($"IS THERE OTHER EXPENSE ON DAY {numberOfDay} FOR {GetNameOfExpense(typeOfExpense)}? (y - yes / n - no)");
                                        expenseResponseForExpenseType = Console.ReadLine();
                                        totalExpensePerDay[i] = nutrition[i, f] + transport[i, f] + education[i, f]
                                                + communication[i, f] + utilities[i, f] + others[i, f];
                                        if (expenseResponseForExpenseType == "n")
                                        {
                                            Console.WriteLine($"IS THERE OTHER EXPENSE ON DAY {numberOfDay}? (y - yes / n - no)");
                                            expenseResponseForDay = Console.ReadLine();
                                        }
                                        f++;
                                        counter++;

                                    }
                                }
                                break;


                        }
                    }    
                       
                        
                        j++;
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
            averageDailySpending = totalWeeklySpending/WEEK_DAYS;
            Console.WriteLine($"THE AVERAGE DAILY SPENDING IS {averageDailySpending}");
            //////////////////// Ən çox hansı gün xərc edilib və miqdarı///////////////
            double totalExpenseOnMonday = TotalSpendingOnMonday(nutrition) + TotalSpendingOnMonday(transport) + TotalSpendingOnMonday(education) + TotalSpendingOnMonday(communication) + TotalSpendingOnMonday(utilities)
                              + TotalSpendingOnMonday(others);
            double totalExpenseOnTuesday = TotalSpendingOnTuesday(nutrition) + TotalSpendingOnTuesday(transport) + TotalSpendingOnTuesday(education) + TotalSpendingOnTuesday(communication) + TotalSpendingOnTuesday(utilities)
                                        + TotalSpendingOnTuesday(others);
            double totalExpenseOnWednesday = TotalSpendingOnWednesday(nutrition) + TotalSpendingOnWednesday(transport) + TotalSpendingOnWednesday(education) + TotalSpendingOnWednesday(communication) + TotalSpendingOnWednesday(utilities)
                                        + TotalSpendingOnWednesday(others);
            double totalExpenseOnThursday = TotalSpendingOnThursday(nutrition) + TotalSpendingOnThursday(transport) + TotalSpendingOnThursday(education) + TotalSpendingOnThursday(communication) + TotalSpendingOnThursday(utilities)
                                        + TotalSpendingOnThursday(others);
            double totalExpenseOnFriday = TotalSpendingOnFriday(nutrition) + TotalSpendingOnFriday(transport) + TotalSpendingOnFriday(education) + TotalSpendingOnFriday(communication) + TotalSpendingOnFriday(utilities)
                                        + TotalSpendingOnFriday(others);
            double totalExpenseOnSaturday = TotalSpendingOnSaturday(nutrition) + TotalSpendingOnSaturday(transport) + TotalSpendingOnSaturday(education) + TotalSpendingOnSaturday(communication) + TotalSpendingOnSaturday(utilities)
                                        + TotalSpendingOnSaturday(others);
            double totalExpenseOnSunday = TotalSpendingOnSunday(nutrition) + TotalSpendingOnSunday(transport) + TotalSpendingOnSunday(education) + TotalSpendingOnSunday(communication) + TotalSpendingOnSunday(utilities)
                                        + TotalSpendingOnSunday(others);
            double[] arrayOfDayExpenses = new double[7] { totalExpenseOnMonday, totalExpenseOnTuesday, totalExpenseOnWednesday, totalExpenseOnThursday, totalExpenseOnFriday, totalExpenseOnSaturday, totalExpenseOnSunday };
            maxSpentAmountPerDay(arrayOfDayExpenses);
            //////////////////// Ən az hansı gün xərc edilib və miqdarı///////////////
            minSpentAmountPerDay(totalExpensePerDay);

            /////////////// total expense on Monday //////////////////



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
        /// <summary>
        /// calculating total amount per day methods
        /// </summary>
        /// <param name="arrayOfExpenses"></param>
        /// <returns></returns>
        public static double TotalSpendingOnMonday(int[,] arrayOfExpenses)
        {
            double total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += arrayOfExpenses[0, i];
            }
            return total;
        }
        public static double TotalSpendingOnTuesday(int[,] arrayOfExpenses)
        {
            double total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += arrayOfExpenses[1, i];
            }
            return total;
        }
        public static double TotalSpendingOnWednesday(int[,] arrayOfExpenses)
        {
            double total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += arrayOfExpenses[2, i];
            }
            return total;
        }
        public static double TotalSpendingOnThursday(int[,] arrayOfExpenses)
        {
            double total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += arrayOfExpenses[3, i];
            }
            return total;
        }
        public static double TotalSpendingOnFriday(int[,] arrayOfExpenses)
        {
            double total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += arrayOfExpenses[4, i];
            }
            return total;
        }
        public static double TotalSpendingOnSaturday(int[,] arrayOfExpenses)
        {
            double total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += arrayOfExpenses[5, i];
            }
            return total;
        }
        public static double TotalSpendingOnSunday(int[,] arrayOfExpenses)
        {
            double total = 0;
            for (int i = 0; i < 10; i++)
            {
                total += arrayOfExpenses[6, i];
            }
            return total;
        }
    }
}