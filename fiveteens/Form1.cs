using System;
using System.Linq;
using System.Windows.Forms;

namespace fiveteens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] znacheniya = new int[15]; 
        int g;
        Random Random = new Random();
        private void refreshButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15;)
            {
                int check = Random.Next(0, 16);

                if (!znacheniya.Contains(check))
                {
                    znacheniya[i] = check;
                    i++;
                }
            }

            Label[] lables = { label1,  label2,  label3,  label4, label5,  label6,  label7,  label8, label9,  label10, label11, label12, label13, label14, label15, label16,};
            for (int i = 0; i < 15; i++)
            {
                lables[i].Text = Convert.ToString(znacheniya[i]);
            }
            refreshButton.Visible = false;
        }
        private void MouseDown(object sender, MouseEventArgs e)
        {
            Label[] lables = { label1,  label2,  label3,  label4, label5,  label6,  label7,  label8, label9,  label10, label11, label12, label13, label14, label15, label16,};
            Label clickedLabel = (Label)sender;
            g = clickedLabel.TabIndex - 33;
            if (g != 15 && lables[g + 1].Text == "0")
            {
                (lables[g].Text, lables[g + 1].Text) = (lables[g + 1].Text, lables[g].Text);
            }
            else if (g <= 11 && lables[g + 4].Text == "0")
            {
                (lables[g].Text, lables[g + 4].Text) = (lables[g + 4].Text, lables[g].Text);
            }  
            else if (g != 0 && lables[g - 1].Text == "0")
            {
                (lables[g].Text, lables[g - 1].Text) = (lables[g - 1].Text, lables[g].Text);
            } 
            else if (g >= 4 && lables[g - 4].Text == "0")
            {
                (lables[g].Text, lables[g - 4].Text) = (lables[g - 4].Text, lables[g].Text);
            }
            if (lables[0].Text == "1" && lables[1].Text == "2" && lables[2].Text == "3" && lables[3].Text == "4" && lables[4].Text == "5" && lables[5].Text == "6" && lables[6].Text == "7" && lables[7].Text == "8" && lables[8].Text == "9" && lables[9].Text == "10" && lables[10].Text == "11" && lables[11].Text == "12" && lables[12].Text == "13" && lables[13].Text == "14" && lables[14].Text == "15" && lables[15].Text == "0")
            {
                MessageBox.Show("УРААААА!!!!!!!");
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
