using Ire.Properties;
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
        static public int Counter = 0;
        static public FormMain instance;
        public bool final = false;

        List<Image> images;

        public FormMain()
        {
            if (instance == null)
            {
                
                InitializeComponent();
                instance = this;
            }
            Update_All();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();

            Visible = false;
            Enabled = false;

            form.FormClosed += (object s, FormClosedEventArgs args) =>
            {

                Update_All();
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

                Update_All();
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
                if (!final)
                { 

                    Visible = true;
                    Enabled = true;
                }
            }; ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

            Visible = false;
            Enabled = false;

            form.FormClosed += (object s, FormClosedEventArgs args) =>
            {

                Update_All();
                Visible = true;
                Enabled = true;
                
            }; ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();

            Visible = false;
            Enabled = false;

            form.FormClosed += (object s, FormClosedEventArgs args) =>
            {
                Update_All();
                Visible = true;
                Enabled = true;

            }; ;
        }

        private void Update_All()
        {
            string[] a = { "Dublin", "Kilkenny", "Cliffs of Moher", "Trim Castle", "Dublin" };
            label1.Text = "Next Station: " + a[Counter];
            this.BackgroundImage = images[Counter];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Counter == 0)
            {
                button1_Click(sender, e);
            }
            else if (Counter == 1)
            {
                button2_Click(sender, e);
            }
            else if (Counter == 2)
            {
                button5_Click(sender, e);
            }
            else if (Counter == 3)
            {
                button4_Click(sender, e);
            }
            else
            {
                button3_Click(sender, e);
            }
        }
    }
}
