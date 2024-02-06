using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.Themes;
using RevolvingCredit.Helpers;
using Microsoft.Extensions.Caching.Memory;
using RevolvingCredit.Data.DataFiltering;
using RevolvingCredit.UserControls;
using static RevolvingCredit.CustomControls.SearchTextBox;
using ExpressionBuilder.Common;
using RevolvingCredit.Core;
using Shell32;

namespace RevolvingCredit
{
    public partial class RevMain : RadForm
    {
        private const string CustomerQF = "CUSTOMERSQUICKFILTER";
        private const string CustomerSearch = "CUSTOMERSEARCH";
        private string CurrentTheme = Utils.LightTheme;
        private readonly IMemoryCache _memCache;
        public RevMain(IMemoryCache memCache)
        {
            InitializeComponent();
            ApplyTheme();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            _memCache = memCache;
        }

        private void ApplyTheme()
        {
            ThemeResolutionService.ApplicationThemeName = CurrentTheme;
            this.ThemeName = CurrentTheme;
            ThemeResolutionService.ApplyThemeToControlTree(this, CurrentTheme);
        }

        private void RevMain_Load(object sender, EventArgs e)
        {
            SetThemeToggleLocation();
            this.FormElement.TitleBar.TitlePrimitive.Margin = new Padding(2, 2, 0, 0);
            this.FormElement.TitleBar.TitlePrimitive.CustomFont = Utils.MainFont;
            this.FormElement.TitleBar.TitlePrimitive.CustomFontSize = 10.5f;
            this.FormElement.TitleBar.TitlePrimitive.TextAlignment = ContentAlignment.MiddleLeft;
            this.pvMain.Font = new Font(Utils.MainFont, 10.5f);
            DataLoad();
            WireEvents();
        }

        private void DataLoad()
        {
            var data = RawData.GetCustomerFilters();
            this.dataCustomerFilters.LoadData(data);
        }
        private void WireEvents()
        {
            this.dataCustomerFilters.FilterData += dataCustomerFilters_FilterData;
            this.filterSearch.Search += filterSearch_Search;
            this.custGrid.SelectRowContractId += custGrid_SelectRowContractId;
        }
        private void custGrid_SelectRowContractId(object sender, ContractEventArgs e)
        {
            contractDetail.LoadData(e.ContractId);
        }

        private void filterSearch_Search(object sender, SearchBoxEventArgs e)
        {
            var allFilters = new List<DbFilter>();
            //TODO create filtering groups to combine search with quick filter
            //var savedFilters = _memCache.Get(CustomerQF);
            //if (savedFilters != null)
            //{
            //    allFilters = (List<DbFilter>)savedFilters;
            //}
            allFilters.Add(new DbFilter()
            {
                PropertyName = "Name",
                Value = e.SearchText,
                DataType = "string",
                Operation = ExpressOperation.GlobalOperation.GetOperationByName("Contains"),
                FilterConnector = Connector.Or
            });
            allFilters.Add(new DbFilter()
            {
                PropertyName = "Phone",
                Value = e.SearchText,
                DataType = "string",
                Operation = ExpressOperation.GlobalOperation.GetOperationByName("Contains"),
                FilterConnector = Connector.Or
            });
            custGrid.FilterData(allFilters);
            _memCache.Set(CustomerSearch, allFilters);
        }

        private void dataCustomerFilters_FilterData(object sender, DataFilterEventArgs e)
        {
            if (e.CheckedItems?.Any() == true)
            {
                _memCache.Set(CustomerQF, e.CheckedItems);
                custGrid.FilterData(e.CheckedItems);
            }
        }

        private void SetThemeToggleLocation()
        {
            var xPadd = 20;
            var yPadd = 12;

            if (CurrentTheme == Utils.LightTheme)
                yPadd = 16;

            if (this.Width > rtTheme.Width - 20)
                this.rtTheme.Location = new Point(this.Width - rtTheme.Width - xPadd, yPadd);
        }

        private void radToggleSwitch1_ValueChanged(object sender, EventArgs e)
        {
            if (CurrentTheme == Utils.LightTheme) { CurrentTheme = Utils.DarkTheme; }
            else { CurrentTheme = Utils.LightTheme; }
            ApplyTheme();
        }

        private void RevMain_Resize(object sender, EventArgs e)
        {
            SetThemeToggleLocation();
        }

        private void rbReset_Click(object sender, EventArgs e)
        {
            custGrid.ResetFilters();
        }
    }
}
