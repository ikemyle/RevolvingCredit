using RevolvingCredit.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvingCredit.Core
{
    public class LoanOperation
    {
        public Mortgage CalculateMortgage(double Loan, double AnualInterestPerc, double DownPayment, int Term)
        {
            try
            {
                Mortgage calc = new Mortgage();
                double nMonthlyPrincipal = 0;
                if (Loan <= 0 || AnualInterestPerc <= 0 || Term <= 0)
                {
                    return calc;
                }
                calc.AnualInterestPerc = AnualInterestPerc;
                calc.DownPayment = DownPayment * Loan / 100;
                calc.Loan = Loan - calc.DownPayment;
                calc.Term = Term * 12;
                for (int i = 0; i < calc.Term; i++)
                {
                    var monthDate=DateTime.Now.AddMonths(i);
                    double nInd = 0;
                    nInd = Math.Pow((1 + calc.MonthlyInterest), i);
                    nMonthlyPrincipal = nInd * (calc.CalculatePayment() - calc.Loan * calc.MonthlyInterest);
                    calc.AddAmortization(nMonthlyPrincipal, monthDate.Year);
                }

                return calc;
            }
            catch
            {
                return null;
            }
        }
    }
}
