using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortu_kalade
{

    //Kortu kalade
    class Korta
    {
        public Korta(int zenkas_sk, char simbolis)
        {
            Zenklas_sk = zenkas_sk;
            Simbolis = simbolis;
            Is_sk_ck();
        }

        public int Zenklas_sk { get; }
        public string zenklas { get; set; }
        public char Simbolis { get; }

        private void Is_sk_ck()
        {
            switch (Zenklas_sk)
            {
                case 1:
                    zenklas = "A";
                    break;
                case 11:
                    zenklas = "K";
                    break;
                case 12:
                    zenklas = "D";
                    break;
                case 13:
                    zenklas = "B";
                    break;
                default:
                    zenklas = Zenklas_sk.ToString();
                    break;

            }
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            char[] simboliai = { 'B', 'S', 'K', 'V' };
            int liko_kortu = 52;
            Random rng = new Random();
            List<Korta> kalade = new List<Korta>();
            while (liko_kortu > 0)
            {
                Korta temp = new Korta(rng.Next(1, 14), simboliai[rng.Next(0, simboliai.Length)]);
                int flag = 0;
                foreach (Korta kort in kalade)
                {
                    if (kort.Simbolis == temp.Simbolis && kort.Zenklas_sk == temp.Zenklas_sk)
                    {
                        flag++;
                    }
                }
                if(flag == 0)
                {
                    kalade.Add(temp);
                    liko_kortu--;
                    Console.WriteLine(temp.Simbolis+" " + temp.zenklas);
                }
            }
        }
    }
}
