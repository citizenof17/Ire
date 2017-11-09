using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ire
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" &&
                textBox2.Text == "2" &&
                textBox3.Text == "8" &&
                textBox4.Text == "7" &&
                textBox5.Text == "5")
            {
                FormKiller f = new FormKiller(this, "Good job! You are right! You have a chance to find Irish Treasure of Leprechauns and to become true Irish!");
                f.Show();
            }
            else if (textBox1.Text != "" &&
                textBox2.Text != "" &&
                textBox3.Text != "" &&
                textBox4.Text != "" &&
                textBox5.Text != "")
            {
                MessageBox.Show("You are wrong, try again.");
            }
        }
    }

}
