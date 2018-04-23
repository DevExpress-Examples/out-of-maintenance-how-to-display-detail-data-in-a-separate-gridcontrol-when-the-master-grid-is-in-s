using System;
using Northwind;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace Q248298 {
    public partial class MainForm : XtraForm {
        public MainForm() {
            InitializeComponent();
        }

        private void OnMainViewFocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            Categories category = ((ColumnView)sender).GetFocusedRow() as Categories;
            detailGrid.DataSource = category == null ? null : category.Products;
        }
    }
}