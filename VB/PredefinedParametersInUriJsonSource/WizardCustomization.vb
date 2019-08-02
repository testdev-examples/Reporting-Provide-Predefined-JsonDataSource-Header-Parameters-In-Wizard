Imports DevExpress.DataAccess.Json
Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.XtraReports.Wizards
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.Design
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace PredefinedParametersInUriJsonSource
    Friend Class MyWizardCustomizationService
        Implements IWizardCustomizationService

        Public Sub CustomizeDataSourceWizard(ByVal tool As DevExpress.DataAccess.UI.Wizard.IWizardCustomization(Of XtraReportModel)) Implements IWizardCustomizationService.CustomizeDataSourceWizard
            Customize(tool)
        End Sub
        Public Sub CustomizeReportWizard(ByVal tool As DevExpress.DataAccess.UI.Wizard.IWizardCustomization(Of XtraReportModel)) Implements IWizardCustomizationService.CustomizeReportWizard
            Customize(tool)
        End Sub
        Private Shared Sub Customize(ByVal tool As DevExpress.DataAccess.UI.Wizard.IWizardCustomization(Of XtraReportModel))
            DirectCast(tool.Model, IJsonDataSourceModel).JsonSource = New UriJsonSource() With { _
                .HeaderParameters = { New HeaderParameter("TokenId", "9876543210")}, _
                .QueryParameters = { New QueryParameter("Parameter1", "Some Value")} _
            }
        End Sub
        Public Function TryCreateDataSource(ByVal model As IDataSourceModel, <System.Runtime.InteropServices.Out()> ByRef dataSource As Object, <System.Runtime.InteropServices.Out()> ByRef dataMember As String) As Boolean Implements IWizardCustomizationService.TryCreateDataSource
            dataSource = Nothing
            dataMember = Nothing
            Return False
        End Function
        Public Function TryCreateReport(ByVal designerHost As IDesignerHost, ByVal model As XtraReportModel, ByVal dataSource As Object, ByVal dataMember As String) As Boolean Implements IWizardCustomizationService.TryCreateReport
            Return False
        End Function
    End Class
End Namespace
