using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoğruEnerjiParaGetirir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasa = 0;
        int enerji = 100;
        private void button1_Click(object sender, EventArgs e)
        {
            kasa += 300;
            enerji -= 20;
            textBox1.Text = Convert.ToString(kasa);
            progressBar1.Value = enerji;

            if (enerji <= 0)
            {
                MessageBox.Show("Enerji tükendi!");
                
            }

            if (kasa <= 0)
            {
                MessageBox.Show("Tüm paran tükendi.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kasa += 600;
            enerji -= 40;
            textBox1.Text = Convert.ToString(kasa);
            progressBar1.Value = enerji;

            if (enerji <= 0)
            {
                MessageBox.Show("Enerji tükendi!");

            }

            if (kasa <= 0)
            {
                MessageBox.Show("Tüm paran tükendi.");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            kasa += 1200;
            enerji -= 80;
            textBox1.Text = Convert.ToString(kasa);
            progressBar1.Value = enerji;

            if (enerji <= 0)
            {
                MessageBox.Show("Enerji tükendi!");

            }

            if (kasa <= 0)
            {
                MessageBox.Show("Tüm paran tükendi.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kasa -= 400;
            enerji += 30;
            textBox1.Text = Convert.ToString(kasa);
            progressBar1.Value = enerji;

            if (enerji <= 0)
            {
                MessageBox.Show("Enerji tükendi!");

            }

            if (kasa <= 0)
            {
                MessageBox.Show("Tüm paran tükendi.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kasa -= 600;
            enerji += 50;
            textBox1.Text = Convert.ToString(kasa);
            progressBar1.Value = enerji;

            if (enerji <= 0)
            {
                MessageBox.Show("Enerji tükendi!");

            }

            if (kasa <= 0)
            {
                MessageBox.Show("Tüm paran tükendi.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kasa -= 1000;
            enerji += 130;
            textBox1.Text = Convert.ToString(kasa);
            progressBar1.Value = enerji;

            if (enerji <= 0)
            {
                MessageBox.Show("Enerji tükendi!");

            }

            if (kasa <= 0)
            {
                MessageBox.Show("Tüm paran tükendi.");
            }
        }
    }
}
