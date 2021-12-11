using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.kursEgitmeni = "Engin";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.kursEgitmeni = "Murat";
            kurs2.izlenmeOrani = 48;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python";
            kurs3.kursEgitmeni = "Kerem";
            kurs3.izlenmeOrani = 85;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi);
            }
            Console.ReadKey();
        }



        class Kurs
        {
            public string kursAdi { get; set; }
            public string kursEgitmeni { get; set; }
            public int izlenmeOrani { get; set; }

        }   

         
        
    }
}
