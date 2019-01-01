using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _261218hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
            HeadLbl.BackColor = Color.Blue;
        }
        

        private void panel2_Click_1(object sender, EventArgs e)
        {
            HeadLbl.BackColor = Color.Green;
        }

        private void panel3_Click_1(object sender, EventArgs e)
        {
            HeadLbl.BackColor = Color.Yellow;
        }

        private void panel4_Click_1(object sender, EventArgs e)
        {
            HeadLbl.BackColor = Color.Pink;
        }

        private void panel5_Click_1(object sender, EventArgs e)
        {
            HeadLbl.BackColor = Color.Red;
        }
    }
}
