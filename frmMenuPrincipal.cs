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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastroFunc_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario funcionario = new frmCadastroFuncionario();
            funcionario.Show();

            this.Visible = false;
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cliente = new frmCadastroCliente();
            cliente.Show();

            this.Visible = false;

        }

        private void btnCadastroPacotes_Click(object sender, EventArgs e)
        {
            frmCadastroPacotes pacotes = new frmCadastroPacotes();
            pacotes.Show();

            this.Visible = false;
        }

        private void funciónarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionario funcionario = new frmCadastroFuncionario();
            funcionario.Show();

            this.Visible = false;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente cliente = new frmCadastroCliente();
            cliente.Show();

            this.Visible = false;
        }

        private void pacotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPacotes pacotes = new frmCadastroPacotes();
            pacotes.Show();

            this.Visible = false;
        }

        private void btnConsultasCadastros_Click(object sender, EventArgs e)
        {
            frmConsultaCadastro cadastros = new frmConsultaCadastro();
            cadastros.Show();

            this.Visible = false;
        }

        private void btnConsultasReservas_Click(object sender, EventArgs e)
        {
            frmConsultaReserva reserva = new frmConsultaReserva();
            reserva.Show();

            this.Visible = false;
        }

        private void cadastrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCadastro cadastros = new frmConsultaCadastro();
            cadastros.Show();

            this.Visible = false;
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaReserva reservas = new frmConsultaReserva();
            reservas.Show();

            this.Visible = false;
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();

            this.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmConsultaVenda consVenda = new frmConsultaVenda();
            consVenda.Show();

            this.Visible = false;
        }

        private void BtnAgendaReservas_Click(object sender, EventArgs e)
        {
            frmAgendaReserva reserva = new frmAgendaReserva();
            reserva.Show();

            this.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmPagamento pagamento = new frmPagamento();
            pagamento.Show();

            this.Visible = false;
        }

        private void BtnConsultaPagamento_Click(object sender, EventArgs e)
        {
            frmConsultaPagamento consPagamento = new frmConsultaPagamento();
            consPagamento.Show();

            this.Visible = false;
        }

        private void GbDataHora_Enter(object sender, EventArgs e)
        {

        }

        private void BtnConfigCor_Click(object sender, EventArgs e)
        {

            movePnl(btnConfigCor);

            if (/*this.BackColor == Color.FromArgb(46, 66, 91) && */pnlCadastros.BackColor == Color.FromArgb(46, 66, 91) && pnlAgenda.BackColor == Color.FromArgb(46, 66, 91) && pnlConsultas.BackColor == Color.FromArgb(46, 66, 91) && pnlPagamento.BackColor == Color.FromArgb(46,66,91)
               /* && btnAgendaReservas.BackColor == Color.FromArgb(46, 66, 91)*/)
            {
                this.BackColor = Color.FromArgb(100, 200, 255);
                panel1.BackColor = Color.FromArgb(224,224,224);
                btnCadastroCliente.BackColor = Color.FromArgb(224, 224, 224);
                btnCadastroFunc.BackColor = Color.FromArgb(224, 224, 224);
                btnCadastroPacotes.BackColor = Color.FromArgb(224, 224, 224);
                btnAgendaReservas.BackColor = Color.FromArgb(224, 224, 224);
                btnConsultaPagamento.BackColor = Color.FromArgb(224, 224, 224);
                btnConsultasCadastros.BackColor = Color.FromArgb(224, 224, 224);
                btnConsultasReservas.BackColor = Color.FromArgb(224, 224, 224);
                btnConsultVenda.BackColor = Color.FromArgb(224, 224, 224);
                btnPagamento.BackColor = Color.FromArgb(224, 224, 224);
                btnSair.BackColor = Color.FromArgb(224, 224, 224);
                btnConfigCor.BackColor = Color.FromArgb(224, 224, 224);
            }
            else
            {
                if (this.BackColor == Color.FromArgb(100,200,255))
                {
                    this.BackColor = Color.FromArgb(255, 255, 255);
                    panel1.BackColor = Color.FromArgb(128, 128, 255);
                    btnCadastroCliente.BackColor = Color.FromArgb(255, 255, 255);
                    btnCadastroFunc.BackColor = Color.SkyBlue;
                    btnCadastroPacotes.BackColor = Color.FromArgb(255, 255, 255);
                    btnAgendaReservas.BackColor = Color.FromArgb(255, 255, 255);
                    btnConsultaPagamento.BackColor = Color.FromArgb(255, 255, 255);
                    btnConsultasCadastros.BackColor = Color.FromArgb(255, 255, 255);
                    btnConsultasReservas.BackColor = Color.FromArgb(255, 255, 255);
                    btnConsultVenda.BackColor = Color.FromArgb(255, 255, 255);
                    btnPagamento.BackColor = Color.FromArgb(255, 255, 255);
                    btnSair.BackColor = Color.FromArgb(255, 255, 255);
                    btnConfigCor.BackColor = Color.FromArgb(255, 255, 255);
                }
            }

        }

        private void LblCadastros_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ReservasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgendaReserva reserva = new frmAgendaReserva();
            reserva.Show();

            this.Visible = false;
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPagamento consPag = new frmConsultaPagamento();
            consPag.Show();

            this.Visible = false;
        }

        private void VendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaVenda consVenda = new frmConsultaVenda();
            consVenda.Show();

            this.Visible = false;
        }

        private void PagamentoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPagamento pagamento = new frmPagamento();
            pagamento.Show();

            this.Visible = false;
        }

        private void LblData_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void movePnl(Control btn)
        {
            pnlSlide.Width = btn.Width;
            pnlSlide.Left = btn.Left;
        }

        private void BtnMenuCadastros_MouseEnter(object sender, EventArgs e)
        {
            pnlCadastros.Visible = false;
        }

        private void BtnMenuCadastros_MouseHover(object sender, EventArgs e)
        {
            pnlCadastros.Visible = true;
        }

        private void PnlCadastros_MouseLeave(object sender, EventArgs e)
        {
            pnlCadastros.Visible = true;
        }

        private void PnlCadastros(object sender, PaintEventArgs e)
        {

        }

        private void BtnMenuCadastros_Click(object sender, EventArgs e)
        {
            movePnl(btnMenuCadastros);
        }

        private void BtnMenuAgenda_Click(object sender, EventArgs e)
        {

            movePnl(btnMenuAgenda);
        }

        private void BtnMenuPag_Click(object sender, EventArgs e)
        {

            movePnl(btnMenuPag);
        }

        private void BtnMenuCons_Click(object sender, EventArgs e)
        {

            movePnl(btnMenuCons);
        }

        private void PnlConsultas_Paint(object sender, PaintEventArgs e)
        {
            pnlConsultas.Visible = true;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuCor_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PnlSlide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMenuCadastros_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMenuAgenda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMenuAgenda_MouseEnter(object sender, EventArgs e)
        {
            pnlAgenda.Visible = false;
        }

        private void BtnMenuAgenda_MouseHover(object sender, EventArgs e)
        {
            pnlAgenda.Visible = true;
        }

        private void PnlAgenda_MouseLeave(object sender, EventArgs e)
        {
            pnlAgenda.Visible = true;
        }

        private void PnlAgenda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMenuPag_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlPagamento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMenuPag_MouseEnter(object sender, EventArgs e)
        {
            pnlPagamento.Visible = false;
        }

        private void BtnMenuPag_MouseHover(object sender, EventArgs e)
        {
            pnlPagamento.Visible = true;
        }

        private void PnlPagamento_MouseLeave(object sender, EventArgs e)
        {
            pnlPagamento.Visible = true;
        }

        private void BtnMenuCons_MouseEnter(object sender, EventArgs e)
        {
            pnlConsultas.Visible = false;
        }

        private void BtnMenuCons_MouseHover(object sender, EventArgs e)
        {
            pnlConsultas.Visible = true;
        }
    }
}
