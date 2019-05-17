using DevExpress.XtraReports.Wizards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredefinedParametersInUriJsonSource {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        void PredefinedParametersInWizard_Click(object sender, EventArgs e) {
            var reportDesignTool = new DevExpress.XtraReports.UI.ReportDesignTool(new DevExpress.XtraReports.UI.XtraReport());
            reportDesignTool.DesignForm.DesignMdiController.AddService(typeof(IWizardCustomizationService), new MyWizardCustomizationService());
            reportDesignTool.ShowDesignerDialog();
        }
    }
}
