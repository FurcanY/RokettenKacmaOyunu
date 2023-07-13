# :collision: RokettenKacmaOyunu :sparkles: :dizzy:


## Bu projemde bir uzay mekiği üstten gelen roketten kaçmaya çalışıyor. :anger:


![Alt Text](https://media.giphy.com/media/DzvTwK5VrbzPrEFxNN/giphy.gif)


### Bu projeyi yapmamdaki nedenlerim:
#### :point_right: Timer'i proje icerisinde etkili bir sekilde kullanmak
#### :point_right: Daha etkili bir sekilde C# kullanak.
#### :point_right: Nesneler arasi etkilesimi kullanmak.
#### :point_right: Proje icerisinde nesnelerin ozelliklerini zaman icerisinde degistirmeyi ogrenmek.

## Proje İçinden Örnek Kodlar 💾

## 1
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

        
        
   ## ✴️ Belki Bakarsın Diye Bırakıyorum ✴️
   ####  GitHub adresime [buradan](https://github.com/FurcanY) ulaşabilirsiniz.
   ####  İnstagram adresime [buradan](https://www.instagram.com/y.furcan/) ulaşabilirsiniz.
   ####  Youtube adresime [buradan](https://www.youtube.com/channel/UCQRXjt0lg2jCnp2NqOAO2Ig) ulaşabilirsiniz.
   
