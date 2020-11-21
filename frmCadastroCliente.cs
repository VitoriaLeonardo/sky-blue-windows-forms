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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        Comandos com = new Comandos ();
        Modelos mod = new Modelos (); 

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarCli_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal principal = new frmMenuPrincipal();
            principal.Show();

            this.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrarCli_Click(object sender, EventArgs e)
        {/*
            try
            {
                //mod.codCli = txtIdCliente.Text;
                mod.nomeCli = txtNomeCliente.Text;
                mod.dataCli = mskDataNascCli.Text;
                mod.telCli = mskTelefoneCliente.Text;
                mod.nacioCli = txtNacionalidade.Text;
                mod.cpfCli = mskCpfCliente.Text;
                mod.emailCli = txtEmailCliente.Text;

                if (mod.nomeCli == "" || mod.emailCli == "" || mod.telCli == "" || mod.cpfCli == "" || mod.dataCli == "" || mod.nacioCli == "")
                {
                    MessageBox.Show("Preencha todos os campos.");
                }

                else if (com.InsereCliente(mod))
                {
                    //txtIdCliente.Text = "";
                    txtNomeCliente.Text = "";
                    mskDataNascCli.Text = "";
                    mskTelefoneCliente.Text = "";
                    txtNacionalidade.Text = "";
                    mskCpfCliente.Text = "";
                    txtEmailCliente.Text = "";

                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
                else {
                    MessageBox.Show("Erro ao cadastrar o cliente!");
                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar!");
            }*/
        }

        private void mskDataNascCli_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCadastrarFunc_Click(object sender, EventArgs e)
        {
            //BtnCadastrarCliente

            try
            {
                //mod.codCli = txtIdCliente.Text;
                mod.nomeCli = txtNomeCliente.Text;
                mod.dataCli = mskDataNascCli.Text;
                mod.telCli = mskTelefoneCliente.Text;
                mod.nacioCli = txtNacionalidade.Text;
                mod.cpfCli = mskCpfCliente.Text;
                mod.emailCli = txtEmailCliente.Text;

                if (mod.nomeCli == "" || mod.emailCli == "" || mod.telCli == "" || mod.cpfCli == "" || mod.dataCli == "" || mod.nacioCli == "")
                {
                    MessageBox.Show("Preencha todos os campos.");
                }

                else if (com.InsereCliente(mod))
                {
                    //txtIdCliente.Text = "";
                    txtNomeCliente.Text = "";
                    mskDataNascCli.Text = "";
                    mskTelefoneCliente.Text = "";
                    txtNacionalidade.Text = "";
                    mskCpfCliente.Text = "";
                    txtEmailCliente.Text = "";

                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o cliente!");
                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }
    }
}
