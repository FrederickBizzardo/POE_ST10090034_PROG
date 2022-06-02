using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_ST10090034_PROG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic List storing expenses and property prices.
            List<double> Expenses = new List<double>();
            List<int> Property = new List<int>();

            // Getting user input
            Console.WriteLine("=======================================\n" +
                "****** PERSONAL BUDGET PLANNER ******\n" +
                "=======================================\n");
            Console.WriteLine("Please enter your gross monthly income: ");
            // double grossIncome = Convert.ToDouble(Console.ReadLine());
            double grossIncome = Convert.ToDouble(Console.In.ReadLine());
            Expenses.Add(grossIncome);

            Console.WriteLine("Please enter your tax bracket: ");
            double taxBracket = Convert.ToDouble(Console.ReadLine());
            Expenses.Add(taxBracket);

            Console.WriteLine("Please enter your monthly grocery expenditure: ");
            double groceryExpenditure = Convert.ToDouble(Console.ReadLine());
            Expenses.Add(groceryExpenditure);

            Console.WriteLine("Please enter your monthly water and electricity expenditure: ");
            double waterElecExpenditure = Convert.ToDouble(Console.ReadLine());
            Expenses.Add(waterElecExpenditure);

            Console.WriteLine("Please enter your monthly travel costs (including petrol): ");
            double travelExpenditure = Convert.ToDouble(Console.ReadLine());
            Expenses.Add(travelExpenditure);

            Console.WriteLine("Please enter your monthly cellphone and telephone costs: ");
            double phoneExpenditure = Convert.ToDouble(Console.ReadLine());
            Expenses.Add(phoneExpenditure);

            Console.WriteLine("Please enter your monthly miscellaneous expenses costs: ");
            double miscExpenditure = Convert.ToDouble(Console.ReadLine());
            Expenses.Add(miscExpenditure);


            Console.WriteLine("\n\n");


            /*Console.WriteLine("================================\n" +
            "Enter (1) to rent a property: \n" +
            "Enter (2) to buy a property: \n" +
            "Enter (3) to buy a vehicle: \n" +
            "================================");

            int propertyChoice = Convert.ToInt32(Console.ReadLine());*/
            
            bool looping = true;

            // Loop if propertyChoice is not equal to 1, 2 or 3
            while (true)
            {
                Console.WriteLine("================================\n" +
                "Enter (1) to rent a property: \n" +
                "Enter (2) to buy a property: \n" +
                "Enter (3) to buy a vehicle: \n" +
                "================================");

                int propertyChoice = Convert.ToInt32(Console.ReadLine());

                //break;

                // Switch statement for propertyChoice
                switch (propertyChoice)
                {
                    case 1:
                        Console.WriteLine("Please enter the monthly rent: ");
                        double monthlyRent = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"You will be renting a property at the cost of: {monthlyRent}\n");

                        double deduction = grossIncome - taxBracket - groceryExpenditure - waterElecExpenditure - travelExpenditure - phoneExpenditure - miscExpenditure - monthlyRent;
                        Console.WriteLine($"Amount after deduction: R {deduction}\n" +
                           "========================================");
                        break;

                    case 2:
                        // Object for HomeLoan Class to get user input and print details
                        HomeLoan printHome = new HomeLoan(grossIncome, taxBracket, groceryExpenditure, waterElecExpenditure, travelExpenditure, phoneExpenditure, miscExpenditure);
                        printHome.PrintHomeLoan();


                        break;

                    case 3:
                        // Object for CarAmount Class to get user input and print details
                        CarAmount printCar = new CarAmount(grossIncome, taxBracket, groceryExpenditure, waterElecExpenditure, travelExpenditure, phoneExpenditure, miscExpenditure);
                        printCar.PrintCarLoan();
                        printCar.TotalExpense();

                        break;

                    default:
                        Console.WriteLine("Sorry, that option is not available. Please enter 1, 2 or 3");

                        if (looping)
                        {
                            continue;
                        }
                        break;
                }
                break;
            }

            Console.WriteLine("\n\n");

            HomeLoan printExpense = new HomeLoan(grossIncome, taxBracket, groceryExpenditure, waterElecExpenditure, travelExpenditure, phoneExpenditure, miscExpenditure);
            printExpense.PrintExpenses();

            // Object for delegate messsage
            HomeLoan obj = new HomeLoan(grossIncome, taxBracket, groceryExpenditure, waterElecExpenditure, travelExpenditure, phoneExpenditure, miscExpenditure);
            obj.ImplementExpense("Your total expense exceeds 75%\n" +
                "=========================================================================================================");


        }
    }
}
