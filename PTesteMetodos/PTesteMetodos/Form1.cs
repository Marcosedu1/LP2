namespace PTesteMetodos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teclou CTRl+C");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teclou CTRL+V");
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fc = Application.OpenForms["frmExercicio2"];
            if(fc != null)
                fc.Close();

            frmExercicio2 frm2 = new frmExercicio2();
            frm2.MdiParent = this;
            frm2.WindowState = FormWindowState.Maximized;
            frm2.Show();

        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio3 frm3 = new frmExercicio3();
            frm3.MdiParent = this;
            frm3.WindowState = FormWindowState.Maximized;
            frm3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio4 frm4 = new frmExercicio4();
            frm4.MdiParent = this;
            frm4.WindowState = FormWindowState.Maximized;
            frm4.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExercicio5 frm5 = new frmExercicio5();
            frm5.MdiParent = this;
            frm5.WindowState = FormWindowState.Maximized;
            frm5.Show();
        }
    }
}