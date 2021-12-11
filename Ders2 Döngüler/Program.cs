using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders2_Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string [] { "java", "python", "c#" };
            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.ReadKey();
        }
    }
}
