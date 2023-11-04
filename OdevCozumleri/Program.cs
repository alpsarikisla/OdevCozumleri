using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OdevCozumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev 1 - Yuvarlama

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //double ondalikSayi = Convert.ToDouble(Console.ReadLine());

            //int tam = (int)ondalikSayi;
            //double ondalikKisim = ondalikSayi - tam;

            //if(ondalikKisim >= 0.5)
            //{
            //    tam++;
            //    Console.WriteLine(tam);
            //}
            //else
            //{
            //    Console.WriteLine(tam);
            //}

            #endregion

            #region  Ödev 2 - Kullanıcı Kontrol

            //Console.Write("Kullanıcı Adı = ");
            //string kadi = Console.ReadLine();

            //Console.Write("Şifre = ");
            //string sifre = Console.ReadLine();

            //if (kadi == "admin" && sifre == "1234")
            //{
            //    Console.WriteLine("Merhaba. Hoşgeldiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen giriş bilgilerinizi kontrol ediniz");
            //}

            #endregion

            #region Ödev 3 - Ay Mevsim

            //Console.WriteLine("Mevsim kontrolü yapılacak ay ismini giriniz");
            //string ay = Console.ReadLine();

            //if (ay == "aralık" || ay == "ocak" || ay == "şubat")
            //{
            //    Console.WriteLine("Kış mevsimindesiniz");
            //}
            //if (ay == "mart" || ay == "nisan" || ay == "mayıs")
            //{
            //    Console.WriteLine("İlkbahar mevsimindesiniz");
            //}
            //if (ay == "haziran" || ay == "temmuz" || ay == "ağustos")
            //{
            //    Console.WriteLine("Yaz mevsimindesiniz");
            //}
            //if (ay == "eylül" || ay == "ekim" || ay == "kasım")
            //{
            //    Console.WriteLine("Sonbahar mevsimindesiniz");
            //}

            #endregion

            #region Ödev 3 Ay Mevsim Çözüm 2

            //Console.WriteLine("Mevsim kontrolü yapılacak ay ismini giriniz");
            //string ay = Console.ReadLine();

            //if (ay == "ocak")
            //{
            //    Console.WriteLine("Mevsim = Kış");
            //}
            //if (ay == "şubat")
            //{
            //    Console.WriteLine("Mevsim = Kış");
            //}
            //if (ay == "mart")
            //{
            //    Console.WriteLine("Mevsim = ilkbahar");
            //}
            //if (ay == "nisan")
            //{
            //    Console.WriteLine("Mevsim = ilkbahar");
            //}
            //if (ay == "mayıs")
            //{
            //    Console.WriteLine("Mevsim = ilkbahar");
            //}
            //if (ay == "haziran")
            //{
            //    Console.WriteLine("Mevsim = yaz");
            //}
            //if (ay == "temmuz")
            //{
            //    Console.WriteLine("Mevsim = yaz");
            //}
            //if (ay == "ağustos")
            //{
            //    Console.WriteLine("Mevsim = yaz");
            //}
            //if (ay == "eylül")
            //{
            //    Console.WriteLine("Mevsim = sonbahar");
            //}
            //if (ay == "ekim")
            //{
            //    Console.WriteLine("Mevsim = sonbahar");
            //}
            //if (ay == "kasım")
            //{
            //    Console.WriteLine("Mevsim = sonbahar");
            //}


            #endregion

            #region Ödev 3 Ay Mevsim Çözüm 3

            ////Eğer koşul bir aralık değeri değil sabit bir değer ise
            ////switch - case kullanılabilir

            //Console.WriteLine("Mevsim kontrolü yapılacak ay ismini giriniz");
            //string ay = Console.ReadLine();

            //switch(ay)
            //{
            //    case "aralik":
            //        Console.WriteLine("kış");
            //        break;
            //    case "ocak":
            //        Console.WriteLine("kış");
            //        break;
            //    case "şubat":
            //        Console.WriteLine("Kış");
            //        break;
            //    case "mart":
            //        Console.WriteLine("ilkbahar");
            //        break;
            //}

            #endregion

            #region Ödev 4 - Ödev Yaş

            //Console.WriteLine("Lütfen doğum yılınızı giriniz");
            //int yil = Convert.ToInt32(Console.ReadLine());

            ////int yas = 2023 - yil;
            //int yas = DateTime.Now.Year - yil;

            //if (yas >= 15)
            //{
            //    Console.WriteLine("Merhaba");
            //}
            //else
            //{
            //    Console.WriteLine("Küçüğüm daha çok küçüğüm bu yüzden");
            //}


            #endregion

            #region Ödev 5 - Seçilen dilde merhaba

            //Console.WriteLine("Lütfen Dil seçiniz");
            //Console.WriteLine("1) Türkçe");
            //Console.WriteLine("2) İngilizce");
            //Console.WriteLine("3) Almanca");
            //Console.WriteLine("4) İspanyolca");

            //string secim = Console.ReadLine();

            //if (secim == "1")
            //{
            //    Console.WriteLine("Merhaba");
            //}
            //if (secim == "2")
            //{
            //    Console.WriteLine("Hello");
            //}
            //if (secim == "3")
            //{
            //    Console.WriteLine("Halo");
            //}
            //if (secim == "4")
            //{
            //    Console.WriteLine("Bienvenido");
            //}

            #endregion

            #region Ödev 6 - Öğrencinin Final Notu

            //Console.WriteLine("Lütfen vize notunuzu giriniz");
            //double vize = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Lütfen final notunuzu giriniz");
            //double final = Convert.ToDouble(Console.ReadLine());

            //double ortalama = (vize * 0.4) + (final * 60 / 100);

            //Console.Write("Ortalama Notunuz = " + ortalama);
            //if (ortalama >= 50)
            //{
            //    Console.WriteLine("Geçtiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Kaldınız");
            //    Console.Beep(200, 500);
            //}

            #endregion

            #region Ödev 7 - Tek Çift

            //int tektoplam = 0;
            //int cifttoplam = 0;
            //int tekadet = 0;
            //int ciftadet = 0;

            //Console.WriteLine("1. sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //if (sayi1 % 2 == 0)
            //{
            //    cifttoplam += sayi1;
            //    ciftadet++;
            //}
            //else
            //{
            //    tektoplam += sayi1;
            //    tekadet++;
            //}

            //Console.WriteLine("2. sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //if (sayi2 % 2 ==0 )
            //{
            //    cifttoplam += sayi2;
            //    ciftadet++;
            //}
            //else
            //{
            //    tektoplam += sayi2;
            //    tekadet++;
            //}

            //Console.WriteLine("3. sayıyı giriniz");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //if (sayi3 % 2 == 0)
            //{
            //    cifttoplam += sayi3;
            //    ciftadet++;
            //}
            //else
            //{
            //    tektoplam += sayi3;
            //    tekadet++;
            //}

            //Console.WriteLine("4. sayıyı giriniz");
            //int sayi4 = Convert.ToInt32(Console.ReadLine());
            //if (sayi4 % 2 == 0)
            //{
            //    cifttoplam += sayi4;
            //    ciftadet++;
            //}
            //else
            //{
            //    tektoplam += sayi4;
            //    tekadet++;
            //}

            //Console.WriteLine("5. sayıyı giriniz");
            //int sayi5 = Convert.ToInt32(Console.ReadLine());
            //if (sayi5 % 2 == 0)
            //{
            //    cifttoplam += sayi5;
            //    ciftadet++;
            //}
            //else
            //{
            //    tektoplam += sayi5;
            //    tekadet++;
            //}

            //Console.WriteLine("6. sayıyı giriniz");
            //int sayi6 = Convert.ToInt32(Console.ReadLine());
            //if (sayi6 % 2 == 0)
            //{
            //    cifttoplam += sayi6;
            //    ciftadet++;
            //}
            //else
            //{
            //    tektoplam += sayi6;
            //    tekadet++;
            //}

            //Console.WriteLine("Tek sayıların ortalaması = " + (tektoplam / tekadet));
            //Console.WriteLine("Çift sayıların ortalaması = " + (cifttoplam / ciftadet));

            #endregion

            #region Ödev 8 - Karakter Kontrol

            //Console.WriteLine("Lütfen bir karakter giriniz");
            //char karakter = Convert.ToChar(Console.ReadLine());

            //int sayisal = (int)karakter;

            //if (sayisal >= 65 && sayisal <= 90)
            //{
            //    Console.WriteLine("Karakter büyük");
            //}
            //if (sayisal >= 97 && sayisal <= 122)
            //{
            //    Console.WriteLine("Karakter küçük");
            //}



            #endregion

            #region Ödev 9 Hesap Makinesi

            //Console.WriteLine("Lütfen 1. sayıyı giriniz");
            //double s1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sayıyı giriniz");
            //double s2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("+ Toplama");
            //Console.WriteLine("- Çıkarma");
            //Console.WriteLine("* Çarpma");
            //Console.WriteLine("/ Bölme");
            //Console.WriteLine("Sembol giriniz = ");
            //string sembol = Console.ReadLine();

            //double sonuc = 0;
            //if (sembol == "+")
            //{
            //    sonuc = s2 + s1;
            //}
            //if (sembol == "-")
            //{
            //    sonuc = s1 - s2;
            //}
            //if (sembol == "*")
            //{
            //    sonuc = s1 * s2;
            //}
            //if (sembol == "/")
            //{
            //    sonuc = s1 / s2;
            //}
            //Console.WriteLine("Sonuç = " + sonuc);

            #endregion

            #region Ödev 9 - Hesap Makinesi 2 

            Console.WriteLine("Lütfen 1. sayıyı giriniz");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen 2. sayıyı giriniz");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("+ Toplama");
            Console.WriteLine("- Çıkarma");
            Console.WriteLine("* Çarpma");
            Console.WriteLine("/ Bölme");
            Console.WriteLine("Sembol giriniz = ");
            string sembol = Console.ReadLine();

            double sonuc = 0;
            switch (sembol)
            {
                case "+": sonuc = s1 + s2;
                    break;
                case "-": sonuc = s1 - s2;
                    break;
                case "*": sonuc = s1 * s2;
                    break;
                case "/":
                    if (s2 != 0)
                    {
                        sonuc = s1 / s2;
                    }
                    else
                    {
                        Console.WriteLine("0'a bölme tanımsızdır");
                    }
                    break;
                default:
                    Console.WriteLine("Hatalı işlem seçildi");
                    break;
            }

            Console.WriteLine("Sonuç = " + sonuc);
            #endregion
        }
    }
}
