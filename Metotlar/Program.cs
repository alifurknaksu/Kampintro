﻿using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Çekirdeksiz karpuz";

            Urun[] urunler = new Urun[] {urun1, urun2  };

            //type-safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("..................");

            }

            Console.WriteLine("---------Metotlar----------");
            //instance - örnek
            //encapsulation - kapsülleme

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12 , 20);
            sepetManager.Ekle2("Elma", "Yeşil elma", 8, 30);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 75 , 5);


        }
    }
}


//Do not repeat yourself - DRY - Clean Code - Best Practice

