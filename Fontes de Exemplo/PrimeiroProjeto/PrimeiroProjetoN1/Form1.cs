using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjetoN1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // este é um comentário
            MessageBox.Show("Boa noite," + textBox1.Text + "\n seja bem-vindo " +
                "  a Fatec ");


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
