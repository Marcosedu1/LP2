using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double numero1;

            if (!Double.TryParse(textBox1.Text, out numero1))
            {
                MessageBox.Show("Numero 1 invalido");
                textBox1.Focus();
            }
            else
            {
                double numero2;

                if (!Double.TryParse(textBox2.Text, out numero2))
                {
                    MessageBox.Show("Numero 2 invalido");
                    textBox2.Focus();
                }
                else
                {
                    double resultado;
                    resultado = numero1 * numero2;
                    textBox3.Text = resultado.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double numero1;

            if (!Double.TryParse(textBox1.Text, out numero1))
            {
                MessageBox.Show("Numero 1 invalido");
                textBox1.Focus();
            }
            else
            {
                double numero2;

                if (!Double.TryParse(textBox2.Text, out numero2))
                {
                    MessageBox.Show("Numero 2 invalido");
                    textBox2.Focus();
                }
                else
                {
                    double resultado;
                    resultado = numero1 + numero2;
                    textBox3.Text = resultado.ToString();
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double numero1;

            if (!Double.TryParse(textBox1.Text, out numero1))
            {
                MessageBox.Show("Numero 1 invalido");
                textBox1.Focus();
            }
            else
            {
                double numero2;

                if (!Double.TryParse(textBox2.Text, out numero2))
                {
                    MessageBox.Show("Numero 2 invalido");
                    textBox2.Focus();
                }
                else
                {
                    double resultado;
                    resultado = numero1 - numero2;
                    textBox3.Text = resultado.ToString();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double numero1;

            if (!Double.TryParse(textBox1.Text, out numero1))
            {
                MessageBox.Show("Numero 1 invalido");
                textBox1.Focus();
            }
            else
            {
                double numero2;

                if (!Double.TryParse(textBox2.Text, out numero2))
                {
                    MessageBox.Show("Numero 2 invalido");
                    textBox2.Focus();
                }
                else
                {
                    if(numero2 == 0)
                    {
                        MessageBox.Show("Não pode divir por 0");
                    }
                

                else
                {
                    double resultado;
                    resultado = numero1 / numero2;
                    textBox3.Text = resultado.ToString();
                }
            }

        }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            double numero1;

            if (!Double.TryParse(textBox1.Text, out numero1))
            {
                MessageBox.Show("Numero 1 invalido");
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            double numero2;

            if (!Double.TryParse(textBox2.Text, out numero2))
            {
                MessageBox.Show("Numero 2 invalido");
            }
        }
    }
}
