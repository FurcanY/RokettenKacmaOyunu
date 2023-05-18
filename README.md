# :collision: RokettenKacmaOyunu :sparkles: :dizzy:


## Bu projemde bir uzay mekiği üstten gelen roketten kaçmaya çalışıyor. :alien:  
![Oyun İçi Görüntü](https://media.giphy.com/media/v1.Y2lkPTc5MGI3NjExYWU0YzAwOTVlYmYwZTAwNWMxOTYzY2FjNDU4OTk0YTgyNTIwMGU4YSZlcD12MV9pbnRlcm5hbF9naWZzX2dpZklkJmN0PWc/DzvTwK5VrbzPrEFxNN/giphy.gif)


### Bu projeyi yapmamdaki nedenlerim:
#### :point_right: Timer'ı projelerde etkili kullanmayı öğrenmek.
#### :point_right: Projelerde bazı nesnelere fizik işlemleri uygulamayı öğrenmek
#### :point_right: İki nesnenin kesişmesi olayını öğrenmek
#### :point_right: Kodlama becerilerimi oyun yapma alanında daha üst seviyeye taşımak.

## Proje içinden Örnek Kodlar 💾


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
            OyunAdı_lbl.Visible = false;

        }

        private void sol_btn_Click(object sender, EventArgs e)
        {
            //uzay mekıgın aralıgı 0 461 bu aralıgı gecmemesı lazım. çünkü formun uzunlugu bu kadardır.
            if (UzayMekiği.Left - adimsayisi > 0)
            {
                UzayMekiği.Left -= adimsayisi;

            }
        }

        private void sag_btn_Click(object sender, EventArgs e)
        {
            //uzay mekıgın aralıgı 0 461 bu aralıgı gecmemesı lazım. çünkü formun uzunlugu bu kadardır.

            if (UzayMekiği.Right + adimsayisi - 39 < 461)
            {
                UzayMekiği.Left += adimsayisi;
            }
        }
        
        
   ## ✴️ Belki Bakarsın Diye Bırakıyorum ✴️
   ####  GitHub adresime [buradan](https://github.com/FurcanY) ulaşabilirsiniz.
   ####  İnstagram adresime [buradan](https://www.instagram.com/y.furcan/) ulaşabilirsiniz.
   ####  Youtube adresime [buradan](https://www.youtube.com/channel/UCQRXjt0lg2jCnp2NqOAO2Ig) ulaşabilirsiniz.
   
