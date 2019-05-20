Imports DevExpress.XtraReports.Wizards
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace PredefinedParametersInUriJsonSource
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub PredefinedParametersInWizard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Dim reportDesignTool = New DevExpress.XtraReports.UI.ReportDesignTool(New DevExpress.XtraReports.UI.XtraReport())
            reportDesignTool.DesignForm.DesignMdiController.AddService(GetType(IWizardCustomizationService), New MyWizardCustomizationService())
            reportDesignTool.ShowDesignerDialog()
        End Sub
    End Class
End Namespace
