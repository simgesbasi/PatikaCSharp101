/*Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını 
console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOdev6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 adet sayi giriniz:");
            string[] girilenSayilar = Console.ReadLine().TrimEnd().Split(' ');
            int[] yeniSayilar = new int[20];

            if (!(girilenSayilar.Length == 20))
            {
                Console.WriteLine("Lütfen 20 adet sayi giriniz.");
                Console.ReadLine();
                return;
            }
            foreach (string i in girilenSayilar)
            {
                bool basarili = int.TryParse(i, out int sayi);
                if (basarili)
                {
                    int k = Array.IndexOf(girilenSayilar, i);
                    yeniSayilar[k] = sayi;
                }
                else
                {
                    Console.WriteLine("Lütfen sayi degeri giriniz.");
                    Console.ReadLine();
                    return;
                }

            }

            Array.Sort(girilenSayilar);

            int[] enBuyukUc = new int[] { yeniSayilar[19], yeniSayilar[18], yeniSayilar[17] };
            int[] enKucukUc = new int[] { yeniSayilar[0], yeniSayilar[1], yeniSayilar[2] };

            double enBuyukUcOrtalama = ArrayAverage(enBuyukUc);
            double enKucukUcOrtalama = ArrayAverage(enKucukUc);
            double toplamOrtalama = (enBuyukUcOrtalama + enKucukUcOrtalama) / 2;

            Console.WriteLine("En buyuk 3 sayinin ortalamasi: " + enBuyukUcOrtalama);
            Console.WriteLine("En kucuk 3 sayinin ortalamasi: " + enKucukUcOrtalama);
            Console.WriteLine("Her iki grubun ortalama toplami: " + toplamOrtalama);
            Console.ReadLine();

        }
        static double ArrayAverage(int[] array)
        {
            int toplam = 0;
            foreach (int sayi in array)
            {
                toplam += sayi;
            }
            return (double)toplam / array.Length;
        }
    }
}
