using System;
using System.Windows.Forms;

namespace CurceRPVS.View
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
            timer1.Interval = 1000; // 1000 миллисекунд
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
        }
        // обработчик события Tick таймера
        void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer1.Dispose();
                this.Hide();
                var form = new Form1();
                form.Closed += (s, args) => this.Close();
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
                
            }
        }
    }
}
