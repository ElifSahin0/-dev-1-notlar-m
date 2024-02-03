using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magaza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (listBox1.Text=="")
                label12.Text = "0";
             else if (listBox1.Text=="Oversize V Yaka Kazak")
                label12.Text = "250";
            else if (listBox1.Text == "Balıkçı Yaka Crop Kazak")
                label12.Text = "180";
            else if (listBox1.Text == "Kruvaze Yaka Kazak")
                label12.Text = "280";
            else if (listBox1.Text == "Damla Yaka Kazak")
                label12.Text = "195";
            else if (listBox1.Text == "Kalp Yaka Kazak")
                label12.Text = "285";
            else if (listBox1.Text == "V Yaka Kazak")
                label12.Text = "235";
            else if (listBox1.Text == "Triko Kazak")
                label12.Text = "168";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.Text == "")
                label13.Text = "0";
            if (listBox2.Text == "Oversize V Yakalı TShirt")
                label13.Text = "250";
            else if (listBox2.Text == "Crop Bisiklet Yakalı TShirt")
                label13.Text = "180";
            else if (listBox2.Text == "Standart V Yakalı TShirt")
                label13.Text = "145";
            else if (listBox2.Text == "Crop Damla Yakalı Tshirt")
                label13.Text = "180";
            else if (listBox2.Text == "Kalp Yaka Uzun Kollu Karpuz Kollu Bluz")
                label13.Text = "200";
            else if (listBox2.Text == "Oversize V Yakalı Uzun Kollu Bluz")
                label13.Text = "165";
            else if (listBox2.Text == "Tül Detaylı Crop Bluz")
                label13.Text = "160";
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.Text == "")
                label15.Text = "0";
            if (listBox3.Text == "Mini Elbise")
                label15.Text = "165";
           else if(listBox3.Text == "Triko Mini Elbise")
                label15.Text = "230";
           else if(listBox3.Text == "Kaşkorse Midi Elbise")
                label15.Text = "200";
           else if(listBox3.Text == "Fit Simli Midi Elbise")
                label15.Text = "235";
            else if (listBox3.Text == "Abiye Tüllü Elbise")
                label15.Text = "245";
            else if (listBox3.Text == "Kalp Yaka Mini Elbise")
                label15.Text = "185";
            else if (listBox3.Text == "Abiye Taşlı Elbise")
                label15.Text = "450";
            else if (listBox3.Text == "Tüy Detaylı Abiye Elbise")
                label15.Text = "485";
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.Text == "")
                label14.Text = "0";
            else if (listBox4.Text == "Mini Şort Etek")
                label14.Text = "195";
            else if (listBox4.Text == "Triko Midi Etek")
                label14.Text = "168";
            else if (listBox4.Text == "Kalem Midi Etek")
                label14.Text = "180";
            else if (listBox4.Text == "Pileli Mini Etek")
                label14.Text = "200";
            else if (listBox4.Text == "Çiçek Desenli Pileli Uzun Etek")
                label14.Text = "285";
            else if (listBox4.Text == "Etnik Desenli Bol Fırfırlı Etek")
                label14.Text ="340";

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox5.Text == "")
                label16.Text = "0";
          else  if (listBox5.Text == "Kelebekli Jeans Pantolon")
                label16.Text = "415";
            else if (listBox5.Text == "Straight Jeans Pantolon")
                label16.Text = "375";
            else if (listBox5.Text == "Boyfriend Jeans")
                label16.Text = "340";
            else if (listBox5.Text == "Kumaş Kemer Detaylı Pantolon")
                label16.Text = "280";
            else if (listBox5.Text == "Triko Pantolon")
                label16.Text = "275";
            else if (listBox5.Text == "İspanyol Paça Uzun Pantolon")
                label16.Text = "240";
            else if (listBox5.Text == "Taş Detaylı Pantolon")
                label16.Text = "350";
            else if (listBox5.Text == "Yırtık Pantolon")
                label16.Text = "385";
            else if (listBox5.Text == "Kargo Pantolon")
                label16.Text = "400";

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox6.Text == "")
                label18.Text = "0";
           else if (listBox6.Text == "Bol Eşofman")
                label18.Text = "240";
            else if (listBox6.Text == "Cep Detaylı Eşofman")
                label18.Text = "190";
            else if (listBox6.Text == "Yırtmaçlı Eşofman")
                label18.Text = "175";
            else if (listBox6.Text == "Uzay Detaylı Eşofman")
                label18.Text = "245";
            else if (listBox6.Text == "Fit Eşofman")
                label18.Text = "200";
            else if (listBox6.Text == "Bağcıklı Eşofman")
                label18.Text = "215";
            else if (listBox6.Text == "Lastikli Eşofman")
                label18.Text = "180";

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox7.Text == "")
                label17.Text = "0";
           else if (listBox7.Text == "Bot")
                label17.Text = "1300";
            else if (listBox7.Text == "Çizme")
                label17.Text = "1600";
            else if (listBox7.Text == "Stiletto Topuklu Ayakkabı")
                label17.Text = "550";
            else if (listBox7.Text == "Dolgu Topuk Topuklu Ayakkabı")
                label17.Text = "475";
            else if (listBox7.Text == "Spor Ayakkabı")
                label17.Text = "1450";
            else if (listBox7.Text == "Yürüyüş Ayakkabısı")
                label17.Text = "1750";
            else if (listBox7.Text == "Babet")
                label17.Text = "400";
            else if (listBox7.Text == "Sneaker")
                label17.Text = "1900";



        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (listBox8.Text == "")
                label20.Text = "0";
            else if (listBox8.Text == "Sırt Çantası")
                label20.Text = "630";
           else if (listBox8.Text == "Kol Çantası")
                label20.Text = "450";
            else if (listBox8.Text == "El Çantası")
                label20.Text = "380";
            else if (listBox8.Text == "Omuz Çantası")
                label20.Text = "350";
            else if (listBox8.Text == "Bavul")
                label20.Text = "1350";
            else if (listBox8.Text == "Makyaj Çantası")
                label20.Text = "180";
            else if (listBox8.Text == "Cüzdan")
                label20.Text = "300";
            else if (listBox8.Text == "Laptop Çantası")
                label20.Text = "950";

        } 

        private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox9.Text == "")
                label19.Text = "0";
           else if (listBox9.Text == "Küpe")
                label19.Text = "35";
            else if (listBox9.Text == "Kolye")
                label19.Text = "65";
            else if (listBox9.Text == "Bileklik")
                label19.Text = "50";
            else if (listBox9.Text == "Yüzük")
                label19.Text = "40";
            else if (listBox9.Text == "Halhal")
                label19.Text = "45";
            else if (listBox9.Text == "Taç")
                label19.Text = "60";
            else if (listBox9.Text == "Toka")
                label19.Text = "35";
            else if (listBox9.Text == "Bere")
                label19.Text = "65";


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int toplam = 0;


            if (listBox1.Text !="")
                listBox11.Items.Add(listBox1.Text +" "+label12.Text );
            if (listBox2.Text != "")    
                listBox11.Items.Add(listBox2.Text + " " + label13.Text);
            if (listBox3.Text != "")
                listBox11.Items.Add(listBox3.Text + " " + label15.Text);
            if (listBox4.Text != "")
                listBox11.Items.Add(listBox4.Text + " " + label14.Text);
            if (listBox5.Text != "")
                listBox11.Items.Add(listBox5.Text + " " + label16.Text);
            if (listBox6.Text != "")
                listBox11.Items.Add(listBox6.Text + " " + label18.Text);
            if (listBox7.Text != "")
                listBox11.Items.Add(listBox7.Text + " " + label17.Text);
            if (listBox8.Text != "")
                listBox11.Items.Add(listBox8.Text + " " + label20.Text);
            if (listBox9.Text != "")
                listBox11.Items.Add(listBox9.Text + " " + label19.Text);

            toplam=int.Parse(label12.Text)+int.Parse(label13.Text)+int.Parse(label14.Text)+int.Parse(label15.Text)+int.Parse(label16.Text)+int.Parse(label17.Text)+int.Parse(label18.Text)+int.Parse(label19.Text)+int.Parse(label20.Text);
            textBox1.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox11.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplam = 0, ogrenci, indirimli, personel, odenecektutar;
            toplam = double.Parse(textBox1.Text);

            if (checkBox1.Checked)
                ogrenci = toplam / 20;
      
            else
                ogrenci = 0;

            if (toplam>=250)
                indirimli = toplam / 10;
            
            else
                indirimli = 0;

            if (checkBox2.Checked)
                personel = toplam / 5;

            else
                personel = 0;

            odenecektutar =toplam - personel- indirimli - ogrenci;
          
            richTextBox1.Text = "Ürünleriniz:\n";
            
            richTextBox1.Text += "";
            richTextBox1.Text += "Öğrenci İndirimi =" + ogrenci + "\n";
            richTextBox1.Text += "İndirimli Tutar =" + indirimli + "\n";
            richTextBox1.Text += "Personel İndirimi =" + personel + "\n";
            richTextBox1.Text += "____________________________________\n";
            richTextBox1.Text += "";
            richTextBox1.Text += "Ödenecek Tutar =" + odenecektutar;

            
        }
    }



}
