using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psalario
{
    public partial class Atividade5 : Form
    {
        public Atividade5()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxNumFilhos.SelectedIndex = 0;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescIrpf_Click(object sender, EventArgs e)
        {

        }

        private void lblDescInss_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            double salBruto;
            int filhos = cbxNumFilhos.SelectedIndex;
            double descontoInss = 0;
            double descontoIrpf = 0;
            double salFamilia = 0;
            double salLiquido = 0;

            string sexo;
            string casado;

            if (nome == "")
            {
                MessageBox.Show("Nome Vazio!");
                txtNome.Focus();
            }
            else if (!double.TryParse(mskbxSalBruto.Text, out salBruto))
            {
                MessageBox.Show("Salario Bruto inválido");
                mskbxSalBruto.Focus();
            }
            else
            {
                if (salBruto <= 800.47)
                {
                    txtInss.Text = "7,65%";
                    descontoInss = salBruto * 0.0765;
                    txtDescInss.Text ="R$ "+descontoInss.ToString("N2");
                }
                else if (salBruto <= 1050)
                {
                    txtInss.Text = "8,65%";
                    descontoInss = salBruto * 0.0865;
                    txtDescInss.Text ="R$ "+descontoInss.ToString("N2");
                }
                else if (salBruto <= 1400.77)
                {
                    txtInss.Text = "9%";
                    descontoInss = salBruto * 0.09;
                    txtDescInss.Text ="R$ "+descontoInss.ToString("N2");
                }
                else if (salBruto <= 2801.56)
                {
                    txtInss.Text = "11%";
                    descontoInss = salBruto * 0.11;
                    txtDescInss.Text ="R$ "+descontoInss.ToString("N2");
                }
                else if (salBruto > 2801.56)
                {
                    txtInss.Text = "R$ 308,17 (TETO)";
                    descontoInss = 308.17;
                    txtDescInss.Text ="R$ " + descontoInss.ToString("N2");
                }

                if (salBruto <= 1257.12)
                {
                    txtIrpf.Text = "Isento";
                    descontoIrpf = 0;
                    txtDescIrpf.Text = "R$ " + descontoIrpf.ToString("N2");
                }
                else if (salBruto <= 2512.08)
                    {
                        txtIrpf.Text = "15%";
                        descontoIrpf = salBruto * 0.15;
                        txtDescIrpf.Text = "R$ " + descontoIrpf.ToString("N2");
                    }
                    else if (salBruto > 2512.08)
                     {
                        txtIrpf.Text = "27.5%";
                        descontoIrpf = salBruto * 0.275;
                        txtDescIrpf.Text = "R$ " + descontoIrpf.ToString("N2");
                     }

                if (salBruto <= 435.52)
                {

                    salFamilia = 22.33 * filhos;
                    txtSalFamilia.Text = "R$ " + salFamilia.ToString("N2");
                }
                else
                {
                    if (salBruto <= 654.61)
                    {
                        salFamilia = 15.74 * filhos;
                        txtSalFamilia.Text = "R$ " + salFamilia.ToString("N2");
                    }
                    else
                    {
                        if (salBruto > 654.61)
                        {
                            salFamilia = 0;
                            txtSalFamilia.Text = "R$ " + salFamilia.ToString("N2");
                        }
                    }
                }
                salLiquido = salBruto - descontoInss - descontoIrpf + salFamilia;
                txtSalLiquido.Text = "R$ " + salLiquido.ToString("N2");

                if (rbtnFem.Checked)
                {
                    sexo = "da Sra";
                    if (ckbxCasado.Checked)
                    {
                        casado = "casada";
                    }
                    else
                    {
                        casado = "solteira";
                    }
                }
                else
                {
                    sexo = "do Sr";
                    if (ckbxCasado.Checked)
                    {
                        casado = "casado";
                    }
                    else
                    {
                        casado = "solteiro";
                    }
                }

                lblDados.Text = "O salario liquido " + sexo + " " + nome + " que é " + casado + ", e que possui " + filhos + " filhos, é de R$ " + salLiquido.ToString("N2");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            mskbxSalBruto.Clear();
            cbxNumFilhos.SelectedIndex = 0;
            txtInss.Clear();
            txtIrpf.Clear();
            txtSalFamilia.Clear();
            txtSalLiquido.Clear();
            txtDescInss.Clear();
            txtDescIrpf.Clear();
            lblDados.Text = "Dados";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtnFem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_Validated(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            if (nome == "")
            {
                MessageBox.Show("Nome Vazio!");
            }
        }

        private void mskbxSalBruto_Validated(object sender, EventArgs e)
        {
            double salBruto;
            if (!double.TryParse(mskbxSalBruto.Text, out salBruto))
            {
                MessageBox.Show("Salario Bruto inválido");
            }
        }
    }
}