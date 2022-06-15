﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PFerramenta
{
    public partial class Form1 : Form
    {
        public static SqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                conexao = new SqlConnection("Data Source=ITLNB093\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");

                conexao.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Outros Erros =/" + ex.Message);
            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmFerramenta"];
            if (fc != null)
                fc.Close();

            frmFerramenta frm1 = new frmFerramenta();
            frm1.MdiParent = this;
            frm1.WindowState = FormWindowState.Maximized;
            frm1.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmSobre"];
            if (fc != null)
                fc.Close();

            frmSobre frm2 = new frmSobre();
            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();
        }
    }
}
