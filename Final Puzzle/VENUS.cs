using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Puzzle
{
    public partial class VENUS : Form
    {
        public VENUS()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox1.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox1.Image = Properties.Resources._0000;
                pictureBox1.BackColor = Color.White;
            }
            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox1.Image;
                pictureBox4.BackColor = Color.Gray;
                pictureBox1.Image = Properties.Resources._0000;
                pictureBox1.BackColor = Color.White;
            }
        }

        private void VENUS_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Gray;
            pictureBox2.BackColor = Color.Gray;
            pictureBox3.BackColor = Color.Gray;
            pictureBox4.BackColor = Color.Gray;
            pictureBox5.BackColor = Color.Gray;
            pictureBox6.BackColor = Color.Gray;
            pictureBox7.BackColor = Color.Gray;
            pictureBox8.BackColor = Color.Gray;
            pictureBox9.BackColor = Color.Gray;
            pictureBox10.BackColor = Color.Gray;
            pictureBox11.BackColor = Color.Gray;
            pictureBox12.BackColor = Color.White;
            pictureBox13.BackColor = Color.Red;

            pictureBox13.Image = Properties.Resources.Venus;
            pictureBox1.Image = Properties.Resources.v7;
            pictureBox2.Image = Properties.Resources.v2;
            pictureBox3.Image = Properties.Resources.v10;
            pictureBox4.Image = Properties.Resources.v11;
            pictureBox5.Image = Properties.Resources.v4;
            pictureBox6.Image = Properties.Resources.v6;
            pictureBox7.Image = Properties.Resources.v3;
            pictureBox8.Image = Properties.Resources.v1;
            pictureBox9.Image = Properties.Resources.v5;
            pictureBox10.Image = Properties.Resources.v8;
            pictureBox11.Image = Properties.Resources.v9;
            pictureBox12.Image = Properties.Resources._0000;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.White)
            {
                pictureBox1.Image = pictureBox2.Image;
                pictureBox1.BackColor = Color.Gray;
                pictureBox2.Image = Properties.Resources._0000;
                pictureBox2.BackColor = Color.White;
            }
            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.Image = pictureBox2.Image;
                pictureBox3.BackColor = Color.Gray;
                pictureBox2.Image = Properties.Resources._0000;
                pictureBox2.BackColor = Color.White;
            }
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox2.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox2.Image = Properties.Resources._0000;
                pictureBox2.BackColor = Color.White;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox3.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox3.Image = Properties.Resources._0000;
                pictureBox3.BackColor = Color.White;
            }
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox3.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox3.Image = Properties.Resources._0000;
                pictureBox3.BackColor = Color.White;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.White)
            {
                pictureBox1.Image = pictureBox4.Image;
                pictureBox1.BackColor = Color.Gray;
                pictureBox4.Image = Properties.Resources._0000;
                pictureBox4.BackColor = Color.White;
            }
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox4.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox4.Image = Properties.Resources._0000;
                pictureBox4.BackColor = Color.White;
            }
            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox4.Image;
                pictureBox7.BackColor = Color.Gray;
                pictureBox4.Image = Properties.Resources._0000;
                pictureBox4.BackColor = Color.White;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.White)
            {
                pictureBox2.Image = pictureBox5.Image;
                pictureBox2.BackColor = Color.Gray;
                pictureBox5.Image = Properties.Resources._0000;
                pictureBox5.BackColor = Color.White;
            }
            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox5.Image;
                pictureBox4.BackColor = Color.Gray;
                pictureBox5.Image = Properties.Resources._0000;
                pictureBox5.BackColor = Color.White;
            }
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox5.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox5.Image = Properties.Resources._0000;
                pictureBox5.BackColor = Color.White;
            }
            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox5.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox5.Image = Properties.Resources._0000;
                pictureBox5.BackColor = Color.White;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BackColor == Color.White)
            {
                pictureBox3.Image = pictureBox6.Image;
                pictureBox3.BackColor = Color.Gray;
                pictureBox6.Image = Properties.Resources._0000;
                pictureBox6.BackColor = Color.White;
            }
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox6.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox6.Image = Properties.Resources._0000;
                pictureBox6.BackColor = Color.White;
            }
            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.Image = pictureBox6.Image;
                pictureBox9.BackColor = Color.Gray;
                pictureBox6.Image = Properties.Resources._0000;
                pictureBox6.BackColor = Color.White;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox4.BackColor == Color.White)
            {
                pictureBox4.Image = pictureBox7.Image;
                pictureBox4.BackColor = Color.Gray;
                pictureBox7.Image = Properties.Resources._0000;
                pictureBox7.BackColor = Color.White;
            }
            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox7.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox7.Image = Properties.Resources._0000;
                pictureBox7.BackColor = Color.White;
            }
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.Image = pictureBox7.Image;
                pictureBox10.BackColor = Color.Gray;
                pictureBox7.Image = Properties.Resources._0000;
                pictureBox7.BackColor = Color.White;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox5.BackColor == Color.White)
            {
                pictureBox5.Image = pictureBox8.Image;
                pictureBox5.BackColor = Color.Gray;
                pictureBox8.Image = Properties.Resources._0000;
                pictureBox8.BackColor = Color.White;
            }
            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox8.Image;
                pictureBox7.BackColor = Color.Gray;
                pictureBox8.Image = Properties.Resources._0000;
                pictureBox8.BackColor = Color.White;
            }
            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.Image = pictureBox8.Image;
                pictureBox9.BackColor = Color.Gray;
                pictureBox8.Image = Properties.Resources._0000;
                pictureBox8.BackColor = Color.White;
            }
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.Image = pictureBox8.Image;
                pictureBox11.BackColor = Color.Gray;
                pictureBox8.Image = Properties.Resources._0000;
                pictureBox8.BackColor = Color.White;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox6.BackColor == Color.White)
            {
                pictureBox6.Image = pictureBox9.Image;
                pictureBox6.BackColor = Color.Gray;
                pictureBox9.Image = Properties.Resources._0000;
                pictureBox9.BackColor = Color.White;
            }
            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox9.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox9.Image = Properties.Resources._0000;
                pictureBox9.BackColor = Color.White;
            }
            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.Image = pictureBox9.Image;
                pictureBox12.BackColor = Color.Gray;
                pictureBox9.Image = Properties.Resources._0000;
                pictureBox9.BackColor = Color.White;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            if (pictureBox7.BackColor == Color.White)
            {
                pictureBox7.Image = pictureBox10.Image;
                pictureBox7.BackColor = Color.Gray;
                pictureBox10.Image = Properties.Resources._0000;
                pictureBox10.BackColor = Color.White;
            }
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.Image = pictureBox10.Image;
                pictureBox11.BackColor = Color.Gray;
                pictureBox10.Image = Properties.Resources._0000;
                pictureBox10.BackColor = Color.White;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox8.BackColor == Color.White)
            {
                pictureBox8.Image = pictureBox11.Image;
                pictureBox8.BackColor = Color.Gray;
                pictureBox11.Image = Properties.Resources._0000;
                pictureBox11.BackColor = Color.White;
            }
            if (pictureBox10.BackColor == Color.White)
            {
                pictureBox10.Image = pictureBox11.Image;
                pictureBox10.BackColor = Color.Gray;
                pictureBox11.Image = Properties.Resources._0000;
                pictureBox11.BackColor = Color.White;
            }
            if (pictureBox12.BackColor == Color.White)
            {
                pictureBox12.Image = pictureBox11.Image;
                pictureBox12.BackColor = Color.Gray;
                pictureBox11.Image = Properties.Resources._0000;
                pictureBox11.BackColor = Color.White;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox9.BackColor == Color.White)
            {
                pictureBox9.Image = pictureBox12.Image;
                pictureBox9.BackColor = Color.Gray;
                pictureBox12.Image = Properties.Resources._0000;
                pictureBox12.BackColor = Color.White;
            }
            if (pictureBox11.BackColor == Color.White)
            {
                pictureBox11.Image = pictureBox12.Image;
                pictureBox11.BackColor = Color.Gray;
                pictureBox12.Image = Properties.Resources._0000;
                pictureBox12.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info info = new Info("venus");
            info.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HalamanDepan oppo = new HalamanDepan();
            oppo.Show();
        }
    }
}
