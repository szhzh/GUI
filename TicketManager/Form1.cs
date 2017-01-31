using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbAll_TextChanged(object sender, EventArgs e)
        {
            //int kids = Int32.Parse(tbKids.Text);
            //int pupils = Int32.Parse(tbPupils.Text);
            //int students = Int32.Parse(tbStudents.Text);
            //if (tbKids.Text != "" || tbPupils.Text != "" || tbStudents.Text != "")
            //{
            //    tbAll.Text = Convert.ToString(3 * kids + 4 * pupils + 5 * students) + " лв";
            //}
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            int kids = Int32.Parse(tbKids.Text);
            int pupils = Int32.Parse(tbPupils.Text);
            int students = Int32.Parse(tbStudents.Text);
            if (tbKids.Text != "" || tbPupils.Text != "" || tbStudents.Text != "")
            {
                tbAll.Text = Convert.ToString(3 * kids + 4 * pupils + 5 * students) + " лв";
            }
            else
            {
                MessageBox.Show("Не са въведени данни !");
            }
        }

        private void tbKids_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbPupils_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbStudents_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = lblPrice.Font.Size;
            currentSize += 2.0F;
            lblPrice.Font = new Font(lblPrice.Font.Name, currentSize,
                lblPrice.Font.Style, lblPrice.Font.Unit);
        }

    }
}
