using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Ire
{
    public partial class Form6 : Form
    {
        int n = 5;

        ArrayList good = new ArrayList { "bright", "healthy", "face", "morning", "bus" };
        ArrayList ans = new ArrayList(5);

        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool flag = true;
            flag = flag && (textBox1.Text.ToLower().Equals((string)good[0]));
            flag = flag && (textBox2.Text.ToLower().Equals((string)good[1]));
            flag = flag && (textBox3.Text.ToLower().Equals((string)good[2]));
            flag = flag && (textBox4.Text.ToLower().Equals((string)good[3]));
            flag = flag && (textBox5.Text.ToLower().Equals((string)good[4]));

            if (flag)
            {
                Form f = new FormDeer(this);
                f.Show();
            }
        }
    }
}
