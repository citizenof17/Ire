﻿using System;
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
    public partial class FormKiller : Form
    {
        Form f;
        public FormKiller(Form parent, string text)
        {
            InitializeComponent();
            f = parent;
            label1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMain.Counter++;
            f.Close();
            this.Close();
        }
    }
}
