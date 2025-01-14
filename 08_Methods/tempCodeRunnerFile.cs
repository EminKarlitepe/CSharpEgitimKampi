using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //Metot için () olmalı.
            //1-Geriye değer döndürmeyen
            //costumer--> ekleme, silme, güncelleme
            //void

            //void CostumerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Mehmet Yıldırım");
            //    Console.WriteLine("Deniz Kaplan");
            //    Console.WriteLine("Defne Kaya");
            //}

            //CostumerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metodlar

            //void WriteMethod(string costumerName)
            //{
            //    Console.WriteLine(costumerName);
            //}

            //WriteMethod("Mehmet Yıldız");

            //void costumerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //costumerCard("Mehmet", "Yıldız");
            //costumerCard("Emin","Karlıtepe");

            #endregion

            #region Geriye Değer Döndürmeyen int Parametreli Metotlar

            //void Sum(int number1,  int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CostumerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CostumerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " -Başkent: " + capital +
            //        " -Bayrak Rengi: " + flagColor;

            //    return cardInfo;
            //}

            //string cName, cptl, fcolor;

            //Console.Write("Ülke adını giriniz: ");
            //cName = Console.ReadLine();

            //Console.Write("Başkent Adını Giriniz: ");
            //cptl = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //fcolor = Console.ReadLine();

            //Console.WriteLine(CountryCard(cName, cptl, fcolor));

            //Console.WriteLine(CountryCard("Ukrayna", "Kiev", "Sarı-Mavi"));

            #endregion

            #region Geriye Değer  Döndüren int Parametreli Metotlar

            //int Sum (int number1,int number2)
            //{ 
            //int result=number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44,36));
            //Console.WriteLine(Sum(14,20));


            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result > 50)
            //    {
            //        return student + " İsimli Öğrenci Sınavı Geçti" + " Ortalama: " + result;
            //    }
            //    else
            //    {

            //        return student + " İsimli Öğrenci Başarısız Oldu" + " Ortalama: " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            //Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));

            #endregion

            Console.Read();
        }
    }
}
