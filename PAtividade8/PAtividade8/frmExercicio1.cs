using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text;
            int espacosBranco = 0;
            
            if(texto.Length < 100)
            {
                MessageBox.Show("Digite pelo menos 100 caracteres");
            }
            else
            {
                texto = texto.ToUpper();
                char[] textoArray = texto.ToCharArray();

                foreach(char c in textoArray)
                {
                    if(char.IsWhiteSpace(c) == true)
                    {   
                        espacosBranco++;
                    }
                }
                lblResultado.Text = $"Existem {espacosBranco} espaços em branco no texto!";
            }
        }

        private void btnContarR_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text;
            int letrasR = 0;

            texto = texto.ToUpper();
            char[] textoArray = texto.ToCharArray();
            int c = 0;
            while(c < texto.Length)
            {
                if (textoArray[c] == 'R')
                {
                   letrasR++;
                }
                c++;
            }
           lblResultado.Text = $"Existem {letrasR} letras R no texto!";
            
        }

        private void btnContarPares_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text;
            char[] textoArray = texto.ToCharArray();
            int pares = 0;

            texto = texto.Replace(" ", "");
            texto = texto.ToUpper();

            for (int c = 1; c < texto.Length; c++)
            {
                if (textoArray[c] == textoArray[c - 1])
                {
                    pares++;
                }
            }
            lblResultado.Text = $"Existem {pares} pares de caracteres";
            
        }
    }
}
