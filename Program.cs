/*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PatikaOdev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Yazacağınız kelime sayısını giriniz:");
            try
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());
                if (n <= 0)
                {
                    Console.WriteLine("Geçerli kelime sayısı giriniz.");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("{0} adet kelime yazınız:", n);
                List<string> girilenKelimeler = Console.ReadLine().TrimEnd().Split(' ').ToList();

                foreach(string i in girilenKelimeler)
                {                 
                    if (!i.All(char.IsLetter))
                    {                      
                        Console.WriteLine("Lütfen kelimeleri doğru formatta yazınız.");
                        Console.ReadLine();
                        return;
                    }                             
                }

                if (girilenKelimeler.Count != n)
                {
                    Console.WriteLine("Lütfen girdiğiniz kelime adedini kontrol ediniz.");
                    Console.ReadLine();
                    return;
                }

                girilenKelimeler.Reverse();
                Console.Write("Girmiş olduğunuz kelimeler: ");
                foreach (string kelime in girilenKelimeler)
                {
                    Console.Write(kelime + " ");
                }

                Console.ReadLine();
            }
            catch (FormatException)

            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                Console.ReadLine();
                return;
            }
        }
    }
}
