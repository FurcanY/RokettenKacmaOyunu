# :collision: RokettenKacmaOyunu :sparkles: :dizzy:


## Bu projemde bir uzay mekiği üstten gelen roketten kaçmaya çalışıyor. :anger:





### Bu projeyi yapmamdaki nedenlerim:
#### :point_right: Unity oyun motoruna hakim olmak.
#### :point_right: PlayerPrefs Kullanarak veri kaydetmek.
#### :point_right: Shop sistemi ile secilen nesnenin kullanilmasini saglamak.
#### :point_right: Unity daha optimize bir sekilde kod yazmak

## Proje İçinden Örnek Kodlar 💾

## 1
      private void Awake()
    {
        Para_Text = GameObject.Find("Para_Text").GetComponent<TMP_Text>();
        ayar = GameObject.Find("Ayar_Gameobject").GetComponent<Ayarlar_Script>();
        ItemButtons = new Button[Items.Length];
        priceTexts = new TMP_Text[Items.Length];
        ItemLockImage = new Image[Items.Length];
        for (int i = 0; i < Items.Length; i++) 
        {
            if (Items[i] == null)
            {
                Debug.Log("Nasi null la public, ordan attim" + Items[i]);

            }
            ItemButtons[i] = Items[i].transform.GetChild(1).GetComponent<Button>();
            ItemButtons[i].enabled = false;
            priceTexts[i] = ItemButtons[i].transform.GetChild(0).GetComponent<TMP_Text>();
            ItemLockImage[i] = Items[i].transform.GetChild(2).GetComponent<Image>();
        }
    }
    void Start()
    {
        Para_Text.text = "Para: " + ayar.ParaGoster();
        Index = ayar.IndexAl();
        acilanIndex = ayar.AcilanIndexAl();
        acilanIndex = ayar.AcilanIndexAl();
        for (int i = 0; i < Items.Length; i++)
        {
            priceTexts[i].text = ItemPrices[i].ToString();
        }
        UIGuncelle();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void satinAl(int index)
    {
        if(priceTexts[index].text == yazilar[0])
        {
            Index = index;
            ayar.IndexDegistir(index);
            Debug.Log("Item secildi" + Index);
        }
        if (ItemPrices[index] <= ayar.ParaGoster() && (priceTexts[index].text != yazilar[0] && priceTexts[index].text != yazilar[1]))
        {
            Debug.Log(priceTexts[index].text);
            Debug.Log(yazilar[0]);
            Debug.Log(yazilar[1]);

            acilanIndex = index;
            ayar.AcilanIndexDegistir(acilanIndex);
            ayar.ParaArttir(-ItemPrices[index]);
            Debug.Log("Satin Alim Gerceklesti.");
            Para_Text.text = "Para: " + ayar.ParaGoster();
        }
        UIGuncelle();
    }



## 2
    void Update()
    {
        

        if (daire.transform.childCount!=0)
        {
            OynaText.SetActive(false);
            //oynamak icin space veya sol mouse basin texti oyun dairesine bir veya daha fazla cubuk(veya ok ne derseniz) child'i olursa kapattik
        }


        //yandiMi ok.script icinde public static bir degiskendir.
        //bu if icerisine girer ise bolumu gecmis oluyoruz
        if (daire.transform.childCount == score && SonrakiBolum_Button.activeSelf == false && OkScript.yandiMi == false)
        {
            //sonraki bolume gecer.
            Debug.Log("Bolum Gecildi" + score);
            ayar.ParaArttir(score);
            //paramiz o bolumun scoreu kadar artar
            Para_Text.text = "Para: " + ayar.ParaGoster().ToString();
            //para degisikligini UI'da gosteririz

            //en iyi score suanki scoredan az ise suanki score'i en iyi score yaptik
            if (ayar.EnIyiScoreGetir() < score)
            {
                ayar.EnIyiScoreDegistir();
            }
            ayar.ScoreArttir();
            //sonraki bolum suanki bolumden bir fazla score olacagindan score arttirildi
            SonrakiBolum_Button.SetActive(true);
        }
        //bu if icerisinde atis islemi yapilir
        //score-1 != daire.transform.childCount --- bu kodun icerisindeki -1 in mantigi oyun ilk baslarken start() icerisinde bir kere ates yapildigi icin koyulmustur.
        if ((Input.GetKeyDown(KeyCode.Space)||Input.GetMouseButtonDown(0))&& score-1 != daire.transform.childCount && SonrakiBolum_Button.activeSelf==false && OkScript.yandiMi==false && atisBekleme==false)
        {
           
            StartCoroutine(AtisBekleme(0.05f));
            //eger scorun 0.6 i tamamlanmissa bu if icerisine giriyor
            if (score / 1.5f < daire.transform.childCount)
            {
                
                daireRotate = (int)Mathf.Pow(-1, daire.transform.childCount + 1);
                //ornek  Mathf.Pow(-1, 5 + 1) -1^6=1 cikar yani donus acisi pozitif
                //oyunda donen dairenin donus acisini her space basildiginda veya mosue0 a tiklandiginda degistiren kod parcasi
                
                
            }


        }
        daire.transform.Rotate(daireRotate * daireRotateSpeed * Time.deltaTime * Vector3.forward);
        //dairenin oyunun basindan bu yana donmesini saglayan kod
        ScoreText.text = (score-daire.transform.childCount).ToString();
        //her zmana score textini guncellyoruz (score-dairenin icindeki cubuk sayisi )(ornek--> score=10 daire icinde de 5 tane cubuk olsun. textde 5 yazar yani 5 tane daha cubuk atilmasi lazim)
        
    }

    private void AtisYap()
    {
        
        Instantiate(OkPrefab[ayar.IndexAl()], Ok_Spawn_Transform.position, Quaternion.identity);
        //ayar.IndexAl bizim markette sectigimiz goruntunun secim indexidir.
    }

    IEnumerator AtisBekleme(float sure)
    {
        //atis yaparken cooldown yani atis bekleme suresini yapan IEnumerator
        atisBekleme = true;
        yield return new WaitForSeconds(sure);
        AtisYap();
        atisBekleme = false;
    }
        
        
   ## ✴️ Belki Bakarsın Diye Bırakıyorum ✴️
   ####  GitHub adresime [buradan](https://github.com/FurcanY) ulaşabilirsiniz.
   ####  İnstagram adresime [buradan](https://www.instagram.com/y.furcan/) ulaşabilirsiniz.
   ####  Youtube adresime [buradan](https://www.youtube.com/channel/UCQRXjt0lg2jCnp2NqOAO2Ig) ulaşabilirsiniz.
   
