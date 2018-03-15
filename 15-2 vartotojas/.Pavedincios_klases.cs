using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_vartotojas
{
    class SuperUser : Vartotojas
    {
        public int Batu_Dydis { get; set; }
        public int Alga { get; set; }

        public SuperUser(int userId, string name, string surname, int gimimioMetai, Adresas adresas, int batu_Dydis)
            : base(userId, name, surname, gimimioMetai, adresas)
        {
            Batu_Dydis = batu_Dydis;
        }
    }

    class SimpleUser : Vartotojas
    {
        public string Pomegiai { get; set; }
        public string Elpastas { get; set; }

        public SimpleUser(int userId, string name, string surname, int gimimioMetai, Adresas adresas, string elpastas)
            : base(userId, name, surname, gimimioMetai, adresas)
        {
            Elpastas = elpastas;
        }

        public override int Kiek_Metu()
        {
            Console.WriteLine("Patikrinu amziu");
            return base.Kiek_Metu();
        }
    }


}
