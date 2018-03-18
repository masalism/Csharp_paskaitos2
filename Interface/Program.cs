using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IPavyzdys
    {
        //Interface
        string path { get; }
        void PrintOut();
    }

    class Textas : IPavyzdys
    {
        public string path
        {
            get { return ".txt"; }
        }

        public void PrintOut()
        {
            Console.WriteLine("Kuriamas {0} itemas", path);
        }
    }

    class Dokumentas : IPavyzdys
    {
        public string path
        {
            get { return ".doc"; }
        }

        public void PrintOut()
        {
            Console.WriteLine("Kuriamas {0} itemas", path);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPavyzdys[] talpykla = new IPavyzdys[2];
            talpykla[0] = new Textas();
            talpykla[1] = new Dokumentas();

            foreach (var item in talpykla)
            {
                item.PrintOut();
            }
        }
    }
}
