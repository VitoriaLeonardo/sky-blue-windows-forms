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
    public partial class frmAgendaReserva : Form
    {
        Modelos mod = new Modelos();
        Comandos com = new Comandos();

        public frmAgendaReserva()
        {
            InitializeComponent();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtNomeTitReserva_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnVoltReserva_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();

            this.Visible = false;
        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                mod.codCli = Convert.ToInt32(cmbIdClienteReserva.SelectedValue);
                mod.codPac = Convert.ToInt32(cmbIdPacoteReserva.SelectedValue);
                mod.dataRes = dtDataResInicio.Value;
                mod.nomeTitRes = txtNomeTitReserva.Text;
                mod.datFinRes = dtDataResFinal.Value;

                if (mod.nomeTitRes == "")
                {
                    MessageBox.Show("Preencha os dados solicitados!");
                }

                else if (com.InsereReserva(mod))
                {
                    dtDataResInicio.Value = DateTime.Today;
                    txtNomeTitReserva.Text = "";
                    dtDataResFinal.Value = DateTime.Today.AddDays(5);

                    MessageBox.Show("Dados cadastrados com sucesso!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }

        private void FrmAgendaReserva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tURISMODataSet4.Pacotes' table. You can move, or remove it, as needed.
            this.pacotesTableAdapter1.Fill(this.tURISMODataSet4.Pacotes);
            // TODO: This line of code loads data into the 'tURISMODataSet2.Pacotes' table. You can move, or remove it, as needed.
            this.pacotesTableAdapter.Fill(this.tURISMODataSet2.Pacotes);
            // TODO: This line of code loads data into the 'tURISMODataSet1.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.tURISMODataSet1.Cliente);
            // TODO: This line of code loads data into the 'tURISMODataSet.Reserva' table. You can move, or remove it, as needed.
            this.reservaTableAdapter.Fill(this.tURISMODataSet.Reserva);

        }

        private void DtDataResInicio_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void DtDataResFinal_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void DtDataResInicio_ValueChanged_1(object sender, EventArgs e)
        {
            dtDataResFinal.Value = dtDataResInicio.Value.AddDays(5);
        }

        private void DtDataResFinal_ValueChanged_1(object sender, EventArgs e)
        {
            dtDataResInicio.Value = dtDataResFinal.Value.AddDays(-1 * 5);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CmbIdClienteReserva_SelectedIndexChanged(object sender, EventArgs e)
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
