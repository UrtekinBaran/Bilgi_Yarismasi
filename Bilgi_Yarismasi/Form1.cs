namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;    
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            lblSoruno.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet ka� y�l�nda ilan edilmi�tir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Hangisi �ehir Ege b�lgemiz de bulunmaz";
                BtnA.Text = "�zmir";
                BtnB.Text = "Bal�kesir";
                BtnC.Text = "Ayd�n";
                BtnD.Text = "Manisa";
                label4.Text = "Bal�kesir";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Son Ku�lar Hangi yazar�m�za aittir";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal S�reya";
                BtnC.Text = "Attila �lhan";
                BtnD.Text = "Re�at Nuri";
                label4.Text = "Sait Faik";
                BtnSonraki.Text = "Sonu�lar";
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Mustafa Kemal Atat�rk Ka� y�l�nda do�mu�tur?";
                BtnA.Text = "1885";
                BtnB.Text = "1887";
                BtnC.Text = "1881";
                BtnD.Text = "1882";
                label4.Text = "1881";
                BtnSonraki.Text = "Sonu�lar";
            }

            if (soruno == 5)
            {
                richTextBox1.Text = "Microsoft kurucusu Kimdir?";
                BtnA.Text = "Bill Gates";
                BtnB.Text = "Steve Jobs";
                BtnC.Text = "John Deep";
                BtnD.Text = "Leonardio DiCaprio";
                label4.Text = "Bill Gates";
                BtnSonraki.Text = "Sonu�lar";
            }

            if (soruno == 6)
            {
                richTextBox1.Text = "Fenerbah�e'nin efsane 10 numaras� kimdir?";
                BtnA.Text = "Arda G�ler";
                BtnB.Text = "Mesut �zil";
                BtnC.Text = "Diego Ribas";
                BtnD.Text = "Alex de Souza";
                label4.Text = "Alex de Souza";
                BtnSonraki.Text = "Sonu�lar";
            }

            if (soruno == 7)
            {
                richTextBox1.Text = "playstation 5 ka� milyon satm��t�r? (�ubat 2024 Tarihinde Yaz�lm��t�r)";
                BtnA.Text = "70 Milyon";
                BtnB.Text = "30 Milyom";
                BtnC.Text = "50 Milyon";
                BtnD.Text = "40 Milyon";
                label4.Text = "50 Milyon";
                BtnSonraki.Text = "Sonu�lar";
            }

            if (soruno == 8)
            {
                richTextBox1.Text = "Marvel'�n en g��l� k�t� karekteri kimdir";
                BtnA.Text = "Thanos";
                BtnB.Text = "Loki";
                BtnC.Text = "Ultron";
                BtnD.Text = "Red Skull";
                label4.Text = "Thanos";
                BtnSonraki.Text = "Sonu�lar";
            }

            if (soruno == 9)
            {
                richTextBox1.Text = "(5 + 5) * (9 + 1) / 2 = ?";
                BtnA.Text = "40";
                BtnB.Text = "45";
                BtnC.Text = "55";
                BtnD.Text = "50";
                label4.Text = "50";
                BtnSonraki.Text = "Sonu�lar";
            }

            if (soruno == 10)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Do�ru: " + dogru + "\n" + "Yanl��: " + yanlis);
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
