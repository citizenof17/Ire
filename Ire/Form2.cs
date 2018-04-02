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
    public partial class Form2 : Form
    {
        int count = 10;
        string curName = "00";
        public Form2()
        {
            InitializeComponent();
            count = 10;
            curName = "00";
            button1.Enabled = false;
            button1.Visible = false;
            pictureBox12.AllowDrop = true;
            pictureBox13.AllowDrop = true;
            pictureBox14.AllowDrop = true;
            pictureBox21.AllowDrop = true;
            pictureBox22.AllowDrop = true;
            pictureBox23.AllowDrop = true;
            pictureBox25.AllowDrop = true;
            pictureBox31.AllowDrop = true;
            pictureBox33.AllowDrop = true;
            pictureBox34.AllowDrop = true;

        }



        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void Update_all()
        {
            if (count == 0)
            {
                AllowDrop = false;
                button1.Visible = true;
                button1.Enabled = true;
            }
        }

        private void pictureBox12_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox12_DragDrop(object sender, DragEventArgs e)
        {
            if (curName == "pictureBox12")
            {
                pictureBox12.Image = puzzle12.Image;
                puzzle12.Visible = false;
                puzzle12.Enabled = false;
                count--;
                pictureBox12.AllowDrop = false;
                Update_all();
                
            }
        }

        private void puzzle21_MouseDown(object sender, MouseEventArgs e)
        {
            curName = "pictureBox21";
            DoDragDrop(puzzle21.Image, DragDropEffects.Copy);
            curName = "00";
        }

        private void puzzle22_MouseDown(object sender, MouseEventArgs e)
        {
            curName = "pictureBox22";
            DoDragDrop(puzzle22.Image, DragDropEffects.Copy);
            curName = "00";
        }

        private void puzzle25_MouseDown(object sender, MouseEventArgs e)
        {
            curName = "pictureBox25";
            DoDragDrop(puzzle25.Image, DragDropEffects.Copy);
            curName = "00";
        }

        private void puzzle14_MouseDown(object sender, MouseEventArgs e)
        {
            curName = "pictureBox14";
            DoDragDrop(puzzle14.Image, DragDropEffects.Copy);
            curName = "00";
        }

        private void puzzle12_MouseDown(object sender, MouseEventArgs e)
        {
            curName = "pictureBox12";
            DoDragDrop(puzzle12.Image, DragDropEffects.Copy);
            curName = "00";
        }

        private void puzzle34_MouseDown(object sender, MouseEventArgs e)
        {
            curName = "pictureBox34";
            DoDragDrop(puzzle34.Image, DragDropEffects.Copy);
            curName = "00";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            curName = "pictureBox33";
            DoDragDrop(puzzle33.Image, DragDropEffects.Copy);
            curName = "00";
        }

        private void puzzle31_MouseDown(object sender, MouseEventArgs e)
        {
            curName = "pictureBox31";
            DoDragDrop(puzzle31.Image, DragDropEffects.Copy);
            curName = "00";
        }

        private void puzzle13_MouseDown(object sender, MouseEventArgs e)
        {
            curName = "pictureBox13";
            DoDragDrop(puzzle13.Image, DragDropEffects.Copy);
            curName = "00";
        }

        private void puzzle23_MouseDown(object sender, MouseEventArgs e)
        {
            curName = "pictureBox23";
            DoDragDrop(puzzle23.Image, DragDropEffects.Copy);
            curName = "00";
        }

        private void pictureBox13_DragDrop(object sender, DragEventArgs e)
        {
            if (curName == "pictureBox13")
            {
                pictureBox13.Image = puzzle13.Image;
                puzzle13.Visible = false;
                puzzle13.Enabled = false;
                pictureBox13.AllowDrop = false;
                count--;
                Update_all();
            }
        }

        private void pictureBox13_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox14_DragDrop(object sender, DragEventArgs e)
        {
            if (curName == "pictureBox14")
            {
                pictureBox14.Image = puzzle14.Image;
                puzzle14.Visible = false;
                puzzle14.Enabled = false;
                count--;
                pictureBox14.AllowDrop = false;
                Update_all();
            }
        }

        private void pictureBox14_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox21_DragDrop(object sender, DragEventArgs e)
        {
            if (curName == "pictureBox21")
            {
                pictureBox21.Image = puzzle21.Image;
                puzzle21.Visible = false;
                puzzle21.Enabled = false;
                pictureBox21.AllowDrop = false;
                count--;
                Update_all();
            }
        }

        private void pictureBox21_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox22_DragDrop(object sender, DragEventArgs e)
        {
            if (curName == "pictureBox22")
            {
                pictureBox22.Image = puzzle22.Image;
                puzzle22.Visible = false;
                puzzle22.Enabled = false;
                pictureBox22.AllowDrop = false;
                count--;
                Update_all();
            }
        }

        private void pictureBox22_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox23_DragDrop(object sender, DragEventArgs e)
        {
            if (curName == "pictureBox23")
            {
                pictureBox23.Image = puzzle23.Image;
                puzzle23.Visible = false;
                puzzle23.Enabled = false;
                pictureBox23.AllowDrop = false;
                count--;
                Update_all();
            }
        }

        private void pictureBox23_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox25_DragDrop(object sender, DragEventArgs e)
        {
            if (curName == "pictureBox25")
            {
                pictureBox25.Image = puzzle25.Image;
                puzzle25.Visible = false;
                puzzle25.Enabled = false;
                pictureBox25.AllowDrop = false;
                count--;
                Update_all();
            }
        }

        private void pictureBox25_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox31_DragDrop(object sender, DragEventArgs e)
        {
            if (curName == "pictureBox31")
            {
                pictureBox31.Image = puzzle31.Image;
                puzzle31.Visible = false;
                puzzle31.Enabled = false;
                pictureBox31.AllowDrop = false;
                count--;
                Update_all();
            }
        }

        private void pictureBox31_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox33_DragDrop(object sender, DragEventArgs e)
        {
            if (curName == "pictureBox33")
            {
                pictureBox33.Image = puzzle33.Image;
                puzzle33.Visible = false;
                puzzle33.Enabled = false;
                pictureBox33.AllowDrop = false;
                count--;
                Update_all();
            }
        }

        private void pictureBox33_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox34_DragDrop(object sender, DragEventArgs e)
        {
            if (curName == "pictureBox34")
            {
                pictureBox34.Image = puzzle34.Image;
                puzzle34.Visible = false;
                puzzle34.Enabled = false;
                pictureBox34.AllowDrop = false;
                count--;
                Update_all();
            }
        }

        private void pictureBox34_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKiller f = new FormKiller(this, "Good job! You’re one step closer to find the treasure!");
            f.Show();
        }
    }
}
