/*Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PatikaOdev5
{
    static void Main()
    {
        ArrayList asalSayilar = new ArrayList();
        ArrayList asalOlmayanSayilar = new ArrayList();

        Console.WriteLine("20 adet pozitif sayi giriniz:");
        string[] sayilarString = Console.ReadLine().TrimEnd().Split(' ');

        if (!(sayilarString.Length==20))
        {
            Console.WriteLine("Lütfen 20 adet sayi giriniz.");
            Console.ReadLine();
            return;
        }
        foreach (string i in sayilarString)
        {
            bool basarili = int.TryParse(i, out int sayi);
            if(basarili && sayi > 0)
            {
                if (IsPrime(sayi))
                {
                    asalSayilar.Add(sayi);
                }
                else
                {
                    asalOlmayanSayilar.Add(sayi);
                }
            }
            else
            {
                Console.WriteLine("Lütfen gecerli sayi degeri giriniz");
                Console.ReadLine();
                return;
            }
        }

        asalSayilar.Sort();
        asalOlmayanSayilar.Sort();

        Console.WriteLine("Asal olan sayilar: " + string.Join(" ", asalSayilar.ToArray()));
        Console.WriteLine("Asal olmayan sayilar: " + string.Join(" ", asalOlmayanSayilar.ToArray()));

        Console.WriteLine($"Asal olan sayilarin toplami: {asalSayilar.Count}, Ortalamasi: {asalSayilar.Count / 20.0}");
        Console.WriteLine($"Asal olmayan sayilarin toplami: {asalOlmayanSayilar.Count}, Ortalamasi: {asalOlmayanSayilar.Count / 20.0}");

        Console.ReadLine();
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
}

