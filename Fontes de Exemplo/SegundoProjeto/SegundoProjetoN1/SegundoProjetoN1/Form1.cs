using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoProjetoN1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                // (textBox1.TextLength==0) 
                // (textBox1.Text==String.Empty)
                MessageBox.Show("Nome está vazio");
            else
                MessageBox.Show("O nome do aluno é:" + textBox1.Text);   
            
            if (comboBox1.SelectedIndex==-1)
                MessageBox.Show("Cidade não selecionada!");
            else
                MessageBox.Show("A cidade do aluno é:"+comboBox1.SelectedItem);


            MessageBox.Show("A turma do aluno é:" + listBox1.SelectedItem);

            //if (checkBox1.Checked)
            //    MessageBox.Show("Aluno veio transferido");
            //else
            //    MessageBox.Show("Aluno não veio transferido");


            if (checkBox1.CheckState==CheckState.Checked)
                MessageBox.Show("Aluno veio transferido");
            else if (checkBox1.CheckState==CheckState.Unchecked)
                MessageBox.Show("Aluno não veio transferido");
            else
                MessageBox.Show("Indeterminado");


            if (radioButton1.Checked)
                MessageBox.Show("Feminino");
            else
                MessageBox.Show("Masculino");

            for (var i=0; i<checkedListBox1.CheckedItems.Count; i++)
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("1º Semestre Manhã");
            listBox1.Items.Add("2º Semestre Manhã");
            listBox1.Items.Add("1º Semestre Noite");
            listBox1.Items.Add("2º Semestre Noite");

            listBox1.SelectedIndex = 0;


        }

      

        private void marcaTudo_CheckedChanged(object sender, EventArgs e)
        {
            if (marcaTudo.Checked)
            {

                for (var i = 0; i < checkedListBox1.Items.Count; i++)

                    checkedListBox1.SetItemChecked(i, true);
            }
            else
            {
                for (var i = 0; i < checkedListBox1.Items.Count; i++)

                    checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
