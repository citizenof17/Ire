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
    public partial class FormDeer : Form
    {
        Form f;
        public FormDeer(Form parent)
        {
            InitializeComponent();
            f = parent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form final = new FormFinal();
            final.Show();
            FormMain.instance.final = true;
            f.Close();
            this.Close();
        }
    }
}
