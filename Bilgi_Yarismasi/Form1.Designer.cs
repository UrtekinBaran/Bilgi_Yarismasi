namespace Bilgi_Yarismasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            richTextBox1 = new RichTextBox();
            BtnA = new Button();
            BtnB = new Button();
            BtnC = new Button();
            BtnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblSoruno = new Label();
            lblDogru = new Label();
            lblYanlis = new Label();
            BtnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1, 1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(449, 261);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BtnA
            // 
            BtnA.BackColor = Color.Cyan;
            BtnA.Location = new Point(2, 268);
            BtnA.Name = "BtnA";
            BtnA.Size = new Size(225, 39);
            BtnA.TabIndex = 1;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = false;
            BtnA.Click += BtnA_Click;
            // 
            // BtnB
            // 
            BtnB.BackColor = Color.Cyan;
            BtnB.Location = new Point(225, 268);
            BtnB.Name = "BtnB";
            BtnB.Size = new Size(225, 39);
            BtnB.TabIndex = 2;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = false;
            BtnB.Click += BtnB_Click;
            // 
            // BtnC
            // 
            BtnC.BackColor = Color.Cyan;
            BtnC.Location = new Point(2, 313);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(225, 39);
            BtnC.TabIndex = 4;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = false;
            BtnC.Click += BtnC_Click;
            // 
            // BtnD
            // 
            BtnD.BackColor = Color.Cyan;
            BtnD.Location = new Point(225, 313);
            BtnD.Name = "BtnD";
            BtnD.Size = new Size(225, 39);
            BtnD.TabIndex = 3;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = false;
            BtnD.Click += BtnD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 61);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(497, 109);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 6;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(497, 161);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 7;
            label3.Text = "Yanlış:";
            // 
            // lblSoruno
            // 
            lblSoruno.AutoSize = true;
            lblSoruno.Location = new Point(582, 61);
            lblSoruno.Name = "lblSoruno";
            lblSoruno.Size = new Size(24, 28);
            lblSoruno.TabIndex = 8;
            lblSoruno.Text = "0";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(582, 109);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(24, 28);
            lblDogru.TabIndex = 9;
            lblDogru.Text = "0";
            // 
            // lblYanlis
            // 
            lblYanlis.AutoSize = true;
            lblYanlis.Location = new Point(582, 161);
            lblYanlis.Name = "lblYanlis";
            lblYanlis.Size = new Size(24, 28);
            lblYanlis.TabIndex = 10;
            lblYanlis.Text = "0";
            // 
            // BtnSonraki
            // 
            BtnSonraki.BackColor = Color.FromArgb(255, 192, 128);
            BtnSonraki.Location = new Point(465, 207);
            BtnSonraki.Name = "BtnSonraki";
            BtnSonraki.Size = new Size(217, 39);
            BtnSonraki.TabIndex = 11;
            BtnSonraki.Text = "Sonraki";
            BtnSonraki.UseVisualStyleBackColor = false;
            BtnSonraki.Click += BtnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.green;
            pictureBox1.Location = new Point(465, 268);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.red;
            pictureBox2.Location = new Point(580, 268);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 397);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 397);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(695, 356);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnSonraki);
            Controls.Add(lblYanlis);
            Controls.Add(lblDogru);
            Controls.Add(lblSoruno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnC);
            Controls.Add(BtnD);
            Controls.Add(BtnB);
            Controls.Add(BtnA);
            Controls.Add(richTextBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Bilgi Yarismasi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtnA;
        private Button BtnB;
        private Button BtnC;
        private Button BtnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSoruno;
        private Label lblDogru;
        private Label lblYanlis;
        private Button BtnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}
