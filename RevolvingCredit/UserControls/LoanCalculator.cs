using RevolvingCredit.Core;
using RevolvingCredit.Core.Extensions;
using RevolvingCredit.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls.UI;

namespace RevolvingCredit.UserControls
{
    public partial class LoanCalculator : UserControl
    {
        private Mortgage Payments = new Mortgage();
        private LoanOperation loanOperator = new LoanOperation();
        public LoanCalculator()
        {
            InitializeComponent();
            ShowCalculations(false);
        }

        private void btnCalculatePayment_Click(object sender, EventArgs e)
        {
            double loanAmount = 0;
            double interest = 0;
            int terms = 0;

            double.TryParse(txtLoan.Text.Replace("$", ""), out loanAmount);
            double.TryParse(txtInterest.Text.Replace("%", ""), out interest);
            int.TryParse(txtTerms.Text, out terms);

            Payments = loanOperator.CalculateMortgage(loanAmount, interest, 0, terms);
            this.lblPayment.Text = Payments.MonthlyPayment;
            gridAmortization.DataSource = Payments.Amortization;
            ShowCalculations(true);
            FillSummary();
            BuildChart();
        }

        private void BuildChart()
        {
            chartLoan.Series.Clear();
            chartLoan.Series.Add(GetSeries("Balance", "Balance", "MonthNumber"));
            chartLoan.Series.Add(GetSeries("Principal to Date", "PrincipalToDate", "MonthNumber"));
            chartLoan.Series.Add(GetSeries("Interest to Date", "InterestToDate", "MonthNumber"));
            chartLoan.ShowSmartLabels = false;
            chartLoan.ShowTrackBall = true;
            chartLoan.LegendTitle = "Loan Payment and Amortization";
            chartLoan.ShowLegend = true;
            chartLoan.Axes[0].LabelInterval = 15;
            WireEvents();
        }

        private void WireEvents()
        {
            ChartTrackballController trackBall;
            foreach (var c in this.chartLoan.Controllers)
            {
                trackBall = c as ChartTrackballController;
                if (trackBall != null)
                {
                    trackBall.TextNeeded += trackBall_TextNeeded;
                    break;
                }
            }
        }

        private void trackBall_TextNeeded(object sender, TextNeededEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataPointInfo p in e.Points)
            {
                var displayMember = p.Series.DisplayMember;
                var valMember = ((CartesianSeries)p.Series).ValueMember.ToString();
                CategoricalDataPoint cdp = p.DataPoint as CategoricalDataPoint;
                if (displayMember == "Balance")
                {
                     var month = DateTime.Now.AddMonths(((LoanChartPoint)cdp.DataItem).PointXValue).ToString("MMM yyyy");
                    sb.AppendLine(month);
                }

                if (cdp != null)
                {
                    var formatedVal = String.Format("{0:C2}", cdp.Value);
                    sb.AppendLine($"{displayMember}: {formatedVal}");
                }
            }
            e.Text = sb.ToString();
        }

        private AreaSeries GetSeries(string title, string valueMember, string categoryMember)
        {
            AreaSeries areaSeries = new AreaSeries();
            areaSeries.LegendTitle = title;
            areaSeries.ValueMember = "PointYValue";
            areaSeries.CategoryMember = "PointXValue";

            switch (valueMember)
            {
                case ("Balance"):
                    areaSeries.DataSource = Payments.Amortization.Select(d => new LoanChartPoint()
                    {
                        Year = d.Year,
                        PointXValue = d.MonthNumber.ToInt(),
                        PointYValue = d.Balance
                    }).ToList();
                    areaSeries.DisplayMember = "Balance";
                    break;
                case ("PrincipalToDate"):
                    areaSeries.DataSource = Payments.Amortization.Select(d => new LoanChartPoint()
                    {
                        Year = d.Year,
                        PointXValue = d.MonthNumber.ToInt(),
                        PointYValue = d.PrincipalToDate
                    }).ToList();
                    areaSeries.DisplayMember = "Principal To Date";
                    break;
                case ("InterestToDate"):
                    areaSeries.DataSource = Payments.Amortization.Select(d => new LoanChartPoint()
                    {
                        Year = d.Year,
                        PointXValue = d.MonthNumber.ToInt(),
                        PointYValue = d.InterestToDate
                    }).ToList();
                    areaSeries.DisplayMember = "Interest To Date";
                    break;
            }
            return areaSeries;
        }
        
        private void loan_ValueChanged(object sender, EventArgs e)
        {
            ShowCalculations(false);
        }

        private void ShowCalculations(bool visibilityFlag)
        {
            this.tabSummary.Visible = visibilityFlag;
            this.pnPayment.Visible = visibilityFlag;
        }

        private void FillSummary()
        {
            this.lblAmountVal.Text = String.Format("{0:C2}", Payments.Loan);
            this.lblTermsVal.Text = (Payments.Term / 12).ToString();
            this.lblInterestVal.Text = $"{Payments.AnualInterestPerc}%";
            this.lblPaidInterestVal.Text = String.Format("{0:C2}", Payments.TotalSummary.Interest);
            this.lblNumberPayments.Text = Payments.Term.ToString();
        }
    }
}
