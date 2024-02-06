using ExpressionBuilder.Common;
using RevolvingCredit.Core;
using RevolvingCredit.Data;
using RevolvingCredit.Data.DataFiltering;
using RevolvingCredit.Helpers;
using System.ComponentModel;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;
using static RevolvingCredit.CustomControls.SearchTextBox;

namespace RevolvingCredit.UserControls
{
    public partial class DataFilterList : UserControl
    {
        public event EventHandler<DataFilterEventArgs> FilterData;

        public DataFilterList()
        {
            InitializeComponent();
        }

        private void DataFilterList_Load(object sender, EventArgs e)
        {
            InitListView();
            WireEvents();
        }

        public void LoadData(List<UiDataFilter> uiQuickFilters)
        {
            this.rvFilter.DataSource = uiQuickFilters;
            this.rvFilter.ExpandAll();
            foreach (ListViewDataItem item in this.rvFilter.Items)
            {
                item.CheckState = ToggleState.On;
            }
        }

        private void InitListView()
        {
            this.rvFilter.ShowGroups = true;
            this.rvFilter.EnableGrouping = true;
            this.rvFilter.ShowGroups = true;
            this.rvFilter.ShowCheckBoxes = true;
            this.rvFilter.AllowEdit = false;
            this.rvFilter.RootElement.EnableElementShadow = false;
            this.rvFilter.HotTracking = false;
            this.rvFilter.ListViewElement.Padding = new Padding(0, 16, 0, 0);
            this.rvFilter.DisplayMember = "Name";
            this.rvFilter.ValueMember = "Value";
            GroupDescriptor groupByType = new GroupDescriptor(new SortDescriptor[]
            {
                new SortDescriptor("GroupName", ListSortDirection.Ascending),
            });
            rvFilter.GroupDescriptors.Add(groupByType);
        }
        private void WireEvents()
        {
            this.rvFilter.GroupExpanding += listView_GroupExpanding;
            this.rvFilter.ItemCheckedChanged += listView_ItemCheckedChanged;
            this.rvFilter.SelectedItemChanging += listView_SelectedItemChanging;
        }

        private void listView_SelectedItemChanging(object sender, ListViewItemCancelEventArgs e)
        {
            e.Cancel = true;
        }
        private void listView_ItemCheckedChanged(object sender, ListViewItemEventArgs e)
        {
            BuildFilters();
        }

        private void listView_GroupExpanding(object sender, ListViewGroupCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void BuildFilters()
        {
            DataFilterEventArgs newEvent = new DataFilterEventArgs();
            newEvent.CheckedItems = new List<DbFilter>();
            foreach (ListViewDataItem item in this.rvFilter.CheckedItems)
            {
                var filterItem = (UiDataFilter)item.DataBoundItem;
                newEvent.CheckedItems.Add(new DbFilter() { PropertyName = filterItem.FieldName, 
                    Value = filterItem.Value, 
                    DataType = "bool", 
                    Operation = ExpressOperation.GlobalOperation.GetOperationByName("EqualTo"),
                    FilterConnector = Connector.Or
                });
            }
            FilterEventRaiser(newEvent);
        }

        private void FilterEventRaiser(DataFilterEventArgs e)
        {
            if (FilterData != null)
                FilterData(this, e);
        }
    }

    public class DataFilterEventArgs : EventArgs
    {
        private List<DbFilter>? checkedItems;

        public List<DbFilter>? CheckedItems
        {
            get
            {
                return checkedItems;
            }
            set
            {
                checkedItems = value;
            }
        }
    }
}
