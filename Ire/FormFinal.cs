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
    public partial class FormFinal : Form
    {
        public FormFinal()
        {
            InitializeComponent();
        }

        private void FormFinal_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain.instance.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
