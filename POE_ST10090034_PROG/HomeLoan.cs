using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_ST10090034_PROG
{
    internal class HomeLoan : Expense
    {
        List<double> Property = new List<double>();
        List<double> Expenses = new List<double>();
        List<double> ExpenseTotal = new List<double>();

        public double grossIncome { get; set; }
        public double taxBracket { get; set; }
        public double groceryExpenditure { get; set; }
        public double waterElecExpenditure { get; set; }
        public double travelExpenditure { get; set; }
        public double phoneExpenditure { get; set; }
        public double miscExpenditure { get; set; }

        public HomeLoan(double grossIncome, double taxBracket, double groceryExpenditure, double waterElecExpenditure, double travelExpenditure, double phoneExpenditure, double miscExpenditure) : base(grossIncome, taxBracket, groceryExpenditure, waterElecExpenditure, travelExpenditure, phoneExpenditure, miscExpenditure)
        {
            this.grossIncome = grossIncome;
            this.taxBracket = taxBracket;
            this.groceryExpenditure = groceryExpenditure;
            this.waterElecExpenditure = waterElecExpenditure;
            this.travelExpenditure = travelExpenditure;
            this.phoneExpenditure = phoneExpenditure;
            this.miscExpenditure = miscExpenditure;
            //Expenses.Add(grossIncome);
            Expenses.Add(taxBracket);
            Expenses.Add(groceryExpenditure);
            Expenses.Add(waterElecExpenditure);
            Expenses.Add(travelExpenditure);
            Expenses.Add(phoneExpenditure);
            Expenses.Add(miscExpenditure);
        }

        public override void PrintExpenses()
        {
            Console.WriteLine("The sum of all expenses is: " + Expenses.Sum() +
                "========================================\n");
        }

        public delegate void TotalExxpense(string message);
        public override void PrintHomeLoan()
        {
            Console.WriteLine("========================================\n" +
                "******      PROPERTY PLANNER      ******\n" +
                "========================================\n");

            Console.WriteLine("Please enter the purchase price of the property: ");
            double purchasePrice = Convert.ToDouble(Console.ReadLine());
            Property.Add(purchasePrice);

            Console.WriteLine("Please enter the total deposit: ");
            double totalDeposit = Convert.ToDouble(Console.ReadLine());
            Property.Add(totalDeposit);

            Console.WriteLine("Now enter the interest rate: ");
            double interestRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Now enter the number of months to repay (Between 240 & 360): ");
            int monthsToRepay = Convert.ToInt32(Console.ReadLine());
            Property.Add(monthsToRepay);

            Console.WriteLine("========================================\n" +
            "Purchase Price: " + purchasePrice + "\n" +
            "Total Deposit: " + totalDeposit + "\n" +
            "Interest Rate: " + interestRate + "\n" +
            "Months to Repay: " + monthsToRepay + "\n" +
            "========================================\n");

            double deposit = (totalDeposit / 100.0) * purchasePrice;
            double depositCalc = purchasePrice - deposit;
            double interest = interestRate / 100.0;
            double months = monthsToRepay / 12;
            double simpInterest = depositCalc * (1 + interest * months);
            double monthlyRepayment = simpInterest / monthsToRepay;

            //Console.WriteLine("Monthly repayment is : {0}", monthlyRepayment);
            Console.WriteLine($"Monthly repayment is : R {monthlyRepayment}\n" +
                "========================================");
            ExpenseTotal.Add(monthlyRepayment);
            //return totalDeposit;

            double approval = (1.0 / 3.0) * grossIncome;


            if (monthlyRepayment > approval)
            {
                Console.WriteLine($"Not qualified for home loan.\n" +
                "========================================");
            }
            else
            {
                Console.WriteLine($"Qualified for home loan.\n" +
                "========================================");
            }

            double deduction = grossIncome - taxBracket - groceryExpenditure - waterElecExpenditure - travelExpenditure - phoneExpenditure - miscExpenditure - monthlyRepayment;
            Console.WriteLine($"Amount after deduction: R {deduction}\n" +
               "========================================");
        }
        
        public void ImplementExpense(string message)
        {
            double TotalExpense = 60000;
            if (TotalExpense > ((75.0 / 100.0) * grossIncome))
            {
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("You did not exceed 75% of your Income\n" +
                "=========================================================================================================");
            }
        }
        public override void PrintCarLoan()
        {

        }
        public override void TotalExpense()
        {
            throw new NotImplementedException();
        }
    }
}
