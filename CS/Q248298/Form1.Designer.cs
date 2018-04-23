namespace Q248298 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mainGrid = new DevExpress.XtraGrid.GridControl();
            this.source = new DevExpress.Xpo.XPServerCollectionSource();
            this.session = new DevExpress.Xpo.Session();
            this.mainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainer = new DevExpress.XtraEditors.SplitContainerControl();
            this.detailGrid = new DevExpress.XtraGrid.GridControl();
            this.detailView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.DataSource = this.source;
            this.mainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGrid.Location = new System.Drawing.Point(0, 0);
            this.mainGrid.MainView = this.mainView;
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.ServerMode = true;
            this.mainGrid.ShowOnlyPredefinedDetails = true;
            this.mainGrid.Size = new System.Drawing.Size(389, 267);
            this.mainGrid.TabIndex = 0;
            this.mainGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mainView});
            // 
            // source
            // 
            this.source.DisplayableProperties = "CategoryID;CategoryName";
            this.source.ObjectType = typeof(Northwind.Categories);
            this.source.Session = this.session;
            // 
            // mainView
            // 
            this.mainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryID,
            this.colCategoryName});
            this.mainView.GridControl = this.mainGrid;
            this.mainView.Name = "mainView";
            this.mainView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.OnMainViewFocusedRowChanged);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.mainGrid);
            this.splitContainer.Panel1.Text = "Panel1";
            this.splitContainer.Panel2.Controls.Add(this.detailGrid);
            this.splitContainer.Panel2.Text = "Panel2";
            this.splitContainer.Size = new System.Drawing.Size(825, 273);
            this.splitContainer.SplitterPosition = 395;
            this.splitContainer.TabIndex = 1;
            this.splitContainer.Text = "splitContainerControl1";
            // 
            // detailGrid
            // 
            this.detailGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailGrid.Location = new System.Drawing.Point(0, 0);
            this.detailGrid.MainView = this.detailView;
            this.detailGrid.Name = "detailGrid";
            this.detailGrid.ShowOnlyPredefinedDetails = true;
            this.detailGrid.Size = new System.Drawing.Size(420, 267);
            this.detailGrid.TabIndex = 2;
            this.detailGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.detailView});
            // 
            // detailView
            // 
            this.detailView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductID,
            this.colProductName});
            this.detailView.GridControl = this.detailGrid;
            this.detailView.Name = "detailView";
            // 
            // colProductID
            // 
            this.colProductID.Caption = "Product ID";
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            this.colProductID.Visible = true;
            this.colProductID.VisibleIndex = 0;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Product Name";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 1;
            // 
            // colCategoryID
            // 
            this.colCategoryID.Caption = "CategoryID";
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 0;
            // 
            // colCategoryName
            // 
            this.colCategoryName.Caption = "CategoryName";
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 273);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainForm";
            this.Text = "DX Sample";
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl mainGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView mainView;
        private DevExpress.XtraEditors.SplitContainerControl splitContainer;
        private DevExpress.XtraGrid.GridControl detailGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView detailView;
        private DevExpress.Xpo.Session session;
        private DevExpress.Xpo.XPServerCollectionSource source;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;

    }
}

