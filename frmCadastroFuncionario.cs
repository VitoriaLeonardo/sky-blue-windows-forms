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
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
        }

        Comandos com = new Comandos();
        Modelos mod = new Modelos();

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal principal = new frmMenuPrincipal();
            principal.Show();

            this.Visible = false;
        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            try
            {
                //mod.codFunc = txtIdFunc.Text;
                mod.nomeFunc = txtNomeFunc.Text;
                mod.emailFunc = txtEmailFunc.Text;
                mod.telFunc = mskTelefoneFunc.Text;
                mod.cpfFunc = mskCpfFunc.Text;

                if (mod.nomeFunc == "" || mod.emailFunc == "" || mod.telFunc == "" || mod.cpfFunc == "")
                {
                    MessageBox.Show("Preencha todos os campos!");
                }

                else if (com.InsereFuncionario(mod))
                {

                    //txtIdFunc.Text = "";
                    txtNomeFunc.Text = "";
                    txtEmailFunc.Text = "";
                    mskTelefoneFunc.Text = "";
                    mskCpfFunc.Text = "";

                    MessageBox.Show("Cadastro realizado com sucesso!");
                }

            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }

        private void tctNomeFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
