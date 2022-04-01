using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 5;
            //int sayi2 = 10;

            //sayi1 = sayi2;
            //sayi2 = sayi2 + 10;

            //Console.WriteLine(sayi1);
            //Console.WriteLine(sayi2);



            //string[] ogrenciler1 = new string[]
            //{
            //    "Fatih", "Mustafa","Mert"
            //};

            //string[] ogrenciler2 = new string[]
            //{
            //    "Abdulkadir","Enes","Emirhan"
            //};

            //ogrenciler2 = ogrenciler1;

            //ogrenciler1[0] = "Hasan";

            //foreach (var ogrenci in ogrenciler2)
            //{
            //    Console.WriteLine(ogrenci);
            //}


            //int deger1 = 10;
            //float deger2;
            //deger1 = deger2;


            //int b = 500;
            //byte i = (byte)b;

            //Console.WriteLine(i);

            //int sayi1 = 10;
            //float sayi2 = sayi1;

            //float sayi3 = 20.0f;
            //int sayi4 = sayi3;


            //int sayi1 = 5;
            //int sayi2 = 2;

            //float sonuc = ((float)sayi1 / sayi2);

            //Console.WriteLine(sonuc);


            //int i = 256;
            //byte b;

            //checked
            //{
            //    b = (byte)i;
            //}



            //string sayi1 = "12554";

            //int sonuc;
            //sonuc = Convert.ToInt32(sayi1) + 10;
            //Console.WriteLine(sonuc);



            //int sayi1,sayi2;
            //Console.WriteLine("1. Sayıyı giriniz");

            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2. sayıyı giriniz");
            //sayi2 = int.Parse(Console.ReadLine());


            //int sonuc=sayi1+sayi2;

            //Console.WriteLine("Sonuc: {0}",sonuc);



            //int i = 50 / 40;
            //float j = 50f / 40f;

            //int a = 10;
            //int b;
            //int c;

            //b = a++;
            //c = ++a;

            //Console.WriteLine("i:{0} j:{1} a:{2} b:{3} c:{4} ",i,j,a,b,c);





            //HarfNotuHesaplama();



            //HaftaninGunleri();


            //AsalSayiHesabi();


            //var sayi = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 2) 
            //         break;
            //    {
            //        sayi++;
            //    }

            //}

            //Console.WriteLine(sayi);




            //var sayi = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 2) 
            //        continue;
            //    {
            //        sayi++;

            //    }
            //}
            //Console.WriteLine(sayi);








            //int sayi, toplam = 0, oncekiSayi = 0;

            //for (; ; )
            //{
            //    Console.WriteLine("Bir sayi giriniz");
            //    sayi= Int32.Parse(Console.ReadLine());

            //    if (sayi == 0)
            //        break;

            //    if (sayi == oncekiSayi)
            //    {
            //        Console.WriteLine("Farklı bir sayi giriniz.");
            //        continue;
            //    }

            //    toplam += sayi;
            //    Console.WriteLine("Sayıların toplamı: "+toplam.ToString());
            //    oncekiSayi = sayi;
            //}


            //Console.WriteLine("Dongu bitti");




            //SatirlariVeSutunlariDolasanKod();





            //DiziYazdirmaCizdirme();





            //RastgeleSayiUretme();





            //RastgeleSayiTahmin();



            Random rnd = new Random();

            int[] rastgeleSayilar = new int[100];

            //Console.WriteLine("{0} \t {1} \t {2}", "İndis", "Değer", "Kaç yerde Geçtiği");


            for (int i = 0; i < rastgeleSayilar.Length; i++)
            {
                rastgeleSayilar[i] = rnd.Next(1, 11);
            }
            

            int [] adet=new int[10];

            for (int i = 0; i < rastgeleSayilar.Length; i++)
            {
                adet[rastgeleSayilar[i] - 1]++;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  Adet {1} \t -->",adet[i],i+1);

                for (int j = 0; j < adet[i]; j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }



        }

        private static void RastgeleSayiTahmin()
        {
            Random random = new Random();

            int rs1 = random.Next(20, 30);
            int rs2 = random.Next(200, 300);

            //Console.WriteLine(rs1);

            Console.WriteLine("Bir sayi giriniz:");

            int sayi = Int32.Parse(Console.ReadLine());

            if (sayi == rs1)
            {
                Console.WriteLine("bildiniz");
            }
            else
            {
                Console.WriteLine("Tahmin Yanlış");
            }
        }

        private static void RastgeleSayiUretme()
        {
            Random rnd = new Random();

            int rs1 = rnd.Next();
            int rs2 = rnd.Next(50);
            int rs3 = rnd.Next(10, 20);

            Console.WriteLine(rs1);
            Console.WriteLine(rs2);
            Console.WriteLine(rs3);

            double rs4 = rnd.NextDouble();
            Console.WriteLine(rs4);
        }

        private static void DiziYazdirmaCizdirme()
        {
            // dizi boyutunu iste

            Console.WriteLine("boyutu giriniz");

            int boyut = Convert.ToInt32(Console.ReadLine());

            //diziyi tanımla

            int[] sayilar = new int[boyut];



            // dizi elemanlarını kullanıcıdan isteme

            Console.WriteLine("Dizi elemanlarını giriniz");


            for (int i = 0; i < boyut; i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }


            //başlık yazdırma

            Console.WriteLine("{0} \t {1} \t {2} ", "İndis", "Değer", "Grafik");


            // grafik çizdirme


            for (int i = 0; i < boyut; i++)
            {
                Console.Write("{0} \t {1} ", i, sayilar[i]);

                for (int j = 0; j < sayilar[i]; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }



        private static void SatirlariVeSutunlariDolasanKod()
        {
            int satir, sutun;
            char karakter;

            Console.WriteLine("Satır sayisi girin");
            satir = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sutun sayisi girin");
            sutun = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Karekter giriniz");
            karakter = Convert.ToChar(Console.ReadLine());



            for (int i = 0; i <= satir; i++)
            {
                for (int j = 0; j <= sutun; j++)
                {
                    Console.Write(karakter);
                }

                Console.WriteLine();
            }
        }

        private static void AsalSayiHesabi()
        {
            int sayi = int.Parse(Console.ReadLine());

            bool asalMi = true;

            for (int bolen = 2; bolen < sayi; bolen++)
            {

                if (sayi % bolen == 0) // sayinin bolen'e bölümünden kalan sıfır ise (mod alma)
                {
                    asalMi = false;
                    break;
                }


            }

            if (asalMi)
                Console.WriteLine("Asal");
            else
            {
                Console.WriteLine("Asal değil");
            }
        }

        private static void HaftaninGunleri()
        {
            Console.WriteLine("Haftanın kaçıncı gününü öğrenmek istiyorsunuz");


            int gun = int.Parse(Console.ReadLine());
            string gunadi = null;


            switch (gun)
            {
                case 1:
                    gunadi = "Pazartesi"; break;
                case 2:
                    gunadi = "Salı"; break;
                case 3:
                    gunadi = "Çarşamba"; break;
                case 4:
                    gunadi = "Perşembe"; break;
                case 5:
                    gunadi = "Cuma"; break;
                case 6:
                    gunadi = "Cumartesi"; break;
                case 7:
                    gunadi = "Pazar"; break;

                default:
                    gunadi = "Hatalı bir sayi girdiniz";
                    break;
            }


            Console.WriteLine(gunadi);
        }

        private static void HarfNotuHesaplama()
        {
            Console.WriteLine("Sınav notunu giriniz");

            int not = Convert.ToInt32(Console.ReadLine());

            string sonuc;

            if (not < 40)
            {
                sonuc = "FF";
            }
            else if (not > 40 && not < 60)
            {
                sonuc = "DD";
            }
            else if (not > 60 && not < 85)
            {
                sonuc = "CB";
            }
            else
            {
                sonuc = "AA";
            }

            Console.WriteLine(sonuc);
        }
    }
}

