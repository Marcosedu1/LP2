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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string texto = txtTexto.Text;
            texto = texto.ToUpper();
            texto = texto.Replace(" ","");

            if(texto.Length != 0)
            {
                string textoReverso = new string(texto.Reverse().ToArray());

                if (texto == textoReverso)
                    lblResultado.Text = $"O texto é um PALÍNDROMO";
                else
                    lblResultado.Text = $"O texto NÃO é um PALÍNDROMO";
            }
            else
            {
                MessageBox.Show("Digite no campo texto");
            }


        }
    }
}
