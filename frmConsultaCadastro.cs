using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeTurismo
{
    public partial class frmConsultaCadastro : Form
    {
        public frmConsultaCadastro()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente consCli = new frmConsultaCliente();
            consCli.Show();

            this.Visible = false;
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            frmConsultaFuncionario consFunc = new frmConsultaFuncionario();
            consFunc.Show();

            this.Visible = false;
        }

        private void btnPacotes_Click(object sender, EventArgs e)
        {
            frmConsultaPacotes consPac = new frmConsultaPacotes();
            consPac.Show();

            this.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal principal = new frmMenuPrincipal();
            principal.Show();

            this.Visible = false;

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
