using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            dortIslem DortIslem = new dortIslem();

            DortIslem.Topla(5,6);
            Console.ReadKey();
        }
    }
}
