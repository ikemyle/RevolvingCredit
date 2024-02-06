using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvingCredit.Data
{
    public class Mortgage
    {
        #region Inputs
        public double Loan
        {
            get;
            set;
        }

        public double MonthlyInterest
        {
            get;
            set;
        }
        public double AnualInterest
        {
            get;
            set;
        }

        private double _anualInterestPerc = 0;
        public double AnualInterestPerc
        {
            get
            {
                return _anualInterestPerc;
            }
            set
            {
                _anualInterestPerc = value;
                AnualInterest = value / 100;
                MonthlyInterest = value / 1200;
            }
        }


        public int Term
        {
            get;
            set;
        }

        public double DownPayment
        {
            get;
            set;
        }
        #endregion

        #region Calculation
        private double _monthlyPayment = 0;
        public string MonthlyPayment
        {
            get
            {
                return string.Format("{0:C2}", Math.Round(_monthlyPayment, 2));
            }
            set
            {
                double.TryParse(value, out _monthlyPayment);
            }
        }
        public double CalculatePayment()
        {
            double nInd = (Math.Pow((1 + AnualInterest / 12), Term) - 1) * 12 / AnualInterest;
            _monthlyPayment = (Loan / nInd) + Loan * MonthlyInterest;
            //_monthlyPayment = Math.Round(nMonthly, 2);
            return _monthlyPayment;
        }

        private PrincipalVsInterest _totalSummary = new PrincipalVsInterest();
        public PrincipalVsInterest TotalSummary
        {
            get
            {
                return _totalSummary;
            }
        }

        private List<PrincipalVsInterest> _amortization = new List<PrincipalVsInterest>();
        public List<PrincipalVsInterest> Amortization
        {
            get
            {
                return _amortization;
            }
        }
        public void AddAmortization(double principal, int year)
        {
            PrincipalVsInterest pvi = new PrincipalVsInterest();
            pvi.Principal = principal;
            pvi.Year = year;
            pvi.Interest = _monthlyPayment - principal;
            pvi.InterestToDate = pvi.Interest;
            pvi.PrincipalToDate = principal;
            pvi.TotalLoan = Loan;
            for (int i = 0; i < _amortization.Count; i++)
            {
                pvi.InterestToDate += _amortization[i].Interest;
                pvi.PrincipalToDate += _amortization[i].Principal;
            }
            pvi.MonthNumber = (_amortization.Count + 1).ToString();
            _amortization.Add(pvi);
            _totalSummary.Interest += pvi.Interest;

            if (pvi.MonthNumber == Term.ToString())
            {
                _totalSummary.Principal = Loan;
                _totalSummary.MonthNumber = "Total";
                //_amortization.Add(_totalSummary);
            }
        }
        #endregion
    }

    public class PrincipalVsInterest
    {
        private int _year = DateTime.Now.Year;
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
        public double TotalLoan
        {
            get;
            set;
        }

        public string MonthNumber
        {
            get;
            set;
        }
        public double Principal
        {
            get;
            set;
        }
        public double PrincipalToDate
        {
            get;
            set;
        }
        public double Interest
        {
            get;
            set;
        }
        public double InterestToDate
        {
            get;
            set;
        }
        public double Balance
        {
            get
            {
                double nBalance = TotalLoan - PrincipalToDate;
                return nBalance;
            }
        }
    }

}
