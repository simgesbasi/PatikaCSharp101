/*Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOdev7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Cümle yaziniz: ");
            string metin = Console.ReadLine();

            if (SesliHarfleriSec(metin).Length == 0)
            {
                Console.WriteLine("Hicbir sesli harf icermez.");
                Console.ReadLine();
                return;
            }

            Console.Write("İcerdigi sesli harfler: ");

            for(int i=0; i< SesliHarfleriSec(metin).Length; i++)
            {
                Console.Write(SesliHarfleriSec(metin)[i]);
                if (i < SesliHarfleriSec(metin).Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.Read();
        }

        public static string SesliHarfleriSec(string metin)
        {
            string sesliHarfler = "aeiıouöüAEIİÖÜOU";
            List<char> sesliHarflerListesi = new List<char>();

            foreach (char karakter in metin)
            {
                if (sesliHarfler.Contains(karakter))
                {
                    sesliHarflerListesi.Add(karakter);
                }
            }
            char[] yeniMetin = sesliHarflerListesi.Distinct().ToArray();

            return new string(yeniMetin).ToLower();
        }
    }
}
