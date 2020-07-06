using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace MatchingGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Lvl1_2x2 f = new Lvl1_2x2(0);
                //this.Hide();
                f.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                CustomLevel f = new CustomLevel();
            //this.Hide();
            f.Show();
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                Scores s = new Scores();
            s.Show();
}
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int[] readScoreFile()
        {

            StreamReader readPlayerFile = new StreamReader("scores.txt"); //reading file to list 
            int[] a = new int[5] { 0, 0, 0, 0, 0 };
            int i = 0;
            while (!readPlayerFile.EndOfStream) //reading file till end
            {
                a[i] = int.Parse(readPlayerFile.ReadLine());
                i++;
            }
            readPlayerFile.Close();
            return a;
        }
        public void writeScoreFile(int []a)
        {
            try
            {
                StreamWriter writePlayerFile = new StreamWriter("scores.txt"); //writing the score file
            
            writePlayerFile.WriteLine(a[0]);
            writePlayerFile.WriteLine(a[1]);
            writePlayerFile.WriteLine(a[2]);
            writePlayerFile.WriteLine(a[3]);
            writePlayerFile.WriteLine(a[4]);

            writePlayerFile.Close();
}
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Game Name: MEMORY MATCHING GAME. \n Developer Name: Muhammad Anas Baig. \n University: Bahria University, Islamabad. \n Date Created: 10 December, 2017 12:24 AM", "About");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help:\n 1. Select 'Choose Custom Level' OR 'Start New Game' to start the Game.\n 2. Click on each of the boxes and try to memorize shown pictures. \n 3. Click two same pictures consecutively to make it still. \n 4. Complete all the boxes. \n 5. After each Level you will be moved to next advanced Level.  ", "How To Play");
        }
    }
}
