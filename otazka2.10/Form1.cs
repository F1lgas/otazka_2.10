using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otazka2._10
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                int n = Convert.ToInt32(textBox1.Text);

                for (int i = 0; i < n; i++)
                {
                    char znak = Convert.ToChar(rnd.Next(36) + 42);

                    listBox1.Items.Add(znak);
                }

                if (checkBox1.Checked == true)
                {
                    int soucet = 0;

                    for (int y = 0; y < listBox1.Items.Count; y++)
                    {
                        if (Convert.ToChar(listBox1.Items[y]) >= '0' && Convert.ToChar(listBox1.Items[y]) <= '9')
                        {
                            soucet += Convert.ToInt32(listBox1.Items[y]) - 48;
                        }
                    }
                    if (soucet > 0)
                    {
                        MessageBox.Show("Součet všech cifer v listBoxu je " + soucet);
                    }
                    else
                    {
                        MessageBox.Show("listBox neobsahuje žádné cifry!");
                    }
                }
                if (checkBox2.Checked == true)
                {
                    int pocet = 0;
                    bool konec = false;

                    for (int y = 0; y < listBox1.Items.Count; y++)
                    {
                        if (Convert.ToChar(listBox1.Items[y]) >= 'A' && Convert.ToChar(listBox1.Items[y]) <= 'M')
                        {
                            pocet++;
                        }

                        if (pocet >= 3)
                        {
                            konec = true;
                        }

                        if (konec == true)
                        {
                            break;
                        }
                    }
                    if (konec == false)
                    {
                        MessageBox.Show("listBox neobsahuje 3 velká písmena!");
                    }
                    else
                    {
                        MessageBox.Show("listBox obsahuje 3 velká písmena");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Nezadal jsi číslo!");
            }
            catch (Exception)
            {
                MessageBox.Show("Nezadal jsi žádné číslo!");
            }
        }
    }
}
