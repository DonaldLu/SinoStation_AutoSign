using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace AutoSign
{
    public partial class AutoSignForm : System.Windows.Forms.Form
    {
        public AutoSignForm(UIApplication uiapp, RevitDocument connect, ExternalEvent externalEvent_SignCheck)
        {
            InitializeComponent();
            CenterToParent();
        }
        // 關閉
        private void closeBtn_Click(object sender, EventArgs e)
        {
            TaskDialog.Show("Revit", "AutoSign");
            Close();
        }
    }
}
