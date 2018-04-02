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
    public partial class FormStart : Form
    {
        int cnt;
        public FormStart()
        {
            cnt = 0;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "You are on an excursion with your teacher and friends in The Library of Trinity College in Dublin. There are a lot of old books of ancient scientists and explorers. Suddenly you have found a secret chamber with lots of hidden documents and archives. And here it is! An old map to the treasure of leprechauns! The map has been here for a long time, so, unfortunately, some spots have been blurred. But don`t be upset! We are sure you will unravel all the mysteries to find a true way to the treasure!";
            cnt++;
            button1.Text = "Go ahead!";
            if (cnt == 2)
            {
                FormMain f = new FormMain();
                f.Show();
                Visible = false;
                Enabled = false;
                f.FormClosed += (object s, FormClosedEventArgs args) =>
                {
                    Visible = true;
                    Enabled = true;
                    Close();
                };
            }
        }
    }
}
