using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            // DeğişkenTürü [] DiziAdı=new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[5]);

            //int[] numbers =new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[7]); 

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors= { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" }

            //for(int i=0;i<colors.Length;i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 2365, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region Dizi Metotları

            //Dizi uzunluğu
            //string[] person = { "ali", "ahmet", "mehmet", "emin" };
            //Console.WriteLine(person.Length);

            //int[] numbers = { 1, 4, 5, 6, 2, 8, 9, 4, 32, 14, 5 };
            //Console.WriteLine(numbers.Length);

            //Dizi elemanlarını küçükten büyüğe doğru sıralama
            //int[] numbers = { 3, 2, 5, 12, 21, 56, 38, 27 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}


            //Diziyi Tersten Yazdırma
            //int[] numbers = { 3, 2, 5, 12, 21, 56, 38, 27 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            //Dizi elemanının kaçıncı indeksde olduğunu bulma
            //string[] costumers = { "ali", "buse", "mahmut", "süleyman" };
            //int index = array.ındexof(costumers, "mahmut");
            //console.writeline(index);

            //int[] numbers = { 1, 2, 3, 4, 5};
            //Console.WriteLine("Dizinin en büyük elemanı: " +  numbers.Max() + "\n" + "Dizinin en" +
            //    " küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan değer alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("-------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write(cities[i] + " ");
            //}

            //Kullanıcıdan alınan sayıların toplamı
            //int sum = 0;

            //int[] numbers = new int[6];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Lütfen dizinin {i + 1}. elemanını giriniz: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];    
            //}

            //Console.Write($"Olusturdugunuz 6 Elemanlı Dizinin Elemanları Toplamı: {sum}");

            //TEK ÇİFT SAYILARI AYRI YAZADIRMA
            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion

            Console.Read();
        }
    }
}
