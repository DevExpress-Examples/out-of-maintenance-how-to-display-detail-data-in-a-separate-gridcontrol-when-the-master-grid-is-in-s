Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo

Namespace Northwind

	Public Class Categories
		Inherits XPBaseObject
		Private fCategoryID As Integer
		<Key(True)> _
		Public Property CategoryID() As Integer
			Get
				Return fCategoryID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("CategoryID", fCategoryID, value)
			End Set
		End Property
		Private fCategoryName As String
		<Size(15)> _
		Public Property CategoryName() As String
			Get
				Return fCategoryName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("CategoryName", fCategoryName, value)
			End Set
		End Property
		<Association("Category-Products", GetType(Products))> _
		Public ReadOnly Property Products() As XPCollection(Of Products)
			Get
				Return GetCollection(Of Products)("Products")
			End Get
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

	Public Class Products
		Inherits XPLiteObject
		Private fProductID As Integer
		<Key(True)> _
		Public Property ProductID() As Integer
			Get
				Return fProductID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("ProductID", fProductID, value)
			End Set
		End Property
		Private fProductName As String
		<Size(40)> _
		Public Property ProductName() As String
			Get
				Return fProductName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("ProductName", fProductName, value)
			End Set
		End Property
		Private fCategoryID As Categories
		<Association("Category-Products")> _
		Public Property CategoryID() As Categories
			Get
				Return fCategoryID
			End Get
			Set(ByVal value As Categories)
				SetPropertyValue(Of Categories)("CategoryID", fCategoryID, value)
			End Set
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

End Namespace
