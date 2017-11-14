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
    public partial class Form5 : Form
    {
        int last = 0;
        int from = -1;
        int[] answ = new int[]{ 3, 2, 0, 1, 4 };
        ArrayList boxes; //маленькие изображения
        ArrayList oldBoxes; //основные изображения


        public Form5()
        {
            InitializeComponent();
            boxes = new ArrayList{ new Pair(-1, pictureBox8), new Pair(-1, pictureBox9), new Pair(-1, pictureBox10),
                                        new Pair(-1, pictureBox11), new Pair(-1, pictureBox12)};
            oldBoxes = new ArrayList{ pictureBox2, pictureBox3, pictureBox4,
                                        pictureBox5, pictureBox6};

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            from = 0;
            DoDragDrop(pictureBox2.Image, DragDropEffects.Copy);
            from = -1;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            from = 1;
            DoDragDrop(pictureBox3.Image, DragDropEffects.Copy);
            from = -1;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            from = 2;
            DoDragDrop(pictureBox4.Image, DragDropEffects.Copy);
            from = -1;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            from = 3;
            DoDragDrop(pictureBox5.Image, DragDropEffects.Copy);
            from = -1;
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            from = 4;
            DoDragDrop(pictureBox6.Image, DragDropEffects.Copy);
            from = -1;
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (from == answ[last]) {
                ((PictureBox)oldBoxes[from]).Enabled = false;
                ((PictureBox)oldBoxes[from]).Visible = false;
                ((Pair)boxes[last]).first = from;
                ((Pair)boxes[last]).second.Image = (Image)((PictureBox)oldBoxes[from]).Image.Clone();
                //cur.Append(from);

                last++;
                if (last == 5)
                {
                    pictureBox1.AllowDrop = false;
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(last == 5)
            {
                FormKiller f = new FormKiller(this, "Good job! You’re one step closer to find the treasure!");
                f.Show();
            }
            else if (last == 6)
            {
                MessageBox.Show("You are wrong, try again.");
            }
        }
    }

    public class Pair
    {
        public int first;
        public PictureBox second;

        public Pair(int num, PictureBox p)
        {
            first = num;
            second = p;
        }
    }
}
