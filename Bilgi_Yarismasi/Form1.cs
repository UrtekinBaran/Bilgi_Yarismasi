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
                richTextBox1.Text = "Cumhuriyet kaç yýlýnda ilan edilmiþtir?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Hangisi þehir Ege bölgemiz de bulunmaz";
                BtnA.Text = "Ýzmir";
                BtnB.Text = "Balýkesir";
                BtnC.Text = "Aydýn";
                BtnD.Text = "Manisa";
                label4.Text = "Balýkesir";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuþlar Hangi yazarýmýza aittir";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreya";
                BtnC.Text = "Attila Ýlhan";
                BtnD.Text = "Reþat Nuri";
                label4.Text = "Sait Faik";
                BtnSonraki.Text = "Sonuçlar";
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Mustafa Kemal Atatürk Kaç yýlýnda doðmuþtur?";
                BtnA.Text = "1885";
                BtnB.Text = "1887";
                BtnC.Text = "1881";
                BtnD.Text = "1882";
                label4.Text = "1881";
                BtnSonraki.Text = "Sonuçlar";
            }

            if (soruno == 5)
            {
                richTextBox1.Text = "Microsoft kurucusu Kimdir?";
                BtnA.Text = "Bill Gates";
                BtnB.Text = "Steve Jobs";
                BtnC.Text = "John Deep";
                BtnD.Text = "Leonardio DiCaprio";
                label4.Text = "Bill Gates";
                BtnSonraki.Text = "Sonuçlar";
            }

            if (soruno == 6)
            {
                richTextBox1.Text = "Fenerbahçe'nin efsane 10 numarasý kimdir?";
                BtnA.Text = "Arda Güler";
                BtnB.Text = "Mesut Özil";
                BtnC.Text = "Diego Ribas";
                BtnD.Text = "Alex de Souza";
                label4.Text = "Alex de Souza";
                BtnSonraki.Text = "Sonuçlar";
            }

            if (soruno == 7)
            {
                richTextBox1.Text = "playstation 5 kaç milyon satmýþtýr? (Þubat 2024 Tarihinde Yazýlmýþtýr)";
                BtnA.Text = "70 Milyon";
                BtnB.Text = "30 Milyom";
                BtnC.Text = "50 Milyon";
                BtnD.Text = "40 Milyon";
                label4.Text = "50 Milyon";
                BtnSonraki.Text = "Sonuçlar";
            }

            if (soruno == 8)
            {
                richTextBox1.Text = "Marvel'ýn en güçlü kötü karekteri kimdir";
                BtnA.Text = "Thanos";
                BtnB.Text = "Loki";
                BtnC.Text = "Ultron";
                BtnD.Text = "Red Skull";
                label4.Text = "Thanos";
                BtnSonraki.Text = "Sonuçlar";
            }

            if (soruno == 9)
            {
                richTextBox1.Text = "(5 + 5) * (9 + 1) / 2 = ?";
                BtnA.Text = "40";
                BtnB.Text = "45";
                BtnC.Text = "55";
                BtnD.Text = "50";
                label4.Text = "50";
                BtnSonraki.Text = "Sonuçlar";
            }

            if (soruno == 10)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doðru: " + dogru + "\n" + "Yanlýþ: " + yanlis);
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
