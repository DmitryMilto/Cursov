using CurceRPVS.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CurceRPVS.View
{
    public partial class Setting : Form
    {
        public Settings settings = new Settings();
        public Settings settings_copy = new Settings();
        public Setting(Settings setting, int position = 0)
        {
            InitializeComponent();
            InitCommon(setting);
            InitGraf(setting);
            InitTable(setting);

            settings_copy = setting;

            if (position == 0)
            {
                panelGraf.Visible = false;
                panelTable.Visible = false;
            }
            if (position == 1)
            {
                panelGraf.Visible = true;
                panelTable.Visible = false;
            }
            if (position == 2)
            {
                panelGraf.Visible = false;
                panelTable.Visible = true;
            }
            panelGraf.Size = new Size(386, 216);
            panelGraf.Location = new Point(6, 19);

            panelTable.Size = new Size(386, 276);
            panelTable.Location = new Point(6, 19);
            
                

        }

        private void InitCommon(Settings setting)
        {

        }

        private void InitGraf(Settings setting)
        {
            button1.BackColor = setting.colorLineGraf;
            trackBarLine.Value = setting.lineThickness;
            checkBoxX.Checked = setting.AsixX;
            checkBoxY.Checked = setting.AsixY;
        }
        private void InitTable(Settings setting)
        {
            checkBoxTime.Checked = setting.time_Check;
            checkBoxMass.Checked = setting.mass_Check;
            checkBoxQ.Checked = setting.q_Check;
            checkBoxV.Checked = setting.dq0_Check;
            checkBoxC.Checked = setting.c_Check;
            checkBoxW.Checked = setting.w_Check;
            checkBoxE.Checked = setting.E_Check;
        }
        private void SaveGraf()
        {
            settings.colorLineGraf = button1.BackColor;
            settings.lineThickness = trackBarLine.Value;
            settings.AsixX = checkBoxX.Checked;
            settings.AsixY = checkBoxY.Checked;
        }

        private void SaveTable()
        {
            settings.time_Check = checkBoxTime.Checked;
            settings.mass_Check = checkBoxMass.Checked;
            settings.q_Check = checkBoxQ.Checked;
            settings.dq0_Check = checkBoxV.Checked;
            settings.c_Check = checkBoxC.Checked;
            settings.w_Check = checkBoxW.Checked;
            settings.E_Check = checkBoxE.Checked;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveGraf();
            SaveTable();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            settings = settings_copy;
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelGraf.Visible = true;
            panelTable.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelGraf.Visible = false;
            panelTable.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelGraf.Visible = false;
            panelTable.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            settings.colorLineGraf = colorDialog1.Color;
            button1.BackColor = colorDialog1.Color;
        }
    }
}
