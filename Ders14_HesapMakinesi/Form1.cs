using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders14_HesapMakinesi
{
    public partial class Özgür : Form
    {
        public Özgür()
        {
            InitializeComponent();
        }
        double value = 0;
        string operation = ""; // +,-,*,/ bunlardan hangisine tıkladı onu burada tutuyoruz
        bool operation_pressed = false; // 

        //bütün rakamlar için buraya gelelim
        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txt_Sonuc.Text = "0";
            value= 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Rakam butonuna tıkladın");
          

            if ((txt_Sonuc.Text == "0") || operation_pressed == true )
            {
                txt_Sonuc.Clear();
            }

             operation_pressed = false;

            Button b = (Button)sender; //convertToButton oldu!
            //MessageBox.Show(b.Text);
            txt_Sonuc.Text += b.Text;
        }


        // +,-,*,/ butonları tıklanınca buraya gelecek
        private void button3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(txt_Sonuc.Text);
            operation_pressed |= true;
        }


        // CE
        private void btn_CE_Click(object sender, EventArgs e)
        {
            txt_Sonuc.Clear();
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txt_Sonuc.Text = (value + double.Parse(txt_Sonuc.Text)).ToString();
                break;

                case "-":
                    txt_Sonuc.Text = (value - double.Parse(txt_Sonuc.Text)).ToString();
                    break;

                case "*":
                    txt_Sonuc.Text = (value * double.Parse(txt_Sonuc.Text)).ToString();
                    break;

                case "/":
                    txt_Sonuc.Text = (value / double.Parse(txt_Sonuc.Text)).ToString();
                    break;
            }



        }
    }
}
