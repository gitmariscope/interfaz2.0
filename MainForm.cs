using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoInterfaz
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            openChildForm(new FormIP());
        }
    }
}
