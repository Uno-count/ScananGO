using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;


namespace Scanan_go
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        public static string passing;

       public void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            cboDevice.Hide();
            rtbContainer.Hide();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            cboDevice.Items.Add(filterInfo.Name);
            {
                cboDevice.SelectedIndex = 0;
                captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();

            }
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbScanner.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            if (pbScanner.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pbScanner.Image);
                if (result != null)
                {
                    captureDevice.Stop();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                    rtbContainer.Text = result.ToString();
                    passing = rtbContainer.Lines[0] + " " + rtbContainer.Lines[1] + " " + rtbContainer.Lines[2];
                    Monitoring();

                }
               
            }
            
        }
        public void Monitoring()
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.MonitoringDatabase monitor = new Classes.MonitoringDatabase(
                //Fname.ToUpper(),
                rtbContainer.Lines[0] +" "+ rtbContainer.Lines[1] + " " + rtbContainer.Lines[2],
                //email,
                rtbContainer.Lines[3],
                //phonenum,
                rtbContainer.Lines[4],
                //address.ToUpper()
                rtbContainer.Lines[5]
                
                
                );
            obj.MonitoringDatabase(monitor.getFullname(), monitor.getEmail(), monitor.getPhoneNo(), monitor.getAddress(), DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("hh:mm:ss"));

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            timer1.Stop();
            captureDevice.Stop();
        }
    }
}
