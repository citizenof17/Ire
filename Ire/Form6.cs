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
    public partial class Form6 : Form
    {
        PairStr[] rules = new PairStr[] { new PairStr("abc", "zzz"),
                                            new PairStr("abd", "zkz")};  //add rules
        int n;

        public Form6()
        {
            InitializeComponent();
            n = rules.Length;
            for (int i = 0; i < n; i++)
            {
                label2.Text += rules[i].first + " -> " + rules[i].second + "\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            t1 = t1.ToLower();
            t2 = t2.ToLower();

            string t3;

            bool find = true;
            while (find)
            {
                t3 = t1;

                find = false;
                for(int i = 0; i < n; i++)
                {
                    t1 = t1.Replace(rules[i].first, rules[i].second);
                    find = find || !(t3.Equals(t1));
                }
            }

            if (t1.Equals(t2))
            {
                FormKiller f = new FormKiller(this, "Nice!");
                f.Show();
            }
            else
            {
                MessageBox.Show("You are wrong, try again.");
            }
        }
    }

    public class PairStr
    {
        public string first;
        public string second;

        public PairStr(string t1, string t2)
        {
            first = t1;
            second = t2;
        }
    }
}
