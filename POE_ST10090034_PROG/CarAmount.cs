using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_ST10090034_PROG
{
    internal class CarAmount : Expense
    {
        List<int> Property = new List<int>();
        List<double> Expenses = new List<double>();
        List<double> Car = new List<double>();
        List<double> ExpenseTotal = new List<double>();

        public CarAmount(double grossIncome, double taxBracket, double groceryExpenditure, double waterElecExpenditure, double travelExpenditure, double phoneExpenditure, double miscExpenditure) : base(grossIncome, taxBracket, groceryExpenditure, waterElecExpenditure, travelExpenditure, phoneExpenditure, miscExpenditure)
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
        }
        public override void PrintHomeLoan()
        {
            throw new NotImplementedException();
        }

        
        public override void PrintCarLoan()
        {
            Console.WriteLine("========================================\n" +
                "******      CAR PLANNER      ******\n" +
                "========================================\n");

            Console.WriteLine("Please enter the model of the vehicle: ");
            string model = Console.ReadLine();

            Console.WriteLine("Please enter the make of the vehicle: ");
            string make = Console.ReadLine();

            Console.WriteLine("Please enter the purchase price of the vehicle: ");
            double CarpurchasePrice = Convert.ToDouble(Console.ReadLine());
            Car.Add(CarpurchasePrice);

            Console.WriteLine("Please enter the total deposit for the vehicle: ");
            double CartotalDeposit = Convert.ToDouble(Console.ReadLine());
            Car.Add(CartotalDeposit);

            Console.WriteLine("Now enter the interest rate of the vehicle: ");
            double CarInterestRate = Convert.ToDouble(Console.ReadLine());
            Car.Add(CarInterestRate);

            Console.WriteLine("Please enter the estimated insurance premium: ");
            double insurance = Convert.ToDouble(Console.ReadLine());
            Car.Add(insurance);

            Console.WriteLine("========================================\n" +
            "Car Model: " + model + "\n" +
            "Car Make: " + make + "\n" +
            "Price of the vehicle: " + CarpurchasePrice + "\n" +
            "Deposit: " + CartotalDeposit + "\n" +
            "Interest: " + CarInterestRate + "\n" +
            "Insurance: " + insurance + "\n" +
            "========================================\n");

            double CarDeposit = (CartotalDeposit / 100.0) * CarpurchasePrice;
            double CarDepositCalc = CarpurchasePrice - CarDeposit;
            double Carinterest = CarInterestRate / 100.0;
            double months = 5 / 12;
            double simpInterest = CarDepositCalc * (1 + Carinterest * months);
            double CarMonthlyRepayment = simpInterest / 5;
            double CarInsurance = CarMonthlyRepayment + insurance;

            Console.WriteLine($"The Car Monthly repayment is : R {CarInsurance}\n" +
            "========================================");
            Expenses.Add(CarInsurance);

            //double approval = (1 / 3) * CarMonthlyRepayment;      

           
        }
        public override void TotalExpense()
        {
            Expenses = Expenses.OrderBy(x => -x).ToList();
            Console.WriteLine("Your expenses in descending order: " + "R " + String.Join(", R ", Expenses) + "\n" +
                "=========================================================================================================");

        }

    }
}
