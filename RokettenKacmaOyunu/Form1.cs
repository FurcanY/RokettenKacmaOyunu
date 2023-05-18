using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace RokettenKacmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        // sayac baslad�g� zaman b�ze �slem yapmak �c�n gerkel� deg�skend�r.
        int adimsayisi = 50;
        //roket�n sag sol g�tme h�z�n� etk�leyen deg�sken


        int roketHizi = 1;
        // her t�mer say�ld�g�nda roket kac asag� �necek onu tutan deg�sken


        int skor = 0;

        int skorArtmaSayac = 1;
        // roket�n assag� dusme h�z� artt�kca skorun artma frekans�n� artt�ran deg�skend�r.


        bool oyunBasladi = false;
        //oyun baslad�g� zaman uzay mek�g�n� hareket ett�rmek �c�n kullan�lan bool deg�sken


        int enYuksekSkor = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            //oyunu zaman gect�kce daha zor yapmak �c�n sayac arrt�kca roket�n assag� dusme h�z�n� artt�ran kontrol dongusu
            if (sayac == 1000 || sayac == 2000 || sayac == 3000 || sayac == 4000 || sayac == 5000)
            {
                roketHizi++;
                skorArtmaSayac += 2;
            }

            if (Roket.Bottom <= 470)
            {
                Roket.Top += roketHizi;
            }
            else
            {
                Roket.Top = 0;
                Roket.Left = rastgeleSpawn(12, 426);
                skor += skorArtmaSayac;
                skor_lbl.Text = "Skor : " + skor.ToString();
            }
            // her zaman �slem� oldugunda oyun b�tm�s m� kontrol ed�l�r.
            OyunBittiMi();


        }

        private void UzayMeki�i_Click(object sender, EventArgs e)
        {

        }
        //roket�n uzaymek�g�ne carp�p carpmad�g�n� kontrol eden blok.
        void OyunBittiMi()
        {
            // bounds = s�n�rlar demek.    IntersectsWith(....) = .... �le kesi�ir demek.
            //if blo�unun a��klamas� = uzaymek�g�n�n s�n�rlar� , roketin s�n�rlar� ile kesi�irse:
            if (UzayMeki�i.Bounds.IntersectsWith(Roket.Bounds))
            {
                // uzay mei�inin hareketini k�s�tlamak i�in oyunbaslad� false yap�l�r.
                oyunBasladi = false;
                //temiz bir g�r�nt� i�in roket �arpt��� zaman uzaymeki�i ve roket g�r�nmez yap�l�r.
                UzayMeki�i.Visible = false;
                Roket.Visible = false;



                //oyun b�ter ve t�mer durdurulur.
                timer1.Enabled = false;
                //oyun b�t�m� panel� gozukur olur.
                Kaybetme_pnl.Visible = true;

                //program baslad�g�ndan bu yana en yuksek skoru hesaplamak �c�n yap�lan kontrol �slem�.
                if (skor > enYuksekSkor)
                {
                    enYuksekSkor = skor;
                }
                suank�skor_lbl.Text = "�uanki Skorun : " + skor.ToString();
                eny�ksekskor_lbl.Text = "En Y�ksek Skor : " + enYuksekSkor.ToString();


                sag_btn.Enabled = false;
                sag_btn.BackColor = Color.Gray;
                sol_btn.Enabled = false;
                sol_btn.BackColor = Color.Gray;


            }
        }

        int rastgeleSpawn(int altAralik, int ustAralik)
        {
            int sonuc = 0;
            Random rnd = new Random();
            sonuc = rnd.Next(altAralik, ustAralik + 1);
            return sonuc;

        }


        private void basla_btn_Click(object sender, EventArgs e)
        {
            Roket.Visible = true;
            oyunBasladi = true;
            timer1.Start();
            basla_btn.Visible = false;
            sag_btn.Enabled = true;
            sag_btn.BackColor = Color.Green;
            sol_btn.Enabled = true;
            sol_btn.BackColor = Color.Green;
            OyunAd�_lbl.Visible = false;

        }

        private void sol_btn_Click(object sender, EventArgs e)
        {
            //uzay mek�g�n aral�g� 0 461 bu aral�g� gecmemes� laz�m. ��nk� formun uzunlugu bu kadard�r.
            if (UzayMeki�i.Left - adimsayisi > 0)
            {
                UzayMeki�i.Left -= adimsayisi;

            }
        }

        private void sag_btn_Click(object sender, EventArgs e)
        {
            //uzay mek�g�n aral�g� 0 461 bu aral�g� gecmemes� laz�m. ��nk� formun uzunlugu bu kadard�r.

            if (UzayMeki�i.Right + adimsayisi - 39 < 461)
            {
                UzayMeki�i.Left += adimsayisi;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            // A D tusuna basarak da oyun oynanab�l�r yapan kod blogu keydown �c�nde yaz�l�r.
            //sizde keydown eventin kullanmak istiyorsan�z Formun KeyPreview �zelli�ini true yapmay� unutmay�n�z.


            if (oyunBasladi)
            {
                //sola g�tmek �c�n
                if (e.KeyCode == Keys.A)
                {

                    if (UzayMeki�i.Left - adimsayisi > 0)
                    {
                        UzayMeki�i.Left += -adimsayisi;

                    }
                }

                // saga g�tmek �c�n
                if (e.KeyCode == Keys.D)
                {

                    if (UzayMeki�i.Right + adimsayisi - 39 < 461)
                    {
                        UzayMeki�i.Left += adimsayisi;
                    }
                }

            }
        }

        private void tekraroyna_btn_Click(object sender, EventArgs e)
        {

            // her seyi oyun baslad�g� zamanki gibi yapilir
            skorArtmaSayac = 1;
            oyunBasladi = false;
            skor = 0;
            roketHizi = 1;
            sayac = 0;
            skor_lbl.Text = "Skor : " + skor.ToString();
            Kaybetme_pnl.Visible = false;
            basla_btn.Visible = true;

            OyunAd�_lbl.Visible = true;
            UzayMeki�i.Visible = true;
            UzayMeki�i.Location = new Point(160, 337);
            Roket.Top = 0;
            Roket.Left = rastgeleSpawn(12, 426);


        }


        //bilgi yazan label uzer�ne geld�g� zaman �cer�g�n� deg�st�rmek �c�n yaz�lan kodlar.
        private void bilgi_lbl_MouseHover(object sender, EventArgs e)
        {
            bilgi_lbl.Text = "Oyun A ve D tu�lar� ile de oynanabilir. �yi Oyunlar.\n GitHub Takip Etmeyi Unutmay�n !";
            bilgi_lbl.BackColor = Color.Black;
            bilgi_lbl.ForeColor = Color.Red;
        }

        private void bilgi_lbl_MouseLeave(object sender, EventArgs e)
        {
            bilgi_lbl.Text = "Bilgi !";
            bilgi_lbl.BackColor = Color.Transparent;
            bilgi_lbl.ForeColor = Color.Black;
        }

        private void Roket_Click(object sender, EventArgs e)
        {

        }
    }
}