/*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOdev2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bölünmesini istediginiz pozitif sayiyi giriniz:");

            try
            {               
                int m = Convert.ToInt32(Console.ReadLine().Trim());
                if (m<=0)
                {
                    Console.WriteLine("Bölünmesini istediginiz sayi pozitif olmalı.");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("Kaç adet sayi ile işlem yapilacagini yaziniz:");
                int n = Convert.ToInt32(Console.ReadLine().Trim());
                if (n <= 0)
                {
                    Console.WriteLine("Bölünmesini istediginiz sayi pozitif olmalı.");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("{0} adet pozitif sayi giriniz:", n);
                List<int> girilenSayilar = Console.ReadLine().TrimEnd().Split(' ').ToList().ConvertAll(aTemp => Convert.ToInt32(aTemp));
                if (girilenSayilar.Count != n)
                {
                    Console.WriteLine("Lütfen girdiginiz sayi adedini kontrol ediniz.");
                    Console.ReadLine();
                    return;
                }
                sayilariBolme(girilenSayilar, m);
                Console.ReadLine();
            }

            catch(FormatException)
            {
                Console.WriteLine("Lütfen gecerli bir deger giriniz.");
                Console.ReadLine();
                return;
            }

        }
        static void sayilariBolme(List<int> girilenSayilar, int m)
        {
            bool elemanlarPozitif = true;
            bool bölenSayiVarMi = false;
            foreach (int i in girilenSayilar)
            {
                if (i <= 0)
                {
                    elemanlarPozitif = false;
                    Console.WriteLine("Lütfen pozitif sayilar giriniz.");
                    return;
                }
                else if(m % i ==0)
                {
                    bölenSayiVarMi = true;
                }
            }
            if (elemanlarPozitif)
            {
               if(bölenSayiVarMi)
                {
                    Console.Write("Girmis olduğunuz degerlerden {0} sayisini bölenler: ", m);
                    foreach (int i in girilenSayilar)
                    {
                        if (m % i == 0)
                        {
                            Console.Write(i +" ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Girdiginiz hiçbir değer {0} sayisini tam bölmüyor.", m);
                    Console.ReadLine() ;
                    return;
                }
            }
        }
    }
}
