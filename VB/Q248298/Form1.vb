Imports Microsoft.VisualBasic
Imports System
Imports Northwind
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Namespace Q248298
	Partial Public Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnMainViewFocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs) Handles mainView.FocusedRowChanged
			Dim category As Categories = TryCast((CType(sender, ColumnView)).GetFocusedRow(), Categories)
			If category Is Nothing Then
				detailGrid.DataSource = Nothing
			Else
				detailGrid.DataSource = category.Products
			End If
		End Sub
	End Class
End Namespace