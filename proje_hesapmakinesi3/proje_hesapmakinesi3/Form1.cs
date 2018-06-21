using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_hesapmakinesi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sonuc = 0;   // ekranda görünecek
        double hafiza;      // girilen sayılar işlem yapılarak hafızaya alınacak
        string girilen;     // hafızaya alınmadan işleme koyulacak sayı
        char? islem;        // yapılacak işlem
        sbyte sayac = 0;    // Sıfırlandı yazısının ekranda bir süre durup kaybolması için sayac


        private void button1_Click(object sender, EventArgs e)
        {
            girilen = text_girilen.Text;
            if (text_girilen.Text == "0")
            {
                text_girilen.Text = "";
            }
            girilen += "1";
            text_girilen.Text = girilen;
            label_sifirlandi.Visible = false;
            text_girilen.Focus();
            text_girilen.Select(32767, 0);
            button_virgul.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            girilen = text_girilen.Text;
            if (text_girilen.Text == "0")
            {
                text_girilen.Text = "";
            }
            girilen += "2";
            text_girilen.Text = girilen;
            label_sifirlandi.Visible = false;
            text_girilen.Focus();
            text_girilen.Select(32767, 0);
            button_virgul.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            girilen = text_girilen.Text;
            if (text_girilen.Text == "0")
            {
                text_girilen.Text = "";
            }
            girilen += "3";
            text_girilen.Text = girilen;
            label_sifirlandi.Visible = false;
            text_girilen.Select(32767, 0);
            text_girilen.Focus();
            button_virgul.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            girilen = text_girilen.Text;
            if (text_girilen.Text == "0")
            {
                text_girilen.Text = "";
            }
            girilen += "4";
            text_girilen.Text = girilen;
            label_sifirlandi.Visible = false;
            text_girilen.Select(32767, 0);
            text_girilen.Focus();
            button_virgul.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            girilen = text_girilen.Text;
            if (text_girilen.Text == "0")
            {
                text_girilen.Text = "";
            }
            girilen += "5";
            text_girilen.Text = girilen;
            label_sifirlandi.Visible = false;
            text_girilen.Select(32767, 0);
            text_girilen.Focus();
            button_virgul.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            girilen = text_girilen.Text;
            if (text_girilen.Text == "0")
            {
                text_girilen.Text = "";
            }
            girilen += "6";
            text_girilen.Text = girilen;
            label_sifirlandi.Visible = false;
            text_girilen.Select(32767, 0);
            text_girilen.Focus();
            button_virgul.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            girilen = text_girilen.Text;
            if (text_girilen.Text == "0")
            {
                text_girilen.Text = "";
            }
            girilen += "7";
            text_girilen.Text = girilen;
            label_sifirlandi.Visible = false;
            text_girilen.Select(32767, 0);
            text_girilen.Focus();
            button_virgul.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            girilen = text_girilen.Text;
            if (text_girilen.Text == "0")
            {
                text_girilen.Text = "";
            }
            girilen += "8";
            text_girilen.Text = girilen;
            label_sifirlandi.Visible = false;
            text_girilen.Select(32767, 0);
            text_girilen.Focus();
            button_virgul.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            girilen = text_girilen.Text;
            if (text_girilen.Text == "0")
            {
                text_girilen.Text = "";
            }
            girilen += "9";
            text_girilen.Text = girilen;
            label_sifirlandi.Visible = false;
            text_girilen.Select(32767, 0);
            text_girilen.Focus();
            button_virgul.Enabled = true;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            girilen = text_girilen.Text;
            if (text_girilen.Text == "0")
            {
                text_girilen.Text = "";
            }
            girilen += "0";
            text_girilen.Text = girilen;
            label_sifirlandi.Visible = false;
            text_girilen.Focus();
            text_girilen.Select(32767, 0);
            button_virgul.Enabled = true;
        }

        private void button_virgul_Click(object sender, EventArgs e)
        {
            girilen = text_girilen.Text;
            if (text_girilen.Text == ".")
            {
                text_girilen.Text = "";
            }
            girilen += ",";
            text_girilen.Text = girilen;
            label_sifirlandi.Visible = false;
            text_girilen.Focus();
            text_girilen.Select(32767, 0);
            button_virgul.Enabled = false;
        }

        private void button_hesapla_Click(object sender, EventArgs e)
        {
            if (islem == '+')
            {
                sonuc = hafiza + double.Parse(text_girilen.Text);
                text_girilen.Text = sonuc.ToString();
                hafiza = 0;
            }
            if (islem == '-')
            {
                sonuc = hafiza - double.Parse(text_girilen.Text);
                text_girilen.Text = sonuc.ToString();
                hafiza = 0;
            }
            if (islem == '*')
            {
                sonuc = hafiza * double.Parse(text_girilen.Text);
                text_girilen.Text = sonuc.ToString();
                hafiza = 0;
            }
            if (islem == '/')
            {
                sonuc = hafiza / double.Parse(text_girilen.Text);
                text_girilen.Text = sonuc.ToString();
                hafiza = 0;
            }

            girilen = "";
            text_girilen.Focus();
            text_girilen.Select(32767, 0);
        }
        private void button_topla_Click(object sender, EventArgs e)
        {
            if (text_girilen.Text == "")
            {
                MessageBox.Show("Önce sayı giriniz.");
            }
            else
            {
                islem = '+';
            hafiza += Convert.ToDouble(text_girilen.Text);
            text_girilen.Text = "";
            text_girilen.Focus();
            text_girilen.Select(32767, 0);
            }
        }

        private void button_cikar_Click(object sender, EventArgs e)
        {
            if (text_girilen.Text == "")
            {
                MessageBox.Show("Önce sayı giriniz.");
            }
            else { 
            islem = '-';
            hafiza = Convert.ToDouble(text_girilen.Text) - hafiza;
            text_girilen.Text = "";
            text_girilen.Focus();
            text_girilen.Select(32767, 0);
            }
        }
        private void button_carp_Click(object sender, EventArgs e)
        {
            if (text_girilen.Text == "")
            {
                MessageBox.Show("Önce sayı giriniz.");
            }
            else
            {
                if (hafiza == 0)
            {
                hafiza = 1;
            }
            islem = '*';
            hafiza *= Convert.ToDouble(text_girilen.Text);
            text_girilen.Text = "";
            text_girilen.Focus();
            text_girilen.Select(32767, 0);
            }
        }

        private void button_bol_Click(object sender, EventArgs e)
        {
            if (text_girilen.Text == "")
            {
                MessageBox.Show("Önce sayı giriniz.");
            }
            else
            {
                if (hafiza == 0)
            {
                hafiza = 1;
            }
            islem = '/';
            hafiza = Convert.ToDouble(text_girilen.Text) / hafiza;
            text_girilen.Text = "";
            text_girilen.Focus();
            text_girilen.Select(32767, 0);
            }
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            if (text_girilen.Text != "")
            {
                text_girilen.Text = text_girilen.Text.Remove(text_girilen.Text.Length - 1);
            }   //  girilen'deki yazı, girilen'deki yazının uzunluğundan 1 eksiltilmişi olsun.
            // text_girilen.Clear(); tamamını temizlemek için bir seçenek.
            text_girilen.Focus();
            text_girilen.Select(32767, 0);
        }

        private void button_sifirla_Click(object sender, EventArgs e)
        {
            label_sifirlandi.Text = "Sıfırlandı";
            sonuc = 0;
            hafiza = 0;
            sayac = 0;
            girilen = "";
            islem = ' ';
            text_girilen.Text = "";
            timer1.Enabled = true;
            text_girilen.Focus();
            text_girilen.Select(32767, 0);
            label_sifirlandi.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;    //   Sıfırlandı yazısınınn ekranda bir süre kalması için sayac tanımlandı
            if (sayac == 3) // sayac 3 olduğu zaman (3 saniye ekranda kalması için)
            {
                label_sifirlandi.Visible = false;   // label_sifirlandi' nin görünürlüğü false olsun.
            }
            text_girilen.Focus();   // text_girilen'e odaklansın. (Yazıyı seçilmiş hale getirir.)
            text_girilen.Select(32767, 0);  // 32767. index'in sıfırıncı elemanını seç.
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {   // Uygulamayı Türkçe'ye döndür
            button_sil.Font = new Font(button_sil.Font.FontFamily, 12);
            this.Text = "Hesap Makinesi";
            button_sil.Text = "Temizle";
            button_sifirla.Text = "Sıfırla";
            button_hesapla.Text = "Hesapla";
            label_sifirlandi.Text = "Sıfırlandı";
            text_girilen.Focus();
            text_girilen.Select(32767, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {   // Uygulamayı İngilizce'ye çevir
            button_sil.Font = new Font(button_sil.Font.FontFamily, 12);
            this.Text = "Calculator";
            button_sil.Text = "Clear";
            button_sifirla.Text = "Reset";
            button_hesapla.Text = "Calculate";
            label_sifirlandi.Text = "Reseted";
            text_girilen.Focus();
            text_girilen.Select(32767, 0);
        }

        private void text_girilen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {   // Girilen karakter Unicode'a uymuyorsa ve ondalık sisteme uymuyorsa ve girilen karakter "," değilse;

                e.Handled = true;   // Karakteri ele. Yani girilen karakteri yazdırma.
            }
        }

        private void text_girilen_TextChanged(object sender, EventArgs e)
        {
            button_virgul.Enabled = true;   // button_virgul'un aktifliği true oluyor.
        }
    }
}