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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtNome.Text = txtNome.Text.Trim();
            txtCargo.Text = txtCargo.Text.Trim();
            txtMatricula.Text = txtMatricula.Text.Trim();
            txtProducao.Text = txtProducao.Text.Trim();
            txtSalario.Text = txtSalario.Text.Trim();
            txtGratificacao.Text = txtGratificacao.Text.Trim();

            if(txtNome.Text.Length == 0 || txtCargo.Text.Length == 0 || txtMatricula.Text.Length == 0 || txtProducao.Text.Length == 0 || txtSalario.Text.Length == 0 || txtGratificacao.Text.Length == 0)
            {
                MessageBox.Show("Há campo(s) à ser(em) preenchido(s)");
            }
            else
            {
                string nome = txtNome.Text;
                string cargo = txtCargo.Text;
                int matricula;
                int producao;
                int gratificacao;
                double salario;

                

                if(!int.TryParse(txtMatricula.Text, out matricula) || !int.TryParse(txtProducao.Text, out producao) || !double.TryParse(txtSalario.Text, out salario) || !int.TryParse(txtGratificacao.Text, out gratificacao)){
                    MessageBox.Show("Há campo(s) incorreto(s)");
                }
                else
                {
                    double A = salario;
                    double B = 0;
                    double C = 0;
                    double D = 0;

                    if(producao >= 100)
                    {
                        B = 1;
                        if(producao >= 120)
                        {
                            C = 1;
                            if(producao >= 150)
                            {
                                D = 1;
                            }
                        }
                    }
                    double salarioBruto = A + (A * (0.05 * B + 0.1 * C + 0.1 * D));
                    
                    if(salarioBruto >= 7000)
                    {
                        if(producao < 150 || gratificacao == 0)
                        {
                            salarioBruto = 7000;
                        }
                    }
                    lblResultado.Text = $"O Salario bruto de {nome} é de {salarioBruto}";
                }
            }
        }
    }
}
