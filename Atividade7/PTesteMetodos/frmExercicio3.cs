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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemoveOcorrencia_Click(object sender, EventArgs e)
        {
            int posicao = 0;

            txtPalavra1.Text = txtPalavra1.Text.ToUpper(); //Deixa tudo em maiusculo
            txtPalavra2.Text = txtPalavra2.Text.ToUpper();  //Deixa tudo em maiusculo

            //r                  o                tec
            //arara             sorocaba         fatec

            posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while(posicao >= 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) + txtPalavra2.Text.Substring(posicao + txtPalavra1.Text.Length, txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            txtPalavra1.Text = txtPalavra1.Text.ToUpper();
            txtPalavra2.Text = txtPalavra2.Text.ToUpper();

            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text,"");
        }

        private void btnReverte_Click(object sender, EventArgs e)
        {
            string s = txtPalavra1.Text;
            char[] arr = s.ToCharArray(); // joga a string para um array
            Array.Reverse(arr); // invertendo o array

            s = "";

            foreach(char cara in arr)
            {
                s = s + cara.ToString();
            }

            txtPalavra2.Text = s;
        }
    }
}
