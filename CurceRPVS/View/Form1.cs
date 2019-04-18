using CurceRPVS.Model;
using CurceRPVS.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace CurceRPVS
{
    public partial class Form1 : Form
    {
        Phisics phisics;
        Points points;
        List<Points> listPoints;
        Settings settings;

        Tables tables = new Tables();

        public Form1()
        {
            InitializeComponent();
            panelTable.Location = panelGraf.Location = new Point(12, 27);
            panelTable.Size = panelGraf.Size = new Size(776, 411);
            dataGridView1.Size = chart1.Size = new Size(770,405);
            phisics = new Phisics();
            listPoints = new List<Points>();
            points = new Points();
            settings = new Settings();

            listPoints = points.PointsList(phisics);
            SetSetting();
            GrafMenu.PerformClick();

            Timer timer = new Timer();
            timer.Interval += 1000;
            timer.Tick += new EventHandler(Point);
            timer.Start();
        }

        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
        }

        private void clearMenu_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
        }

        private void settingMenu_Click(object sender, EventArgs e)
        {
            Setting form = new Setting(settings, 1);
            form.ShowDialog();
            settings = form.settings;
            SetSetting();
        }

        private void Point(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            foreach (Points point in listPoints)
            {
                chart1.Series[0].Points.AddXY(point.X, point.Y);
            }
            
        }
        private void Table(object sender, EventArgs e)
        {
            
        }
        private void SetSetting()
        {
            chart1.Series[0].Color = settings.colorLineGraf;
            chart1.Series[0].BorderWidth = settings.lineThickness;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = settings.AsixX;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = settings.AsixY;
        }
        private void optoinsMenu_Click(object sender, EventArgs e)
        {
            listPoints.Clear();
            Options form = new Options(phisics);
            form.ShowDialog();
            phisics = form.phisics;
            listPoints = points.PointsList(phisics);
        }

        private void closeMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void settingMenu_Click_1(object sender, EventArgs e)
        {
            Setting form = new Setting(settings);
            form.ShowDialog();
            settings = form.settings;
            SetSetting();
        }

        private void GrafMenu_Click(object sender, EventArgs e)
        {
            GrafMenu.Checked = true;
            TableMenu.Checked = false;

            panelGraf.Visible = true;
            panelTable.Visible = false;
        }

        private void TableMenu_Click(object sender, EventArgs e)
        {
            GrafMenu.Checked = false;
            TableMenu.Checked = true;

            panelGraf.Visible = false;
            panelTable.Visible = true;

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            List<DataGridViewTextBoxColumn> dataTableColumb = tables.CreateTableColumn(settings);
            List<DataGridViewRow> dataTableRow = tables.CreateTableRow(phisics, settings);
            foreach (DataGridViewTextBoxColumn data in dataTableColumb)
            {
                dataGridView1.Columns.Add(data);
            }
            foreach (DataGridViewRow data in dataTableRow)
            {
                dataGridView1.Rows.Add(data);
            }
            
        }

        private void HelpMenu_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(null, "Help.chm", "xyz_index.html");
        }
    }
}
