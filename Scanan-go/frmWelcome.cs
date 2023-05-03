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
    public partial class frmWelcome : Form
    {
        private int _tick;
        Form2 frm2 = new Form2();
        AccSett accSett = new AccSett();
        public frmWelcome()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.FromRectangle(this.DesktopBounds).WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            label2.Text = Form2.passing;
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _tick++;
            if (_tick == 2)
                
            {
                this.Text = _tick.ToString();
                this.Dispose();
                frm2.ShowDialog();
                timer1.Stop();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
