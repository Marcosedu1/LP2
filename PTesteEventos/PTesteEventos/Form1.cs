using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("Componente perdeu o foco");
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
           // MessageBox.Show("Componente ganhou o foco");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true; // desativar beep
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if(textBox1.Text =="")
            {
                MessageBox.Show("Nome Vazio!");
                textBox1.Focus(); //volta para o componente textBox1
            }
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            DateTime dtAuxiliar;

            if (!DateTime.TryParse(maskedTextBox1.Text, out dtAuxiliar))
            {
                MessageBox.Show("Data Inválida");
                e.Cancel = true; // volta para o componente maskedtextbox1
            }
        }

        private void maskedTextBox2_Validated(object sender, EventArgs e)
        {
            Double vlrAuxiliar;

            if (!Double.TryParse(maskedTextBox2.Text, out vlrAuxiliar))
            {
                MessageBox.Show("Valor Invalido");
                maskedTextBox2.Focus();
            }
            else
                if(vlrAuxiliar==0)
            {
                MessageBox.Show("Valor não pode ser zero");
                maskedTextBox2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Nome vazio!");
                textBox1.Focus(); // volta para o componente textBox1
            }
            else
            {
                DateTime dtAuxiliar;



                if (!DateTime.TryParse(maskedTextBox1.Text, out dtAuxiliar))
                {
                    MessageBox.Show("Data Inválida");
                    maskedTextBox1.Focus();
                }
                else
                {
                    Double vlrAuxiliar;



                    if (!Double.TryParse(maskedTextBox2.Text, out vlrAuxiliar))
                    {
                        MessageBox.Show("Valor inválido");
                        maskedTextBox2.Focus();
                    }
                    else
                    if (vlrAuxiliar == 0)
                    {
                        MessageBox.Show("Valor nao pode ser zero");
                        maskedTextBox2.Focus();
                    }
                }
            }
        }
    }
}
