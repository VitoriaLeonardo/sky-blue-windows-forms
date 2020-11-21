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

    public partial class frmCadastroPacotes : Form
    {

        public frmCadastroPacotes()
        {
            InitializeComponent();
        }


        Comandos com = new Comandos();
        Modelos mod = new Modelos();

        private void lblNacioCliente_Click(object sender, EventArgs e)
        {

        }

        private void cmbNacioCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mskCpfCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblCpfCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarPacotes_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal principal = new frmMenuPrincipal();
            principal.Show();

            this.Visible = false;
        }

        private void btnCadastrarPacotes_Click(object sender, EventArgs e)
        {

            try
            {
                mod.tipoPac = txtTipoPacotes.Text;
                mod.origemPac= txtOrigemPacotes.Text;
                mod.destinoPac = txtDestinoPacotes.Text;
                mod.quantPasPac = Convert.ToInt32(nmrQuPasCadPac.Text);
                mod.descPac = txtDescricaoPacotes.Text;
                mod.valorPac = mskValorPacotes.Text;

                if (mod.tipoPac == "" || mod.origemPac == "" || mod.destinoPac == "" || mod.descPac == "" || mod.valorPac == "")
                {
                    MessageBox.Show("Preencha todos os campos!");
                }

                else if (mod.quantPasPac > 4)
                {
                    MessageBox.Show("Um pacote tem o limite máximo de 4 passagens.");
                }

                else if (com.InserePacotes(mod))
                {
                    txtTipoPacotes.Text = "";
                    txtOrigemPacotes.Text = "";
                    txtDestinoPacotes.Text = "";
                    nmrQuPasCadPac.Value = 1;
                    txtDescricaoPacotes.Text = "";
                    mskValorPacotes.Text = "";
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }

                else
                {
                    
                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NmrQuPasCadPac_ValueChanged(object sender, EventArgs e)
        {
        }

        private void FrmCadastroPacotes_Load(object sender, EventArgs e)
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
    }
}
