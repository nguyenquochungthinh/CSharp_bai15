using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_bai15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
        }

        

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            txtLapTrinh.Text = txtNhapTen.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void radRed_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "radRed":
                    txtLapTrinh.ForeColor = Color.Red;
                    txtNhapTen.ForeColor = Color.Red;
                    break;
                case "radGreen":
                    txtLapTrinh.ForeColor = Color.Red;
                    txtNhapTen.ForeColor = Color.Red;
                    break;
            }
        
        }

        private void txtLapTrinh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
