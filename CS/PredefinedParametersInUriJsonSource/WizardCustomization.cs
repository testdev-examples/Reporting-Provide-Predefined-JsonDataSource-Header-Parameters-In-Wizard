using DevExpress.DataAccess.Json;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.XtraReports.Wizards;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredefinedParametersInUriJsonSource {
    class MyWizardCustomizationService : IWizardCustomizationService {
        public void CustomizeDataSourceWizard(DevExpress.DataAccess.UI.Wizard.IWizardCustomization<XtraReportModel> tool) {
            Customize(tool);
        }
        public void CustomizeReportWizard(DevExpress.DataAccess.UI.Wizard.IWizardCustomization<XtraReportModel> tool) {
            Customize(tool);
        }
        static void Customize(DevExpress.DataAccess.UI.Wizard.IWizardCustomization<XtraReportModel> tool) {
            ((IJsonDataSourceModel)tool.Model).JsonSource = new UriJsonSource() {
                HeaderParameters = {
                    new HeaderParameter("TokenId", "9876543210"),
                },
                QueryParameters = {
                    new QueryParameter("Parameter1", "Some Value"),
                }
            };
        }
        public bool TryCreateDataSource(IDataSourceModel model, out object dataSource, out string dataMember) {
            dataSource = null;
            dataMember = null;
            return false;
        }
        public bool TryCreateReport(IDesignerHost designerHost, XtraReportModel model, object dataSource, string dataMember) {
            return false;
        }
    }
}
