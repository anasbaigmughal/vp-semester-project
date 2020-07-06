using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class CustomLevel : Form
    {
        public CustomLevel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lvl1_2x2 f = new Lvl1_2x2(0);
            //this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lvl2_4x4 f = new Lvl2_4x4(0);
            //this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lvl3_6x6 f = new Lvl3_6x6(0);
            //this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lvl4_8x8 f = new Lvl4_8x8(0);
            //this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lvl5_10x10 f = new Lvl5_10x10(0);
            //this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
