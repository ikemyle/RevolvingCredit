namespace RevolvingCredit.UserControls
{
    partial class DataFilterList
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
            radPanel1 = new Telerik.WinControls.UI.RadPanel();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            rvFilter = new Telerik.WinControls.UI.RadListView();
            radPanel2 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)radPanel1).BeginInit();
            radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rvFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radPanel2).BeginInit();
            radPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // radPanel1
            // 
            radPanel1.Controls.Add(radLabel1);
            radPanel1.Dock = DockStyle.Top;
            radPanel1.Location = new Point(0, 0);
            radPanel1.Name = "radPanel1";
            radPanel1.Size = new Size(345, 49);
            radPanel1.TabIndex = 1;
            // 
            // radLabel1
            // 
            radLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radLabel1.Location = new Point(15, 13);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(97, 25);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "Qucik Filters";
            // 
            // rvFilter
            // 
            rvFilter.Dock = DockStyle.Fill;
            rvFilter.Location = new Point(8, 8);
            rvFilter.Name = "rvFilter";
            rvFilter.Size = new Size(329, 417);
            rvFilter.TabIndex = 2;
            // 
            // radPanel2
            // 
            radPanel2.Controls.Add(rvFilter);
            radPanel2.Dock = DockStyle.Fill;
            radPanel2.Location = new Point(0, 49);
            radPanel2.Name = "radPanel2";
            radPanel2.Padding = new Padding(8);
            radPanel2.Size = new Size(345, 433);
            radPanel2.TabIndex = 3;
            // 
            // DataFilterList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(radPanel2);
            Controls.Add(radPanel1);
            Name = "DataFilterList";
            Size = new Size(345, 482);
            Load += DataFilterList_Load;
            ((System.ComponentModel.ISupportInitialize)radPanel1).EndInit();
            radPanel1.ResumeLayout(false);
            radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rvFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)radPanel2).EndInit();
            radPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadListView rvFilter;
        private Telerik.WinControls.UI.RadPanel radPanel2;
    }
}
