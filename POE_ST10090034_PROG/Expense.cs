using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_ST10090034_PROG
{
    abstract class Expense 
    {

        List<double> Expenses = new List<double>();
        List<double> ExpenseTotal = new List<double>();


        // These below are getters and setters.

        public double grossIncome { get; set; }
        public double taxBracket { get; set; }
        public double groceryExpenditure { get; set; }
        public double waterElecExpenditure { get; set; }
        public double travelExpenditure { get; set; }
        public double phoneExpenditure { get; set; }
        public double miscExpenditure { get; set; }

        public Expense(double grossIncome, double taxBracket, double groceryExpenditure, double waterElecExpenditure, double travelExpenditure, double phoneExpenditure, double miscExpenditure)
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

        abstract public void PrintExpenses();

        abstract public void PrintHomeLoan();
        abstract public void PrintCarLoan();
        abstract public void TotalExpense();
    }

}
