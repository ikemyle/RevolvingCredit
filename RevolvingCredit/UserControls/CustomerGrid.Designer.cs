namespace RevolvingCredit.UserControls
{
    partial class CustomerGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            gridCustomers = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)gridCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridCustomers.MasterTemplate).BeginInit();
            SuspendLayout();
            // 
            // gridCustomers
            // 
            gridCustomers.Dock = DockStyle.Fill;
            gridCustomers.Location = new Point(0, 0);
            // 
            // 
            // 
            gridCustomers.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.HeaderTextAlignment = ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn1.Name = "id";
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "Name";
            gridViewTextBoxColumn2.HeaderTextAlignment = ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn2.Name = "name";
            gridViewTextBoxColumn3.FieldName = "BusinessName";
            gridViewTextBoxColumn3.HeaderText = "Business Name";
            gridViewTextBoxColumn3.HeaderTextAlignment = ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn3.Name = "business";
            gridViewTextBoxColumn4.FieldName = "Address";
            gridViewTextBoxColumn4.HeaderText = "Address";
            gridViewTextBoxColumn4.HeaderTextAlignment = ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn4.Name = "address";
            gridViewTextBoxColumn5.FieldName = "City";
            gridViewTextBoxColumn5.HeaderText = "City";
            gridViewTextBoxColumn5.HeaderTextAlignment = ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn5.Name = "city";
            gridViewTextBoxColumn6.FieldName = "Phone";
            gridViewTextBoxColumn6.HeaderText = "Phone Number";
            gridViewTextBoxColumn6.HeaderTextAlignment = ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn6.Name = "phone";
            gridViewTextBoxColumn7.FieldName = "Title";
            gridViewTextBoxColumn7.HeaderText = "Title";
            gridViewTextBoxColumn7.HeaderTextAlignment = ContentAlignment.MiddleLeft;
            gridViewTextBoxColumn7.Name = "title";
            gridCustomers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] { gridViewTextBoxColumn1, gridViewTextBoxColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4, gridViewTextBoxColumn5, gridViewTextBoxColumn6, gridViewTextBoxColumn7 });
            gridCustomers.MasterTemplate.ViewDefinition = tableViewDefinition1;
            gridCustomers.Name = "gridCustomers";
            gridCustomers.Size = new Size(924, 507);
            gridCustomers.TabIndex = 4;
            // 
            // CustomerGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridCustomers);
            Name = "CustomerGrid";
            Size = new Size(924, 507);
            Load += CustomerGrid_Load;
            ((System.ComponentModel.ISupportInitialize)gridCustomers.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridCustomers;
    }
}
