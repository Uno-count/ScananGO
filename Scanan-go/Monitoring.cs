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
    public partial class Monitoring : Form
    {
        public Monitoring()
        {
            InitializeComponent();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            DatetoDate();
        }
        public void DisplayMonitoring()
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            string sql = "";         
            obj.fetchMonitoring(sql, dgvMonitoring);

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void tbMntrngSearch_TextChanged(object sender, EventArgs e)
        {
            Classes.SQLControl obj = new Classes.SQLControl();         
            obj.findingMonitoring(tbMntrngSearch.Text,dgvMonitoring ) ;
        }
        public void DatetoDate()
        {         
            //label3.Text = dtpMntrngFrom.Text;
            //label4.Text = dtpMntrngTo.Text;
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.Dates date = new Classes.Dates(
                dtpMntrngFrom.Text,
                 dtpMntrngTo.Text
                );          
            obj.fetchingDatetoDate(date.getDate1() ,date.getDate2() ,dgvMonitoring );
        }
        private void Monitoring_Load(object sender, EventArgs e)
        {
            DisplayMonitoring();     
        }
    }
} 
