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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            this.Hide();
            menu.Show();
            /*
            Controle controle = new Controle();
            controle.Acessar(txtUsuarioLogin.Text, txtSenhaLogin.Text);
            if (controle.mensagem.Equals(""))
                if (controle.T)
                {
                    MessageBox.Show("Usuario Logado com Sucesso", "Logado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    frmMenuPrincipal menu = new frmMenuPrincipal();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario/Senha Invalidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }*/
        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {
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
