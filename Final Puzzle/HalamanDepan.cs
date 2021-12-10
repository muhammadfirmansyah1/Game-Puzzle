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
    public partial class HalamanDepan : Form
    {
        public HalamanDepan()
        {
            InitializeComponent();
        }

    

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            BUMI ss = new BUMI();
            ss.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            VENUS aa = new VENUS();
            aa.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            YUPITER bb = new YUPITER();
            bb.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            URANUS kk = new URANUS();
            kk.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            MERKURIUS k = new MERKURIUS();
            k.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            this.Hide();
            MARS ko = new MARS();
            ko.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            SATURNUS kai = new SATURNUS();
            kai.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            NEPTUNUS ok = new NEPTUNUS();
            ok.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
