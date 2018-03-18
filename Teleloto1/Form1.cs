using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleloto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            List<int> M = Generuoja_kamuoliukus(1, 16, 5);
            List<int> J = Generuoja_kamuoliukus(16, 31, 5);
            List<int> R = Generuoja_kamuoliukus(31, 46, 5);
            List<int> G = Generuoja_kamuoliukus(46, 61, 5);
            List<int> Z = Generuoja_kamuoliukus(61, 76, 5);

            int[] masyvo = M.ToArray();
            int[] masyvo1 = J.ToArray();
            int[] masyvo2 = R.ToArray();
            int[] masyvo3 = G.ToArray();
            int[] masyvo4 = Z.ToArray();
            textM1.Text = masyvo[0].ToString();
            textM2.Text = masyvo[1].ToString();
            textM3.Text = masyvo[2].ToString();
            textM4.Text = masyvo[3].ToString();
            textM5.Text = masyvo[4].ToString();
            textJ1.Text = masyvo1[0].ToString();
            textJ2.Text = masyvo1[1].ToString();
            textJ3.Text = masyvo1[2].ToString();
            textJ4.Text = masyvo1[3].ToString();
            textJ5.Text = masyvo1[4].ToString();
            textR1.Text = masyvo2[0].ToString();
            textR2.Text = masyvo2[1].ToString();
            textR3.Text = masyvo2[2].ToString();
            textR4.Text = masyvo2[3].ToString();
            textR5.Text = masyvo2[4].ToString();
            textG1.Text = masyvo3[0].ToString();
            textG2.Text = masyvo3[1].ToString();
            textG3.Text = masyvo3[2].ToString();
            textG4.Text = masyvo3[3].ToString();
            textG5.Text = masyvo3[4].ToString();
            textZ1.Text = masyvo4[0].ToString();
            textZ2.Text = masyvo4[1].ToString();
            textZ3.Text = masyvo4[2].ToString();
            textZ4.Text = masyvo4[3].ToString();
            textZ5.Text = masyvo4[4].ToString();
            

        }

        //generatorius kamuoliuku
        private List<int> Generuoja_kamuoliukus(int a, int b, int kiekis)
        {
            List<int> darbui = new List<int>();
            Random rng = new Random();
            int ieskau = kiekis;
            while (ieskau != 0)
            {
                int temp = rng.Next(a, b);
                int flag = 0;
                foreach (int kam in darbui)
                {
                    if (kam == temp)
                    {
                        flag++;
                    }
                }
                if (flag == 0)
                {
                    darbui.Add(temp);
                    ieskau--;
                }
            }
            return darbui;
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            List<int> zaidimas = Generuoja_kamuoliukus(1, 76, 49);

            foreach (int temp in zaidimas)
            {
                Check_if_number(temp);
                textKam.Text += " " + temp.ToString();
            }
        }

        private void Check_if_number(int sk)
        {
            if (sk < 16)
            {
                if (sk.ToString() == textM1.Text)
                {
                    textM1.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textM2.Text)
                {
                    textM2.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textM3.Text)
                {
                    textM3.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textM4.Text)
                {
                    textM4.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textM5.Text)
                {
                    textM5.BackColor = Color.Blue;
                }
            }
            else if (sk > 15 && sk < 31)
            {
                if (sk.ToString() == textJ1.Text)
                {
                    textJ1.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textJ2.Text)
                {
                    textJ2.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textJ3.Text)
                {
                    textJ3.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textJ4.Text)
                {
                    textJ4.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textJ5.Text)
                {
                    textJ5.BackColor = Color.Blue;
                }
            }
            else if (sk > 30 && sk < 46)
            {
                if (sk.ToString() == textR1.Text)
                {
                    textR1.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textR2.Text)
                {
                    textR2.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textR3.Text)
                {
                    textR3.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textR4.Text)
                {
                    textR4.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textR5.Text)
                {
                    textR5.BackColor = Color.Blue;
                }
            }
            else if (sk > 45 && sk < 61)
            {
                if (sk.ToString() == textG1.Text)
                {
                    textG1.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textG2.Text)
                {
                    textG2.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textG3.Text)
                {
                    textG3.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textG4.Text)
                {
                    textG4.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textG5.Text)
                {
                    textG5.BackColor = Color.Blue;
                }
            }
            else if (sk > 60 && sk < 76)
            {
                if (sk.ToString() == textZ1.Text)
                {
                    textZ1.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textZ2.Text)
                {
                    textZ2.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textZ3.Text)
                {
                    textZ3.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textZ4.Text)
                {
                    textZ4.BackColor = Color.Blue;
                }
                else if (sk.ToString() == textZ5.Text)
                {
                    textZ5.BackColor = Color.Blue;
                }
            }

        }
    }
}
