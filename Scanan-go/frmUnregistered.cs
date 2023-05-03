using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scanan_go
{
    public partial class frmUnregistered : Form
    {
        private int _tick;
        Form2 frm2 = new Form2();
        public frmUnregistered()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0,255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            label1.ForeColor = Color.FromArgb(A, R, G, B);
            _tick++;
            if (_tick == 5)

            {
                
                this.Text = _tick.ToString();
                this.Dispose();
                frm2.ShowDialog();
                timer1.Stop();
            }
        }

        private void frmUnregistered_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
