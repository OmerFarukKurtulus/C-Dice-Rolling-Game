using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// mod +1
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int zar1, zar2, zar;
        static int sayac = 1;
        static int first_start = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            if (first_start != 0)
            {
                
                if (sayac % 2 == 1)
                {
                    
                    zar1 = r.Next(1, 7);
                    zar2 = r.Next(1, 7);
                    label1.Text = zar1.ToString();
                    label2.Text = zar2.ToString();
                    zar = zar1 + zar2;
                    if ((progressBar1.Value + zar) >= progressBar1.Maximum)
                    {
                       
                        progressBar1.Value = progressBar1.Maximum;
                        MessageBox.Show("Oyuncu 1 oyunu kazandý");
                        progressBar1.Value = 0;
                        progressBar2.Value = 0;
                        sayac = 1;
                        label1.Text = "";
                        label2.Text = "";
                    }
                    else
                    {
                        
                        progressBar1.Value += zar;
                        sayac++;
                    }

                    label5.Text = progressBar1.Value.ToString();


                }
                else
                {
                   
                    zar1 = r.Next(1, 7);
                    zar2 = r.Next(1, 7);
                    label1.Text = zar1.ToString();
                    label2.Text = zar2.ToString();
                    zar = zar1 + zar2;
                    if ((progressBar2.Value + zar) >= progressBar2.Maximum)
                    {
                       
                        progressBar2.Value = progressBar2.Maximum;
                        MessageBox.Show("Oyuncu 1 oyunu kazandý");
                        progressBar1.Value = 0;
                        progressBar2.Value = 0;
                        sayac = 1;
                        label1.Text = "";
                        label2.Text = "";
                    }
                    else
                    {
                        
                        progressBar2.Value += zar;
                        sayac++;
                    }

                    label6.Text = progressBar2.Value.ToString();


                }
            }
            else
            {
             
                zar1 = r.Next(1, 7);
                zar2 = r.Next(1, 7);
                label1.Text = zar1.ToString();
                label2.Text = zar2.ToString();
                if (zar1 == zar2)
                {
                    MessageBox.Show("Zarlarý Tekrar Atýnýz");
                }
                else if (zar1 > zar2)
                {
                    sayac = 1;
                    first_start = 1;
                    MessageBox.Show("Oyuncu 1 Baþlýyor");
                }
                else if (zar1 < zar2)
                {
                    sayac = 2;
                    first_start = 1;
                    MessageBox.Show("Oyuncu 2 Baþlýyor");
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
