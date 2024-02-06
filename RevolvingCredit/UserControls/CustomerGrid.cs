using Microsoft.Extensions.Caching.Memory;
using RevolvingCredit.Data;
using RevolvingCredit.Data.DataFiltering;
using RevolvingCredit.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevolvingCredit.UserControls
{
    public partial class CustomerGrid : UserControl
    {
        public event EventHandler<ContractEventArgs> SelectRowContractId;
        private const string CustomerListKey = "CUSTOMERLIST";
        private MemoryCache _memCache;
        public CustomerGrid()
        {
            InitializeComponent();
            _memCache = new MemoryCache(new MemoryCacheOptions());
            gridCustomers.SelectionChanged += gridCustomers_SelectionChanged;
        }

        private void gridCustomers_SelectionChanged(object sender, EventArgs e)
        {
            var selected = gridCustomers.SelectedRows?[0];
            if (selected != null)
            {
                ContractEventArgs newEvent = new ContractEventArgs();
                newEvent.ContractId = ((RevolvingCredit.Data.Customer)selected.DataBoundItem).ContractId;
                SelectEventRaiser(newEvent);
            }
        }

        private void SelectEventRaiser(ContractEventArgs e)
        {
            if (SelectRowContractId != null)
                SelectRowContractId(this, e);
        }

        private void CustomerGrid_Load(object sender, EventArgs e)
        {
            this.gridCustomers.Columns["name"].Width = 200;
            this.gridCustomers.Columns["business"].Width = 230;
            this.gridCustomers.Columns["address"].Width = 240;
            this.gridCustomers.Columns["city"].Width = 140;
            this.gridCustomers.Columns["phone"].Width = 140;
            this.gridCustomers.Columns["title"].Width = 210;

            ReloadGrid();
        }

        public void FilterData(List<DbFilter> filters)
        {
            this.gridCustomers.DataSource = RawData.FilteredCustomerList(filters);
        }

        public void ResetFilters()
        {
            ReloadGrid();
        }

        private void ReloadGrid()
        {
            var custList = new List<Customer>();
            var listFromMemory = _memCache.Get(CustomerListKey);
            if (listFromMemory == null)
            {
                custList = RawData.FilteredCustomerList();
                _memCache.Set("CUSTOMERLIST", custList);
                this.gridCustomers.DataSource = custList;
            }
            else
            {
                custList = (List<Customer>)listFromMemory;
                this.gridCustomers.DataSource = custList;
            }
            if (custList?.Any() == true)
            {
                ContractEventArgs newEvent = new ContractEventArgs();
                newEvent.ContractId = custList.FirstOrDefault().ContractId;
                SelectEventRaiser(newEvent);
            }
        }
    }

    public class ContractEventArgs : EventArgs
    {
        private int contractId;

        public int ContractId
        {
            get
            {
                return contractId;
            }
            set
            {
                contractId = value;
            }
        }
    }
}
