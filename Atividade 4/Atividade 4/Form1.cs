using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_4
{
    public partial class ValidarTriangulo : Form
    {
        public ValidarTriangulo()
        {
            InitializeComponent();
        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double ladoA;
            double ladoB;
            double ladoC;

            if (!double.TryParse(txtLadoA.Text, out ladoA))
            {
                MessageBox.Show("Lado A inválido");
            }
            else
            {
                if (!double.TryParse(txtLadoB.Text, out ladoB))
                {
                    MessageBox.Show("Lado B inválido");
                }
                else
                {
                    if (!double.TryParse(txtLadoC.Text, out ladoC))
                    {
                        MessageBox.Show("Lado C inválido");
                    }
                    else
                    {
                        if (ladoA < (ladoB + ladoC) && ladoA > Math.Abs(ladoB - ladoC) && ladoB < (ladoA + ladoB) && ladoB > Math.Abs(ladoA - ladoC) && ladoC < (ladoA + ladoB) && ladoC > Math.Abs(ladoA - ladoB))
                        {
                            if (ladoA == ladoB && ladoA == ladoC && ladoB == ladoC)
                            {
                                txtTriangulo.Text = "Equilátero";
                            }
                            else
                            {
                                if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
                                {
                                    txtTriangulo.Text = "Escaleno";
                                }
                                else
                                {
                                    txtTriangulo.Text = "Isosceles";
                                }
                            } 
                        }
                        else
                        {
                            MessageBox.Show("Não é um triângulo");
                        }
                    }
                } 
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            txtTriangulo.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLadoA_Validated(object sender, EventArgs e)
        {
            double ladoA;
            if (!double.TryParse(txtLadoA.Text, out ladoA))
            {
                MessageBox.Show("Lado A inválido");
            }
        }

        private void txtLadoB_Validated(object sender, EventArgs e)
        {
            double ladoB;
            if (!double.TryParse(txtLadoB.Text, out ladoB))
            {
                MessageBox.Show("Lado B inválido");
            }
        }

        private void txtLadoC_Validated(object sender, EventArgs e)
        {
            double ladoC;
            if (!double.TryParse(txtLadoC.Text, out ladoC))
            {
                MessageBox.Show("Lado C inválido");
            }
        }
    }
}
