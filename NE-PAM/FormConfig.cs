using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgramMonitor
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            String iniPath = Application.StartupPath + "\\config.monitoring.ini";

            txtDbIP.Text = IniFile.GetIniValue("MONITORING", "DBIP", iniPath);
            txtDbPORT.Text = IniFile.GetIniValue("MONITORING", "DBPORT", iniPath);
            txtDbNAME.Text = IniFile.GetIniValue("MONITORING", "DBNAME", iniPath);
            txtDbID.Text = IniFile.GetIniValue("MONITORING", "DBID", iniPath);
            txtDbPWD.Text = IniFile.GetIniValue("MONITORING", "DBPASSWD", iniPath);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String iniPath = Application.StartupPath + "\\config.monitoring.ini";

            IniFile.SetIniValue("MONITORING", "DBIP", txtDbIP.Text.Trim(), iniPath);
            IniFile.SetIniValue("MONITORING", "DBPORT", txtDbPORT.Text.Trim(), iniPath);
            IniFile.SetIniValue("MONITORING", "DBNAME", txtDbNAME.Text.Trim(), iniPath);
            IniFile.SetIniValue("MONITORING", "DBID", txtDbID.Text.Trim(), iniPath);
            IniFile.SetIniValue("MONITORING", "DBPASSWD", txtDbPWD.Text.Trim(), iniPath);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
