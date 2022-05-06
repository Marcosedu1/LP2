using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTesteMetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text;
            char[] textoCharArray = texto.ToArray();
            int qtdeLetras = 0;

            if(txtTexto.Text.Length != 0)
            {
                foreach (char c in textoCharArray)
                {
                    if (char.IsLetter(c) == true)
                    {
                        qtdeLetras++;
                    }

                    lblResultado.Text = $"Existem {qtdeLetras} caracteres alfabeticos digitados no texto";
                }
            }
            else
            {
                MessageBox.Show("Texto está vazio");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text;
            char[] textoCharArray = texto.ToCharArray();
            int qtdeNumeros = 0;

            if(texto.Length != 0)
            {
                for (int i = 0; i < textoCharArray.Length; i++)
                {
                    char c = textoCharArray[i];
                    if (char.IsNumber(c) == true)
                    {
                        qtdeNumeros++;
                    }
                }

                lblResultado.Text = $"Existem {qtdeNumeros} caracteres numéricos digitados no texto.";
            }
            else
            {
                MessageBox.Show("Texto está vazio");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text;
            char[] textoCharArray = texto.ToCharArray();
            int posicao = 0;

            if (txtTexto.Text.Length == 0)
            {
                MessageBox.Show("Texto está vazio");
            }
            else
            {
                while (char.IsWhiteSpace(textoCharArray[posicao]) != true)
                {
                    posicao++;
                }
                posicao++;
                lblResultado.Text = $"O primeiro espaço em branco fica na {posicao}ª posição";

            }

        }
    }
}
