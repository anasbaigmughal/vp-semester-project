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
    public partial class Scores : Form
    {
        public Scores()
        {
            InitializeComponent();
        }

        private void Scores_Load(object sender, EventArgs e)
        {
            Menu m = new Menu();
            int [] a = m.readScoreFile();
            label1.Text = "1. " + a[0].ToString();
            label2.Text = "2. " + a[1].ToString();
            label3.Text = "3. " + a[2].ToString();
            label4.Text = "4. " + a[3].ToString();
            label5.Text = "5. " + a[4].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
