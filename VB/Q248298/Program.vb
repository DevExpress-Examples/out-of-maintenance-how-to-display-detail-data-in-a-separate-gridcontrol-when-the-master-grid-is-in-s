Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Skins
Imports DevExpress.Xpo.DB
Imports System.Windows.Forms

Namespace Q248298
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			SkinManager.EnableFormSkins()
			XpoDefault.ConnectionString = AccessConnectionProvider.GetConnectionString("..\..\nwind.mdb")
			Application.Run(New MainForm())
		End Sub
	End Class
End Namespace