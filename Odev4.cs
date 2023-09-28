//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOdev4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir cümle yazınız:");
            try
            {
                string girilenCumle = Console.ReadLine();

                if (girilenCumle.Split('.', '!', '?' ).Length > 1)
                {
                    Console.WriteLine("Sadece bir cümle girebilirsiniz.");
                    Console.ReadLine();
                    return;
                }

                string[] kelimeler = girilenCumle.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);               
                int kelimeSayisi = kelimeler.Length;
                int harfSayisi = 0;

                foreach (char karakter in girilenCumle)
                {
                    if (char.IsLetter(karakter))
                    {
                        harfSayisi++;
                    }              
                }
                Console.WriteLine("Cümledeki toplam kelime sayısı: " + kelimeSayisi);
                Console.WriteLine("Cümledeki toplam harf sayısı: " + harfSayisi);
            }
            catch (FormatException) 
            {
                Console.WriteLine("Lütfen doğru formatta bir değer giriniz.");              
                return;
            }
            Console.ReadLine();
        }
    }
}
