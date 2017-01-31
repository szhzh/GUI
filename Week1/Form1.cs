using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(tbNumber.Text);
            if (num == 4)
            {
                this.BackColor = Color.Red;
            }
            if (num == 9)
            {
                this.BackColor = Color.Gold;
            }
            if (num == 14)
            {
                this.BackColor = Color.Magenta;
            }
            int num1 = num + 1;
            tbNumber.Text = Convert.ToString(num1); 
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbNumber.Text = "0";
        }
    }
}
