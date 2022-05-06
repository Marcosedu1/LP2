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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;

            if(txtNumero1.Text.Length == 0 || txtNumero2.Text.Length == 0)
            {
                MessageBox.Show("Insira o primeiro e segundo número");
            }else if(!int.TryParse(txtNumero1.Text, out numero1) == true)
            {
                MessageBox.Show("Não é um numero");
            }else if(!int.TryParse(txtNumero2.Text, out numero2) == true)
            {
                MessageBox.Show("Não é um numero");
            }else if(numero1 > numero2 || numero1 == numero2)
            {
                MessageBox.Show("Primeiro numero não pode ser menor ou igual ao segundo");
            }else
            {
                var numeroAleatorio = new Random();
                lblResultado.Text = Convert.ToString(numeroAleatorio.Next(numero1, numero2));
            }

        }
    }
}
