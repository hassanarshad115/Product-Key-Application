using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second
{
    public partial class Form1 : Form
    {

        public int Totaldaysleft { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            totaldaysleftlabel.Text = "You Have Left  " + Totaldaysleft + "  Days.";

            if(Totaldaysleft > 0)
            {

                exitbutton.Text = "Continue Trial";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            if (Totaldaysleft == 0) {
                Application.Exit();

            }
            else
            {
                this.Close();
            }
        }
    }
}
