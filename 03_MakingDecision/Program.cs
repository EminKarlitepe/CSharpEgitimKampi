using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if

            //int attempts = 3;
            //int correctPassword = 1234;

            //while (attempts > 0)
            //{
            //    Console.Write("Lütfen şifreyi giriniz: ");
            //    int password = int.Parse(Console.ReadLine());

            //    // Şifre doğruysa
            //    if (password == correctPassword)
            //    {
            //        Console.WriteLine("Şifre doğru. Giriş başarılı!");
            //        break;
            //    }
            //    else
            //    {
            //        attempts--;
            //        if (attempts > 0)
            //        {
            //            Console.WriteLine($"Hatalı şifre. Kalan hakkınız: {attempts}");
            //        }
            //    }
            //}

            //if (attempts == 0)
            //{
            //    Console.WriteLine("3 kere hatalı giriş yaptınız. Program kapatılıyor...");
            //    Environment.Exit(0);
            //}

            //Şifre yanlızca int veri tipinde girildiği zaman program çalışıyor. Çünkü
            //int.Parse metodu kullanılarak kullanıcıdan alınan giriş sayısal bir değere dönüştürülüyor.

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");
            //}


            //int exam1, exam2, exam3;
            //double avarage;
            //string result = "Hata!";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam3 + exam2 + exam1) / 3;

            //Console.Write("Sınavların Ortalaması: " + avarage + "\n");

            //if (avarage >= 0 && avarage < 50)
            //{
            //    result = "Kaldınız.";
            //}
            //else if (avarage >= 50 && avarage < 55)
            //{
            //    result = "DD ile Geçtiniz.";
            //}
            //else if (avarage >= 55 && avarage < 60)
            //{
            //    result = "DC ile Geçtiniz.";
            //}
            //else if (avarage >= 60 && avarage < 65)
            //{
            //    result = "CC ile geçtiniz.";
            //}
            //else if (avarage >= 65 && avarage < 70)
            //{
            //    result = "CB ile Geçtiniz.";
            //}
            //else if (avarage >= 70 && avarage < 80)
            //{
            //    result = "BB ile Geçtiniz.";
            //}
            //else if (avarage >= 80 && avarage < 90)
            //{
            //    result = "BA ile Geçtiniz.";
            //}
            //else if (avarage >= 90 && avarage <= 100)
            //{
            //    result = "AA ile Geçtiniz.";
            //}
            //else
            //{
            //    result = "Geçersiz Not.";
            //}

            //Console.Write(result);

            //Console.WriteLine("Vücut Kitle İndeksi Hesaplama");
            //Console.WriteLine("-----------------------------");

            //Console.Write("Kilonuzu (kg) giriniz: ");
            //double kilo = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Boyunuzu (metre cinsinden) giriniz: ");
            //double boy = Convert.ToDouble(Console.ReadLine());

            //double vki = kilo / (boy * boy);
            //Console.WriteLine($"\nVücut Kitle İndeksiniz: {vki:F2}");

            //if (vki < 18.5)
            //{
            //    Console.WriteLine("Zayıf");
            //}
            //if (vki >= 18.5 && vki < 25)
            //{
            //    Console.WriteLine("Normal kilolu");
            //}
            //if (vki >= 25 && vki < 30)
            //{
            //    Console.WriteLine("Fazla kilolu");
            //}
            //if (vki >= 30 && vki < 35)
            //{
            //    Console.WriteLine("1. derece obezite");
            //}
            //if (vki >= 35 && vki < 40)
            //{
            //    Console.WriteLine("2. derece obezite");
            //}
            //if (vki >= 40)
            //{
            //    Console.WriteLine("3. derece obezite");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1.Sayının 2.sayıya bölümünden kalan: " + result + "\n");

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz (G,F,B): ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}


            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine();


            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine("------------Çorbalar------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("------------Pizzalar------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------------İçecekler------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("------------Tatlılar------------");

            //    Console.WriteLine();
            //}


            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //}


            #endregion

            Console.Read();
        }
    }
}
