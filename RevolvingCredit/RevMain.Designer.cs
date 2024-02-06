namespace RevolvingCredit
{
    partial class RevMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            windows11DarkTheme1 = new Telerik.WinControls.Themes.Windows11DarkTheme();
            pvMain = new Telerik.WinControls.UI.RadPageView();
            vpCompany = new Telerik.WinControls.UI.RadPageViewPage();
            vpClients = new Telerik.WinControls.UI.RadPageViewPage();
            custGrid = new UserControls.CustomerGrid();
            contractDetail = new UserControls.ContractDetail();
            dataCustomerFilters = new UserControls.DataFilterList();
            radPanel1 = new Telerik.WinControls.UI.RadPanel();
            radPanel4 = new Telerik.WinControls.UI.RadPanel();
            rbReset = new Telerik.WinControls.UI.RadButton();
            radPanel3 = new Telerik.WinControls.UI.RadPanel();
            filterSearch = new CustomControls.SearchTextBox();
            vpBrokers = new Telerik.WinControls.UI.RadPageViewPage();
            vpContracts = new Telerik.WinControls.UI.RadPageViewPage();
            vpCalculator = new Telerik.WinControls.UI.RadPageViewPage();
            loanCalculator1 = new UserControls.LoanCalculator();
            vpUserProfile = new Telerik.WinControls.UI.RadPageViewPage();
            rtTheme = new Telerik.WinControls.UI.RadToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)pvMain).BeginInit();
            pvMain.SuspendLayout();
            vpClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radPanel1).BeginInit();
            radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radPanel4).BeginInit();
            radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rbReset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radPanel3).BeginInit();
            radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filterSearch).BeginInit();
            vpCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rtTheme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // pvMain
            // 
            pvMain.Controls.Add(vpCompany);
            pvMain.Controls.Add(vpClients);
            pvMain.Controls.Add(vpBrokers);
            pvMain.Controls.Add(vpContracts);
            pvMain.Controls.Add(vpCalculator);
            pvMain.Controls.Add(vpUserProfile);
            pvMain.Dock = DockStyle.Fill;
            pvMain.Location = new Point(0, 4);
            pvMain.Name = "pvMain";
            pvMain.SelectedPage = vpCalculator;
            pvMain.Size = new Size(1319, 293);
            pvMain.TabIndex = 0;
            ((Telerik.WinControls.UI.RadPageViewStripElement)pvMain.GetChildAt(0)).ShowItemPinButton = false;
            ((Telerik.WinControls.UI.RadPageViewStripElement)pvMain.GetChildAt(0)).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)pvMain.GetChildAt(0)).ShowItemCloseButton = false;
            // 
            // vpCompany
            // 
            vpCompany.ItemSize = new SizeF(99F, 28F);
            vpCompany.Location = new Point(10, 37);
            vpCompany.Name = "vpCompany";
            vpCompany.Size = new Size(1352, 237);
            vpCompany.Text = "COMPANY INFO";
            // 
            // vpClients
            // 
            vpClients.Controls.Add(custGrid);
            vpClients.Controls.Add(contractDetail);
            vpClients.Controls.Add(dataCustomerFilters);
            vpClients.Controls.Add(radPanel1);
            vpClients.ItemSize = new SizeF(58F, 28F);
            vpClients.Location = new Point(10, 37);
            vpClients.Name = "vpClients";
            vpClients.Size = new Size(1268, 223);
            vpClients.Text = "CLIENTS";
            // 
            // custGrid
            // 
            custGrid.Dock = DockStyle.Fill;
            custGrid.Location = new Point(256, 60);
            custGrid.Name = "custGrid";
            custGrid.Size = new Size(679, 163);
            custGrid.TabIndex = 3;
            // 
            // contractDetail
            // 
            contractDetail.Dock = DockStyle.Right;
            contractDetail.Location = new Point(935, 60);
            contractDetail.Name = "contractDetail";
            contractDetail.Size = new Size(333, 163);
            contractDetail.TabIndex = 2;
            // 
            // dataCustomerFilters
            // 
            dataCustomerFilters.Dock = DockStyle.Left;
            dataCustomerFilters.Location = new Point(0, 60);
            dataCustomerFilters.Name = "dataCustomerFilters";
            dataCustomerFilters.Size = new Size(256, 163);
            dataCustomerFilters.TabIndex = 1;
            // 
            // radPanel1
            // 
            radPanel1.Controls.Add(radPanel4);
            radPanel1.Controls.Add(radPanel3);
            radPanel1.Dock = DockStyle.Top;
            radPanel1.Location = new Point(0, 0);
            radPanel1.Name = "radPanel1";
            radPanel1.Size = new Size(1268, 60);
            radPanel1.TabIndex = 0;
            // 
            // radPanel4
            // 
            radPanel4.Controls.Add(rbReset);
            radPanel4.Dock = DockStyle.Fill;
            radPanel4.Location = new Point(0, 0);
            radPanel4.Name = "radPanel4";
            radPanel4.Size = new Size(733, 60);
            radPanel4.TabIndex = 7;
            // 
            // rbReset
            // 
            rbReset.Location = new Point(14, 12);
            rbReset.Name = "rbReset";
            rbReset.Size = new Size(123, 24);
            rbReset.TabIndex = 0;
            rbReset.Text = "Reset Filters";
            rbReset.Click += rbReset_Click;
            // 
            // radPanel3
            // 
            radPanel3.Controls.Add(filterSearch);
            radPanel3.Dock = DockStyle.Right;
            radPanel3.Location = new Point(733, 0);
            radPanel3.Name = "radPanel3";
            radPanel3.Size = new Size(535, 60);
            radPanel3.TabIndex = 6;
            // 
            // filterSearch
            // 
            filterSearch.Location = new Point(6, 12);
            filterSearch.Name = "filterSearch";
            filterSearch.NullText = "Search by client name or phone number";
            filterSearch.Size = new Size(523, 20);
            filterSearch.TabIndex = 0;
            // 
            // vpBrokers
            // 
            vpBrokers.ItemSize = new SizeF(63F, 28F);
            vpBrokers.Location = new Point(0, 0);
            vpBrokers.Name = "vpBrokers";
            vpBrokers.Size = new Size(200, 100);
            vpBrokers.Text = "BROKERS";
            // 
            // vpContracts
            // 
            vpContracts.ItemSize = new SizeF(79F, 28F);
            vpContracts.Location = new Point(0, 0);
            vpContracts.Name = "vpContracts";
            vpContracts.Size = new Size(200, 100);
            vpContracts.Text = "CONTRACTS";
            // 
            // vpCalculator
            // 
            vpCalculator.Controls.Add(loanCalculator1);
            vpCalculator.ItemSize = new SizeF(117F, 28F);
            vpCalculator.Location = new Point(10, 37);
            vpCalculator.Name = "vpCalculator";
            vpCalculator.Size = new Size(1298, 245);
            vpCalculator.Text = "LOAN CALCULATOR";
            // 
            // loanCalculator1
            // 
            loanCalculator1.Dock = DockStyle.Fill;
            loanCalculator1.Location = new Point(0, 0);
            loanCalculator1.Name = "loanCalculator1";
            loanCalculator1.Padding = new Padding(5);
            loanCalculator1.Size = new Size(1298, 245);
            loanCalculator1.TabIndex = 0;
            // 
            // vpUserProfile
            // 
            vpUserProfile.ItemSize = new SizeF(87F, 28F);
            vpUserProfile.Location = new Point(10, 37);
            vpUserProfile.Name = "vpUserProfile";
            vpUserProfile.Size = new Size(1110, 281);
            vpUserProfile.Text = "USER PROFILE";
            // 
            // rtTheme
            // 
            rtTheme.Location = new Point(1143, 4);
            rtTheme.Name = "rtTheme";
            rtTheme.OffText = "Dark";
            rtTheme.OnText = "Light";
            rtTheme.Size = new Size(67, 21);
            rtTheme.TabIndex = 4;
            rtTheme.ToggleStateMode = Telerik.WinControls.UI.ToggleStateMode.Click;
            rtTheme.ValueChanged += radToggleSwitch1_ValueChanged;
            // 
            // RevMain
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 297);
            Controls.Add(rtTheme);
            Controls.Add(pvMain);
            Name = "RevMain";
            Padding = new Padding(0, 4, 0, 0);
            Text = "Revolving Credit - App. v2.0";
            WindowState = FormWindowState.Maximized;
            Load += RevMain_Load;
            Resize += RevMain_Resize;
            ((System.ComponentModel.ISupportInitialize)pvMain).EndInit();
            pvMain.ResumeLayout(false);
            vpClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radPanel1).EndInit();
            radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)radPanel4).EndInit();
            radPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rbReset).EndInit();
            ((System.ComponentModel.ISupportInitialize)radPanel3).EndInit();
            radPanel3.ResumeLayout(false);
            radPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)filterSearch).EndInit();
            vpCalculator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rtTheme).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.Themes.Windows11DarkTheme windows11DarkTheme1;
        private Telerik.WinControls.UI.RadPageView pvMain;
        private Telerik.WinControls.UI.RadPageViewPage vpClients;
        private Telerik.WinControls.UI.RadPageViewPage vpCompany;
        private Telerik.WinControls.UI.RadPageViewPage vpCalculator;
        private Telerik.WinControls.UI.RadPageViewPage vpUserProfile;
        private Telerik.WinControls.UI.RadToggleSwitch rtTheme;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private CustomControls.SearchTextBox filterSearch;
        private Telerik.WinControls.UI.RadButton rbReset;
        private Telerik.WinControls.UI.RadPageViewPage vpBrokers;
        private Telerik.WinControls.UI.RadPageViewPage vpContracts;
        private UserControls.DataFilterList dataCustomerFilters;
        private UserControls.ContractDetail contractDetail;
        private UserControls.CustomerGrid custGrid;
        private UserControls.LoanCalculator loanCalculator1;
    }
}