using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Calcular_IMC : Form
    {
        public Calcular_IMC()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura;
            double peso;
            double IMC;

            if (!double.TryParse(mskbxAlt.Text, out altura))
            {
                MessageBox.Show("Altura Invalida");
                mskbxAlt.Focus();
            }
            else
            {
                if (!double.TryParse(mskbxPeso.Text, out peso))
                {
                    MessageBox.Show("Peso Invalido");
                    mskbxPeso.Focus();
                }
                else
                {
                    IMC = peso / Math.Pow(altura, 2);
                    txtIMC.Text = IMC.ToString();

                    if (IMC < 18.5)
                    {
                        txtClass.Text = "Magreza";
                        txtObes.Text = "0";
                    }
                    else
                    {
                        if (IMC > 18.5 && IMC < 24.9)
                        {
                            txtClass.Text = "Normal";
                            txtObes.Text = "0";
                        }
                        else
                        {
                            if (IMC > 25 && IMC < 29.9)
                            {
                                txtClass.Text = "Sobrepeso";
                                txtObes.Text = "I";
                            }
                            else
                            {
                                if (IMC > 30 && IMC < 39.9)
                                {
                                    txtClass.Text = "Obesidade";
                                    txtObes.Text = "II";
                                }
                                else
                                {
                                    if (IMC > 40)
                                    {
                                        txtClass.Text = "Obesidade Grave";
                                        txtObes.Text = "III";
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskbxPeso.Clear();
            mskbxAlt.Clear();
        }

        private void mskbxAlt_Validated(object sender, EventArgs e)
        {
            double altura;
            if (!double.TryParse(mskbxAlt.Text, out altura))
            {
                MessageBox.Show("Altura Invalida");
            }
        }

        private void mskbxPeso_Validated(object sender, EventArgs e)
        {
            double peso;
            if (!double.TryParse(mskbxPeso.Text, out peso))
            {
                MessageBox.Show("Peso Invalido");
            }
        }

        private void Calcular_IMC_Load(object sender, EventArgs e)
        {

        }
    }
}
