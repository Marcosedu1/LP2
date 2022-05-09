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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            double numeroN;
            double numeroH = 0;
            if(!double.TryParse(txtNumero.Text, out numeroN))
            {
                MessageBox.Show("Não é um número!");
            }
            else if(numeroN <= 0)
            {
                MessageBox.Show("Número não pode ser negativo ou zero");
            }else
            {
                for(double i = 1; i <= numeroN; i++)
                {
                    numeroH =numeroH + (1 / i);
                }
                lblResultado.Text = $"O Numero H é : {numeroH}";
            }
        }
    }
}
