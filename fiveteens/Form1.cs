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

        int[] AAA = new int[15]; int da;
        Random Random = new Random();

        private void refreshButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15;)
            {
                int check = Random.Next(0, 16);

                if (!AAA.Contains(check))
                {
                    AAA[i] = check;
                    i++;
                }
            }

            Label[] lables = { label1,  label2,  label3,  label4,
                               label5,  label6,  label7,  label8,
                               label9,  label10, label11, label12,
                               label13, label14, label15, label16,};

            for (int i = 0; i < 15; i++)
                lables[i].Text = Convert.ToString(AAA[i]);

            refreshButton.Visible = false;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            Label[] lables = { label1,  label2,  label3,  label4,
                               label5,  label6,  label7,  label8,
                               label9,  label10, label11, label12,
                               label13, label14, label15, label16,};
            Label clickedLabel = (Label)sender;

            da = clickedLabel.TabIndex - 33;

            if (da != 15 && lables[da + 1].Text == "0")
                (lables[da].Text, lables[da + 1].Text) = (lables[da + 1].Text, lables[da].Text);

            else if (da <= 11 && lables[da + 4].Text == "0")
                (lables[da].Text, lables[da + 4].Text) = (lables[da + 4].Text, lables[da].Text);

            else if (da != 0 && lables[da - 1].Text == "0")
                (lables[da].Text, lables[da - 1].Text) = (lables[da - 1].Text, lables[da].Text);

            else if (da >= 4 && lables[da - 4].Text == "0")
                (lables[da].Text, lables[da - 4].Text) = (lables[da - 4].Text, lables[da].Text);

            if (lables[0].Text == "1" && lables[1].Text == "2" && lables[2].Text == "3" && lables[3].Text == "4" &&
                lables[4].Text == "5" && lables[5].Text == "6" && lables[6].Text == "7" && lables[7].Text == "8" &&
                lables[8].Text == "9" && lables[9].Text == "10" && lables[10].Text == "11" && lables[11].Text == "12" &&
                lables[12].Text == "13" && lables[13].Text == "14" && lables[14].Text == "15" && lables[15].Text == "0")
                MessageBox.Show("Вы победили!");

            if (lables[0].Text == "1" && lables[1].Text == "2" && lables[2].Text == "3" && lables[3].Text == "4" &&
                lables[4].Text == "5" && lables[5].Text == "6" && lables[6].Text == "7" && lables[7].Text == "8" &&
                lables[8].Text == "9" && lables[9].Text == "10" && lables[10].Text == "11" && lables[11].Text == "12" &&
                lables[12].Text == "13" && lables[13].Text == "15" && lables[14].Text == "14" && lables[15].Text == "0")
                this.Text = "Хаха 14 и 15 не на тех местах";
        }
    }
}
