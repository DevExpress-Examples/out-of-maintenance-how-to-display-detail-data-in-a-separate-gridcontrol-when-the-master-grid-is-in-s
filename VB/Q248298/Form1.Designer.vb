Imports Microsoft.VisualBasic
Imports System
Namespace Q248298
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.mainGrid = New DevExpress.XtraGrid.GridControl()
			Me.source = New DevExpress.Xpo.XPServerCollectionSource()
			Me.session = New DevExpress.Xpo.Session()
			Me.mainView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.splitContainer = New DevExpress.XtraEditors.SplitContainerControl()
			Me.detailGrid = New DevExpress.XtraGrid.GridControl()
			Me.detailView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.mainGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.source, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.session, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.mainView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainer.SuspendLayout()
			CType(Me.detailGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.detailView, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' mainGrid
			' 
			Me.mainGrid.DataSource = Me.source
			Me.mainGrid.Dock = System.Windows.Forms.DockStyle.Fill
			Me.mainGrid.Location = New System.Drawing.Point(0, 0)
			Me.mainGrid.MainView = Me.mainView
			Me.mainGrid.Name = "mainGrid"
			Me.mainGrid.ServerMode = True
			Me.mainGrid.ShowOnlyPredefinedDetails = True
			Me.mainGrid.Size = New System.Drawing.Size(389, 267)
			Me.mainGrid.TabIndex = 0
			Me.mainGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.mainView})
			' 
			' source
			' 
			Me.source.DisplayableProperties = "CategoryID;CategoryName"
			Me.source.ObjectType = GetType(Northwind.Categories)
			Me.source.Session = Me.session
			' 
			' mainView
			' 
			Me.mainView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryID, Me.colCategoryName})
			Me.mainView.GridControl = Me.mainGrid
			Me.mainView.Name = "mainView"
'			Me.mainView.FocusedRowChanged += New DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(Me.OnMainViewFocusedRowChanged);
			' 
			' splitContainer
			' 
			Me.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainer.Location = New System.Drawing.Point(0, 0)
			Me.splitContainer.Name = "splitContainer"
			Me.splitContainer.Panel1.Controls.Add(Me.mainGrid)
			Me.splitContainer.Panel1.Text = "Panel1"
			Me.splitContainer.Panel2.Controls.Add(Me.detailGrid)
			Me.splitContainer.Panel2.Text = "Panel2"
			Me.splitContainer.Size = New System.Drawing.Size(825, 273)
			Me.splitContainer.SplitterPosition = 395
			Me.splitContainer.TabIndex = 1
			Me.splitContainer.Text = "splitContainerControl1"
			' 
			' detailGrid
			' 
			Me.detailGrid.Dock = System.Windows.Forms.DockStyle.Fill
			Me.detailGrid.Location = New System.Drawing.Point(0, 0)
			Me.detailGrid.MainView = Me.detailView
			Me.detailGrid.Name = "detailGrid"
			Me.detailGrid.ShowOnlyPredefinedDetails = True
			Me.detailGrid.Size = New System.Drawing.Size(420, 267)
			Me.detailGrid.TabIndex = 2
			Me.detailGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.detailView})
			' 
			' detailView
			' 
			Me.detailView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductID, Me.colProductName})
			Me.detailView.GridControl = Me.detailGrid
			Me.detailView.Name = "detailView"
			' 
			' colProductID
			' 
			Me.colProductID.Caption = "Product ID"
			Me.colProductID.FieldName = "ProductID"
			Me.colProductID.Name = "colProductID"
			Me.colProductID.Visible = True
			Me.colProductID.VisibleIndex = 0
			' 
			' colProductName
			' 
			Me.colProductName.Caption = "Product Name"
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 1
			' 
			' colCategoryID
			' 
			Me.colCategoryID.Caption = "CategoryID"
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.Visible = True
			Me.colCategoryID.VisibleIndex = 0
			' 
			' colCategoryName
			' 
			Me.colCategoryName.Caption = "CategoryName"
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 1
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(825, 273)
			Me.Controls.Add(Me.splitContainer)
			Me.Name = "MainForm"
			Me.Text = "DX Sample"
			CType(Me.mainGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.source, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.session, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.mainView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer.ResumeLayout(False)
			CType(Me.detailGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.detailView, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private mainGrid As DevExpress.XtraGrid.GridControl
		Private WithEvents mainView As DevExpress.XtraGrid.Views.Grid.GridView
		Private splitContainer As DevExpress.XtraEditors.SplitContainerControl
		Private detailGrid As DevExpress.XtraGrid.GridControl
		Private detailView As DevExpress.XtraGrid.Views.Grid.GridView
		Private session As DevExpress.Xpo.Session
		Private source As DevExpress.Xpo.XPServerCollectionSource
		Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn

	End Class
End Namespace

