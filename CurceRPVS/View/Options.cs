using CurceRPVS.Model;
using System;
using System.Windows.Forms;

namespace CurceRPVS.View
{
    public partial class Options : Form
    {
        public Phisics phisics = new Phisics();
        private Phisics phisics_save = new Phisics();
        public Options(Phisics ph)
        {
            InitializeComponent();
            InitTextBox(ph);
            phisics_save = ph;
        }

        private void InitTextBox(Phisics ph)
        {
            //масс
            textBoxMass.Text = ph.NoCI_mass(ph.m_item).ToString();
            comboBoxMass.SelectedIndex = ph.m_item;

            //положение
            textBoxPosition.Text = ph.NoCI_q0(ph.q0_item).ToString();
            comboBoxPosition.SelectedIndex = ph.q0_item;

            //скорость
            textBoxSpeed.Text = ph.NoCI_dq0(ph.dq0_item).ToString();
            comboBoxSpeed.SelectedIndex = ph.dq0_item;

            //коэф пружины
            textBoxQuotSpring.Text = ph.k.ToString();
            comboBoxQuotSpring.SelectedIndex = ph.k_item;

            //коэф затухания
            textBoxQuatFading.Text = ph.c.ToString();
            comboBoxQuatFading.SelectedIndex = ph.c_item;

            //время
            textBoxTime.Text = ph.NoCI_time(ph.time_item).ToString();
            comboBoxTime.SelectedIndex = ph.time_item;

            //промежутки времени
            textBoxTimeStep.Text = ph.NoCI_timeInterval(ph.time_interval_item).ToString();
            comboBoxTimeStep.SelectedIndex = ph.time_interval_item;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (Volidat)
            {
                Save();
                Close();
            }
        }

        private void Save()
        {
            if (Double.TryParse(textBoxMass.Text, out double m))
            {
                phisics.m = phisics.CI_mass(m, comboBoxMass.SelectedIndex);
                phisics.m_item = comboBoxMass.SelectedIndex;
            }
            if (Double.TryParse(textBoxPosition.Text, out double q0))
            {
                phisics.q0 = phisics.CI_q0(q0,comboBoxPosition.SelectedIndex);
                phisics.q0_item = comboBoxPosition.SelectedIndex;
            }
            if (Double.TryParse(textBoxSpeed.Text, out double dq0))
            {
                phisics.dq0 = phisics.CI_dq0(dq0, comboBoxSpeed.SelectedIndex);
                phisics.dq0_item = comboBoxSpeed.SelectedIndex;
            }
            if (Double.TryParse(textBoxQuotSpring.Text, out double k))
            {
                phisics.k = k;
            }
            if (Double.TryParse(textBoxQuatFading.Text, out double c))
            {
                phisics.c = c;
            }

            if (Double.TryParse(textBoxTime.Text, out double time))
            {
                phisics.time = phisics.CI_time(time, comboBoxTime.SelectedIndex);
                phisics.time_item = comboBoxTime.SelectedIndex;
            }
            if (Double.TryParse(textBoxTimeStep.Text, out double timeStep))
            {
                phisics.time_interval = phisics.CI_timeInterval(timeStep, comboBoxTimeStep.SelectedIndex);
                phisics.time_interval_item = comboBoxTimeStep.SelectedIndex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            phisics = phisics_save;
            Close();
        }

        private void valid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
        private bool Volidat
        {
            get
            {
                if (textBoxMass.Text == "" && textBoxPosition.Text == "" && textBoxSpeed.Text == "" && textBoxQuotSpring.Text == "" && textBoxQuatFading.Text == "")
                {
                    MessageBox.Show("Заполните все поля");
                    return false;
                }
                else return true;
            }
        }
    }
}
