using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darbo_uzdavinys
{
    class Travel
    {
        public string Arrival { get; }
        public string Destination { get; }
        public int Distance { get; }

        public Travel(string arrival, string destination, int distance)
        {
            Arrival = arrival;
            Destination = destination;
            Distance = distance;
        }
    }

    class Program
    {
        static int Atstumas(Travel kintamaji, List<Travel> duomenys, ref List<Travel> keliones, ref bool finish)
        {
            int atstumas = 0;
            foreach (Travel item in duomenys)
            {
                if (kintamaji.Destination == item.Arrival)
                {
                    atstumas += item.Distance;
                    if (item.Destination != "G" && !finish)
                    {
                        keliones.Add(item);
                        atstumas += Atstumas(item, duomenys, ref keliones, ref finish);
                    }
                    else
                    {
                        finish = true;
                        break;
                    }
                }
            }
            return atstumas;
        }


        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input.txt");
            string data = reader.ReadToEnd();
            string[] duomenys = data.Split(' ').ToArray();
            List<List<Travel>> keliones = new List<List<Travel>>();
            List<Travel> darbinis = new List<Travel>();
            for (int i = 0; i < duomenys.Length; i += 3)
            {
                Travel temp = new Travel(duomenys[i], duomenys[i + 1], Convert.ToInt32(duomenys[i + 2]));
                darbinis.Add(temp);
            }
            int distance = int.MaxValue;
            foreach (Travel item in darbinis)
            {
                if (item.Arrival == "A")
                {
                    int t = item.Distance;
                    List<Travel> kolkas = new List<Travel>();
                    bool laikinas = false;
                    t += Atstumas(item, darbinis, ref kolkas, ref laikinas);
                    keliones.Add(kolkas);
                    if (t < distance)
                    {
                        distance = t;
                    }
                }
            }
            Console.WriteLine(distance);
        }
    }
}
