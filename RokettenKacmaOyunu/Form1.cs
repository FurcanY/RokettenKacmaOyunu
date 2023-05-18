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
        // sayac basladýgý zaman býze ýslem yapmak ýcýn gerkelý degýskendýr.
        int adimsayisi = 50;
        //roketýn sag sol gýtme hýzýný etkýleyen degýsken


        int roketHizi = 1;
        // her týmer sayýldýgýnda roket kac asagý ýnecek onu tutan degýsken


        int skor = 0;

        int skorArtmaSayac = 1;
        // roketýn assagý dusme hýzý arttýkca skorun artma frekansýný arttýran degýskendýr.


        bool oyunBasladi = false;
        //oyun basladýgý zaman uzay mekýgýný hareket ettýrmek ýcýn kullanýlan bool degýsken


        int enYuksekSkor = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            //oyunu zaman gectýkce daha zor yapmak ýcýn sayac arrtýkca roketýn assagý dusme hýzýný arttýran kontrol dongusu
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
            // her zaman ýslemý oldugunda oyun býtmýs mý kontrol edýlýr.
            OyunBittiMi();


        }

        private void UzayMekiði_Click(object sender, EventArgs e)
        {

        }
        //roketýn uzaymekýgýne carpýp carpmadýgýný kontrol eden blok.
        void OyunBittiMi()
        {
            // bounds = sýnýrlar demek.    IntersectsWith(....) = .... ýle kesiþir demek.
            //if bloðunun açýklamasý = uzaymekýgýnýn sýnýrlarý , roketin sýnýrlarý ile kesiþirse:
            if (UzayMekiði.Bounds.IntersectsWith(Roket.Bounds))
            {
                // uzay meiðinin hareketini kýsýtlamak için oyunbasladý false yapýlýr.
                oyunBasladi = false;
                //temiz bir görüntü için roket çarptýðý zaman uzaymekiði ve roket görünmez yapýlýr.
                UzayMekiði.Visible = false;
                Roket.Visible = false;



                //oyun býter ve týmer durdurulur.
                timer1.Enabled = false;
                //oyun býtýmý panelý gozukur olur.
                Kaybetme_pnl.Visible = true;

                //program basladýgýndan bu yana en yuksek skoru hesaplamak ýcýn yapýlan kontrol ýslemý.
                if (skor > enYuksekSkor)
                {
                    enYuksekSkor = skor;
                }
                suankýskor_lbl.Text = "Þuanki Skorun : " + skor.ToString();
                enyüksekskor_lbl.Text = "En Yüksek Skor : " + enYuksekSkor.ToString();


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
            OyunAdý_lbl.Visible = false;

        }

        private void sol_btn_Click(object sender, EventArgs e)
        {
            //uzay mekýgýn aralýgý 0 461 bu aralýgý gecmemesý lazým. çünkü formun uzunlugu bu kadardýr.
            if (UzayMekiði.Left - adimsayisi > 0)
            {
                UzayMekiði.Left -= adimsayisi;

            }
        }

        private void sag_btn_Click(object sender, EventArgs e)
        {
            //uzay mekýgýn aralýgý 0 461 bu aralýgý gecmemesý lazým. çünkü formun uzunlugu bu kadardýr.

            if (UzayMekiði.Right + adimsayisi - 39 < 461)
            {
                UzayMekiði.Left += adimsayisi;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            // A D tusuna basarak da oyun oynanabýlýr yapan kod blogu keydown ýcýnde yazýlýr.
            //sizde keydown eventin kullanmak istiyorsanýz Formun KeyPreview özelliðini true yapmayý unutmayýnýz.


            if (oyunBasladi)
            {
                //sola gýtmek ýcýn
                if (e.KeyCode == Keys.A)
                {

                    if (UzayMekiði.Left - adimsayisi > 0)
                    {
                        UzayMekiði.Left += -adimsayisi;

                    }
                }

                // saga gýtmek ýcýn
                if (e.KeyCode == Keys.D)
                {

                    if (UzayMekiði.Right + adimsayisi - 39 < 461)
                    {
                        UzayMekiði.Left += adimsayisi;
                    }
                }

            }
        }

        private void tekraroyna_btn_Click(object sender, EventArgs e)
        {

            // her seyi oyun basladýgý zamanki gibi yapilir
            skorArtmaSayac = 1;
            oyunBasladi = false;
            skor = 0;
            roketHizi = 1;
            sayac = 0;
            skor_lbl.Text = "Skor : " + skor.ToString();
            Kaybetme_pnl.Visible = false;
            basla_btn.Visible = true;

            OyunAdý_lbl.Visible = true;
            UzayMekiði.Visible = true;
            UzayMekiði.Location = new Point(160, 337);
            Roket.Top = 0;
            Roket.Left = rastgeleSpawn(12, 426);


        }


        //bilgi yazan label uzerýne geldýgý zaman ýcerýgýný degýstýrmek ýcýn yazýlan kodlar.
        private void bilgi_lbl_MouseHover(object sender, EventArgs e)
        {
            bilgi_lbl.Text = "Oyun A ve D tuþlarý ile de oynanabilir. Ýyi Oyunlar.\n GitHub Takip Etmeyi Unutmayýn !";
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