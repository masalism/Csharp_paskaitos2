using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_vartotojas
{
    class Vartotojas
    {
        public Vartotojas(int userId, string name, string surname, int gimimioMetai, Adresas adresas)
        {
            UserId = userId;
            Name = name;
            Surname = surname;
            GimimioMetai = gimimioMetai;
            Adresas = adresas;
        }
        

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GimimioMetai { get; set; }
        public Adresas Adresas { get; set; }

        public virtual int Kiek_Metu()
        {
            return (DateTime.Today.Year - GimimioMetai);
        }
    }

    class Adresas
    {
        public Adresas(string street, string country, string city, int house_Number)
        {
            Street = street;
            Country = country;
            City = city;
            House_Number = house_Number;
        }

        public string Street { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int House_Number { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Adresas adresas1 = new Adresas("Kieciu", "Lithuania", "Kaunas", 77);
            Vartotojas user1 = new Vartotojas(01, "Mantas", "Masalis", 1990, adresas1);
            Adresas adresas2 = new Adresas("Kedainiu", "Lithuania", "Vilnius", 72);
            Vartotojas user2 = new Vartotojas(02, "Darius", "Tulauskas", 1992, adresas2);
            Adresas adresas3 = new Adresas("Gulbes", "Lithuania", "Silale", 5);
            Vartotojas user3 = new Vartotojas(03, "Martynas", "Jegerskas", 1996, adresas3);
            Adresas adresas4 = new Adresas("Fantos", "Lithuania", "Kaunas", 4);
            Vartotojas user4 = new Vartotojas(04, "Saulius", "Gudelis", 1990, adresas4);
            SimpleUser simpleus1 = new SimpleUser(01, "Mantas", "Masalis", 1990, adresas1, "mantasmasalis@gmail.com");
            SuperUser superus1 = new SuperUser(01, "Mantas", "Masalis", 1990, adresas1, 44);
            Console.WriteLine(superus1.Kiek_Metu());
            Console.WriteLine(simpleus1.Kiek_Metu());





        }
    }
}
