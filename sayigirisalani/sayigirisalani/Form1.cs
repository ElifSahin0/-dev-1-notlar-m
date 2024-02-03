using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayigirisalani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            listBox1.Items.Add(Convert.ToInt16(rnd.Next(0, 9)));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            listBox2.Items.Add(Convert.ToInt16(rnd.Next(10, 99)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            listBox3.Items.Add(Convert.ToInt16(rnd.Next(100, 999)));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            listBox4.Items.Add(Convert.ToInt32(rnd.Next(1000, 9999)));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            listBox5.Items.Add(Convert.ToInt32(rnd.Next(10000, 99999)));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
           for (int i = 1;i>=5; i++) 
            {
                if (i == 1) {
                    Random rnd = new Random();
                    listBox1.Items.Add(Convert.ToInt32(rnd.Next(0, 9)));
                }
                else if (i == 2) {
                    Random rnd = new Random();
                    listBox2.Items.Add(Convert.ToInt32(rnd.Next(10, 99))); }

                    else if (i == 3)
                {
                    Random rnd = new Random();
                        listBox3.Items.Add(Convert.ToInt16(rnd.Next(100, 999)));
                    }
             else   if (i == 4 )
                    {
                        Random rnd = new Random();
                    listBox4.Items.Add(Convert.ToInt32(rnd.Next(1000, 9999)));

                    }
                else if ( i == 5 )
                {

                    Random rnd = new Random();
                    listBox5.Items.Add(Convert.ToInt32(rnd.Next(10000,99999)));
                }
                }
            }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
        }

        

        private void button11_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                toplam += Convert.ToDouble(listBox2.Items[i]);
            }
            label9.Text = "Toplam : " + toplam;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                toplam += Convert.ToDouble(listBox3.Items[i]);
            }
            label11.Text = "Toplam : " + toplam;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                toplam += Convert.ToDouble(listBox4.Items[i]);
            }
            label13.Text = "Toplam : " + toplam;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i = 0; i < listBox5.Items.Count; i++)
            {
                toplam += Convert.ToDouble(listBox5.Items[i]);
            }
            label15.Text = "Toplam : " + toplam;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                toplam += Convert.ToDouble(listBox1.Items[i]);
            }
            label7.Text = "Toplam : " + toplam;
        }
    }

 

    }

