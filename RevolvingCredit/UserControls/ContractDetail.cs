using RevolvingCredit.Data;
using RevolvingCredit.Data.DataFiltering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevolvingCredit.UserControls
{
    public partial class ContractDetail : UserControl
    {
        public ContractDetail()
        {
            InitializeComponent();
        }

        public void LoadData(int contractId)
        {
            var contract = RawData.ContractListById(contractId);
            BindData(contract);
        }

        private void BindData(Contract contract)
        {
            if (contract == null)
            {
                MessageBox.Show("This client does not have a contract yet!");
                contract = new Contract();
                contract.Id = -1;
            }
            this.lblCIdVal.Text = contract.Id.ToString();
            this.lblAmountVal.Text = contract.Amount.ToString("C", CultureInfo.CurrentCulture);
            this.lblInterestVal.Text = $"{contract.Interest}%";
            this.lblBrokerVal.Text = contract.BrokerName;
            this.lblStartDateVal.Text = contract.StartDate.ToString("MMM dd yyyy");
            this.lblTermsVal.Text = $"{contract.YearsTerms} years";
            this.lblNotesVal.Text = contract.Notes;
            this.lblStateVal.Text = contract.State;
        }
    }
}
