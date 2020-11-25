using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace DemoInterfaz
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            string http = "http://";
            string ip_server = "192.168.2.252";
            string user = "root";
            string password = "admin";

            
            string url = "/axis-cgi/mjpg/video.cgi";
            string urlDef = http + ip_server + url;

            AMC.MediaURL = urlDef;
            AMC.MediaType = "MJPEG";
            AMC.Play();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTransmicion());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMedia());
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormOverlay());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FormIp());
        }

        

        private void button5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AMC.FullScreen = true;
        }
    }
}
