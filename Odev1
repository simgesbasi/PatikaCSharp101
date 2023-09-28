using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOdev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir sayi giriniz:");
            int n ;
            List<int> girilenSayilar;
            try
            {
                n = Convert.ToInt32(Console.ReadLine().Trim());

                if (n <= 0)
                {
                    Console.WriteLine("Lütfen gireceginiz sayi adedini dogru yaziniz.");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("{0} adet pozitif sayi giriniz:", n);
                girilenSayilar = Console.ReadLine().TrimEnd().Split(' ').ToList().ConvertAll(aTemp => Convert.ToInt32(aTemp));

                if(girilenSayilar.Count != n)
                {
                    Console.WriteLine("Lütfen girdiginiz sayi adedini kontrol ediniz.");
                    Console.ReadLine();
                    return;
                }
                ciftSayilariYazdirma(girilenSayilar, n);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen gecerli bir deger giriniz.");
                Console.ReadLine();
                return;
            }
        }

        static void ciftSayilariYazdirma(List<int> girilenSayilar, int n)
        {
            int count = girilenSayilar.Count;
            bool elemanlarPozitif = true;
            bool ciftSayiVarMi = false;

            foreach (int i in girilenSayilar)
            {
                if (i <= 0)
                {
                    elemanlarPozitif = false;
                    Console.WriteLine("Lütfen pozitif sayilar giriniz.");
                    return;
                }
                else if (i % 2 == 0)
                {
                    ciftSayiVarMi = true;
                }
            }
            if (elemanlarPozitif == true)
            {
                if (ciftSayiVarMi)
                {
                    Console.Write("Girmis oldugunuz cift sayilar: ");
                    foreach (int i in girilenSayilar)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Herhangi bir cift sayi girmediniz.");
                    return;
                }
            }
        }
    }
}
