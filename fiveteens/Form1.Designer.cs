using System.Drawing;
using System.Windows.Forms;

namespace fiveteens
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(145, 290);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(64, 35);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 67);
            this.label1.TabIndex = 33;
            this.label1.Text = "1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label2.Location = new System.Drawing.Point(96, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 67);
            this.label2.TabIndex = 34;
            this.label2.Text = "2";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label3.Location = new System.Drawing.Point(182, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 67);
            this.label3.TabIndex = 35;
            this.label3.Text = "3";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label4.Location = new System.Drawing.Point(268, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 67);
            this.label4.TabIndex = 36;
            this.label4.Text = "4";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label5.Location = new System.Drawing.Point(10, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 67);
            this.label5.TabIndex = 37;
            this.label5.Text = "5";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label6.Location = new System.Drawing.Point(96, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 67);
            this.label6.TabIndex = 38;
            this.label6.Text = "6";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label7.Location = new System.Drawing.Point(182, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 67);
            this.label7.TabIndex = 39;
            this.label7.Text = "7";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label8.Location = new System.Drawing.Point(268, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 67);
            this.label8.TabIndex = 40;
            this.label8.Text = "8";
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label9.Location = new System.Drawing.Point(10, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 67);
            this.label9.TabIndex = 41;
            this.label9.Text = "9";
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label10.Location = new System.Drawing.Point(96, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 67);
            this.label10.TabIndex = 42;
            this.label10.Text = "10";
            this.label10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label11.Location = new System.Drawing.Point(182, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 67);
            this.label11.TabIndex = 43;
            this.label11.Text = "11";
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label12.Location = new System.Drawing.Point(268, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 67);
            this.label12.TabIndex = 44;
            this.label12.Text = "12";
            this.label12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label13.Location = new System.Drawing.Point(10, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 67);
            this.label13.TabIndex = 45;
            this.label13.Text = "13";
            this.label13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label14.Location = new System.Drawing.Point(96, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 67);
            this.label14.TabIndex = 46;
            this.label14.Text = "14";
            this.label14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label15.Location = new System.Drawing.Point(182, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 67);
            this.label15.TabIndex = 47;
            this.label15.Text = "15";
            this.label15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label16.Location = new System.Drawing.Point(268, 220);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 67);
            this.label16.TabIndex = 48;
            this.label16.Text = "0";
            this.label16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(350, 336);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пятнашки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button refreshButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
    }
}