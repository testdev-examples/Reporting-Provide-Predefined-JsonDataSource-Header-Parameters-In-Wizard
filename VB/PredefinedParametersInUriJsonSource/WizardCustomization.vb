﻿Imports DevExpress.DataAccess.Json
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

		Public Sub CustomizeDataSourceWizard(ByVal tool As DevExpress.DataAccess.UI.Wizard.IWizardCustomization(Of XtraReportModel))
			Customize(tool)
		End Sub
		Public Sub CustomizeReportWizard(ByVal tool As DevExpress.DataAccess.UI.Wizard.IWizardCustomization(Of XtraReportModel))
			Customize(tool)
		End Sub
		Private Shared Sub Customize(ByVal tool As DevExpress.DataAccess.UI.Wizard.IWizardCustomization(Of XtraReportModel))
			DirectCast(tool.Model, IJsonDataSourceModel).JsonSource = New UriJsonSource() With {
				.HeaderParameters = { New HeaderParameter("TokenId", "9876543210")},
				.QueryParameters = { New QueryParameter("Parameter1", "Some Value")}
			}
		End Sub
		Public Function TryCreateDataSource(ByVal model As IDataSourceModel, <System.Runtime.InteropServices.Out()> ByRef dataSource As Object, <System.Runtime.InteropServices.Out()> ByRef dataMember As String) As Boolean
			dataSource = Nothing
			dataMember = Nothing
			Return False
		End Function
		Public Function TryCreateReport(ByVal designerHost As IDesignerHost, ByVal model As XtraReportModel, ByVal dataSource As Object, ByVal dataMember As String) As Boolean
			Return False
		End Function
	End Class
End Namespace
