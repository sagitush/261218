using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _261218_2
{
    public partial class Form1 : Form
    {
        int[] Randomarray = new int[10];
        int sum=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Random r = new Random();
            for (int i = 0; i < Randomarray.Length; i++)
            {
                Randomarray[i] = r.Next(101);

            }
            

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (sum < Randomarray.Length)
            {
                if (sum != Randomarray.Length - 1)
                {
                    NumberLbl.Text = $"The number is:{Randomarray[sum]}";
                    sum = sum + 1;
                }
                else
                {
                    NumberLbl.Text = $"The number is:{Randomarray[sum]}";
                    sum = sum + 1;
                    NumberLbl.BackColor = Color.Red;
                }
            }
            
        }
    }
}
