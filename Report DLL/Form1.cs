using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.IO;


namespace Report_DLL
{
    public partial class test : Form
    {

        public bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);

        }
        public test()
        {
            InitializeComponent();
             if (IsAdministrator() == false)
             {
                 DialogResult result1=MessageBox.Show("You must run this program as admin!", "Note!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                close();
            }
            
        }
      public void close()
        {
            this.Close();
        }
    private void btn_Apply_Click(object sender, EventArgs e)
        {
            string strCmdText;
            string version=CB_Version.Text;
            if (rB_FS.Checked)
            {
                strCmdText = "/C cd C:\\Program Files (x86)\\Freightstream\\" + version + "&regsvr32 fms2000report.dll";
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            }
            else if(rb_iLogisys.Checked && check_4927.Checked)
            {
                strCmdText = "/C cd C:\\Program Files (x86)\\Ilogisys\\" + version + "&regsvr32 iFMSReport.dll";
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            }
            else if(rb_iLogisys.Checked)
            {
                strCmdText = "/C cd C:\\Program Files (x86)\\Ilogisys\\" + version + "&regsvr32 iLogisysreport.dll";
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            }
            else if(!rB_FS.Checked && !rb_iLogisys.Checked)
            {
                MessageBox.Show("Please select FreightStream or iLogisys! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rB_FS_CheckedChanged(object sender, EventArgs e)
        {
            check_4927.Visible = false;
          if(rB_FS.Checked)
            {

                DirectoryInfo di = new DirectoryInfo("C:\\Program Files (x86)\\Freightstream");
                DirectoryInfo[] diArr = di.GetDirectories();
                foreach (DirectoryInfo dri in diArr)
                    CB_Version.Items.Add(dri.Name);


                DirectoryInfo di2 = new DirectoryInfo("C:\\Program Files (x86)\\iLogisys");
                DirectoryInfo[] diArr2 = di2.GetDirectories();
                foreach (DirectoryInfo dri in diArr2)
                    CB_Version.Items.Remove(dri.Name);

            }
        }

        private void rb_iLogisys_CheckedChanged(object sender, EventArgs e)
        {
            check_4927.Visible = true;
            if(rb_iLogisys.Checked)
            {
                DirectoryInfo di = new DirectoryInfo("C:\\Program Files (x86)\\iLogisys");
                DirectoryInfo[] diArr = di.GetDirectories();
                foreach (DirectoryInfo dri in diArr)
                    CB_Version.Items.Add(dri.Name);


                DirectoryInfo di2 = new DirectoryInfo("C:\\Program Files (x86)\\Freightstream");
                DirectoryInfo[] diArr2 = di2.GetDirectories();
                foreach (DirectoryInfo dri in diArr2)
                    CB_Version.Items.Remove(dri.Name);

            }
        }

       
    }
}
