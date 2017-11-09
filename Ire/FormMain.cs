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
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();

            Visible = false;
            Enabled = false;

            form.FormClosed += (object s, FormClosedEventArgs args) =>
            {
                Visible = true;
                Enabled = true;
            }; ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();

            Visible = false;
            Enabled = false;

            form.FormClosed += (object s, FormClosedEventArgs args) =>
            {
                Visible = true;
                Enabled = true;
            }; ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();

            Visible = false;
            Enabled = false;

            form.FormClosed += (object s, FormClosedEventArgs args) =>
            {
                Visible = true;
                Enabled = true;
            }; ;
        }
    }
}
