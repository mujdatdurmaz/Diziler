using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = new int[5];

            //sayilar[0] = 12;
            //sayilar[1] = 15;
            //sayilar[2] = 10;
            //sayilar[3] = 9;
            //sayilar[4] = 8;

            //Console.WriteLine(sayilar[2]);


            //int[] sayilar2 = { 12, 15, 10, 9, 8 };

            //Console.WriteLine(sayilar2[4]);

            //string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(gunler[i]);
            //}

            //int mevcut = 0;
            //Console.Write("Sınıf Mevcudunu Giriniz");
            //mevcut = Convert.ToInt32(Console.ReadLine());

            //string[] ogrenci = new string[mevcut];

            //for (int i = 0; i < mevcut; i++)
            //{
            //    Console.Write((i + 1) + ". Öğrenci Adını Giriniz : ");
            //    ogrenci[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < ogrenci.Length; i++)
            //{
            //    Console.Write(ogrenci[i] + "\t");
            //}

            //int[] dizi = new int[500];
            //Random rnd = new Random();

            //for (int i = 0; i < 500; i++)
            //{
            //    int sayi = rnd.Next(1, 50);
            //    dizi[i] = sayi;

            //}
            //Array.Sort(dizi); // küçükten büyüğe sıralama
            //Array.Reverse(dizi); // tersini alma


            //for (int i = 0; i < 500; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}

            //int[] dizi = new int[20];
            //int posay = 0, nesay = 0, sifsay = 0;
            //Random rnd = new Random();

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = rnd.Next(-100, 100);
            //    if (dizi[i] < 0)
            //    {
            //        nesay++;
            //        Console.WriteLine("Çıkan Negatif sayılar : " + dizi[i]);
            //    }
            //    else if (dizi[i] > 0)
            //    {
            //        posay++;
            //        Console.WriteLine("Çıkan Pozitif sayılar : " + dizi[i]);
            //    }
            //    else
            //    { sifsay++;
            //        Console.WriteLine("Çıkan sıfır : " + dizi[i]);
            //    }

            //}
            //Array.Sort(dizi);
            //foreach (int eleman in dizi)
            //{
            //    Console.Write(eleman + " ");
            //}

            //Console.WriteLine("\n Pozitif sayılar {0} adet,\n Negatif Sayılar {1} adet, \n Sıfır Sayılar {2} adettir.", posay, nesay, sifsay);


            //string[] isim = {"Ahmet","Ali","Veli","Osman","Feyyaz" };
            //string[] telefon = {"05555555","22222","33333333","444444444","5555555555" };
            //string[] email = { "a@a.com" ,"b@b.com","c@c.com","d@d.com","e@e.com"};

            //Console.Write("Kaçıncı personeli görmek istiyorsunuz (1-5)");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //switch (sayi)
            //{
            //    case 1: Console.Write(isim[sayi-1] + "\t" + telefon[sayi - 1] + "\t" + email[sayi - 1]);
            //        break;

            //    case 2:
            //        Console.Write(isim[sayi - 1] + "\t" + telefon[sayi - 1] + "\t" + email[sayi - 1]);
            //        break;
            //    case 3:
            //        Console.Write(isim[sayi - 1] + "\t" + telefon[sayi - 1] + "\t" + email[sayi - 1]);
            //        break;
            //    case 4:
            //        Console.Write(isim[sayi - 1] + "\t" + telefon[sayi - 1] + "\t" + email[sayi - 1]);
            //        break;
            //    case 5:
            //        Console.Write(isim[sayi - 1] + "\t" + telefon[sayi - 1] + "\t" + email[sayi - 1]);
            //        break;
            //    default:
            //        break;
            //}

            //int[] sayilar = { 1, 9, 5, 7, 3, 11 };
            //int indis = 0;


            //Console.WriteLine("Dizi içerisinde ne arıyorsunuz?");
            //int aranan = int.Parse(Console.ReadLine());
            //Console.WriteLine(Array.IndexOf(sayilar, aranan));
            //indis = Array.IndexOf(sayilar, aranan);


            //Array.Clear(sayilar, 0, 5);

            //foreach (var item in sayilar)
            //{
            //    Console.Write(item + " ");
            //}


            //int[] b = new int[10];
            //b[0] = 15;

            //foreach (var icerik in b)
            //{
            //    Console.Write(icerik + "\r");
            //}

            //int[] sayilar = {10,22,34,47,55,63 };
            //Console.WriteLine(sayilar.Count());
            //Console.WriteLine(sayilar.Max());
            //Console.WriteLine(sayilar.Min());
            //Console.Write(sayilar.Average());


            //string[] sehirler = new string[5];

            //Console.WriteLine("Şehirlerin isimlerini giriniz.");
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.Write((i + 1) + ". Şehir adını giriniz.");
            //    string ekle = Console.ReadLine();
            //    sehirler[i] = ekle;

            //}

            //Console.WriteLine("Şehir Ara : ");
            //string ara = Console.ReadLine();

            //if (Array.IndexOf(sehirler, ara) == -1)
            //{
            //    Console.WriteLine("Aradığınız şehir YOKTUR.");
            //}
            //else
            //{ Console.WriteLine("Aradığınız Şehir :{0} Dizideki sırası : {1} ",ara, Array.IndexOf(sehirler, ara)+1); }

            //int[] numbers = {1,2,3,4,5,6,7,8,9 };

            //Array.Clear(numbers, 3, 2);

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            Console.Write("Kaç ürün kaydı yapacaksınız ? ");
            int kayitSayisi = int.Parse(Console.ReadLine());

            string[] urunNo = new string[kayitSayisi];
            string[] urunAdi = new string[kayitSayisi];
            double[] urunFiyat = new double[kayitSayisi];

            for (int i = 0; i < kayitSayisi; i++)
            {
                Console.Write((i + 1) + ". ürün No Giriniz : ");
                urunNo[i] = Console.ReadLine();
                Console.Write((i + 1) + ". ürün Adı Giriniz : ");
                urunAdi[i] = Console.ReadLine();
                Console.Write((i + 1) + ". ürün Fiyatı Giriniz : ");
                urunFiyat[i] = Convert.ToInt32(Console.ReadLine());
               
            }


            Console.WriteLine("En pahalı ürün : " + urunAdi[Array.IndexOf(urunFiyat,urunFiyat.Max())]);
            Console.WriteLine("En ucuz ürün : " + urunAdi[Array.IndexOf(urunFiyat, urunFiyat.Min())]);
            Console.WriteLine("Ortalama : " + urunFiyat.Average());

            for (int i = 0; i < kayitSayisi; i++)
            {
                urunFiyat[i] *= 1.15; 
            }

            Console.WriteLine("Ürün No\tÜrün Adı\tÜrün Fiyatı");
            Console.WriteLine("--------------------------------------------------");


            for (int i = 0; i < kayitSayisi; i++)
            {
                Console.WriteLine(urunNo[i] + "\t" + urunAdi[i] + "\t" + urunFiyat[i]);
            }




            Console.ReadKey();

        }
    }
}
