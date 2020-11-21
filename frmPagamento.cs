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
    public partial class frmPagamento : Form
    {
        public frmPagamento()
        {
            InitializeComponent();
        }
        Comandos com = new Comandos();
        Modelos mod = new Modelos();

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmPagamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tURISMODataSet3.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.tURISMODataSet3.Funcionario);
            // TODO: This line of code loads data into the 'tURISMODataSet1.Reserva' table. You can move, or remove it, as needed.
            this.reservaTableAdapter.Fill(this.tURISMODataSet1.Reserva);
            this.reservaTableAdapter.Fill(this.tURISMODataSet.Reserva);
        }

        private void BtnFinalizarPag_Click(object sender, EventArgs e)
        {
            try
            {
                mod.valorTotPag = mskValorTotPag.Text;
                mod.tipoPag = cmbTipoPag.Text;
                mod.codRes = Convert.ToInt32(cmbIdReserva.Text);
                mod.codFunc = Convert.ToInt32(comboBox1.SelectedValue);
                mod.nomeTitPag = txtNomeTitPag.Text;

                if (mod.tipoPag == "Boleto")
                {
                    mod.codSegPag = "-";

                    mod.numCartPag = "-";
                    mod.dataValPag = "-";


                    if (mod.tipoPag == "" || mod.nomeTitPag == "" ||mod.valorTotPag == "")
                    {
                        MessageBox.Show("Preencha os dados solicitados!");
                    }

                    else
                    {
                        if (com.InserePagamento(mod))
                        {
                            txtNomeTitPag.Text = "";
                            mskValorTotPag.Text = "";
                            MessageBox.Show("Pagamento realizado com sucesso!");
                            this.reservaTableAdapter.Fill(this.tURISMODataSet.Reserva);
                        }
                    }
                }

                else if (mod.tipoPag == "Cartão")
                {



                    mod.codSegPag = mskCodSegPag.Text;
                    mod.codPag = mskCodSegPag.Text;
                    mod.numCartPag = mskNumCartPag.Text;
                    mod.dataValPag = mskDataValPag.Text;
                    

                    if (mod.tipoPag == "" || mod.nomeTitPag == "" || mod.numCartPag == "" || mod.dataValPag == "" || mod.valorTotPag == "")
                    {
                        MessageBox.Show("Preencha os dados solicitados!");
                    }

                    else
                    {
                        if (com.InserePagamento(mod)) 
                        {
                            //cmbIdReserva.Text =;
                            cmbTipoPag.Text = "";
                            txtNomeTitPag.Text = "";
                            mskNumCartPag.Text = "";
                            mskDataValPag.Text = "";
                            mskCodSegPag.Text = "";
                            mskValorTotPag.Text = "";
                            MessageBox.Show("Pagamento realizado com sucesso!");
                            this.reservaTableAdapter.Fill(this.tURISMODataSet.Reserva);
                        }
                        else
                        {
                            MessageBox.Show("Erro no pagamento.");
                        }
                    }
                }

                else
                {
                    MessageBox.Show("Selecione o tipo de pagamento!");
                }
                
            }

            catch(Exception ex)
            {
                MessageBox.Show("Erro ao efetuar o pagamento!");
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CmbTipoPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPag.Text == "Cartão")
            {
                pnlCartPag.Visible = true;
            }

            if (cmbTipoPag.Text == "Boleto")
            {
                pnlCartPag.Visible = false;
            }
        }

        private void BtnVoltarPagamento_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();

            this.Visible = false;
        }

        private void TxtNomeTitPag_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbIdReserva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MskValorTotPag_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.reservaTableAdapter.FillBy(this.tURISMODataSet.Reserva);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.reservaTableAdapter.FillBy1(this.tURISMODataSet.Reserva);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.reservaTableAdapter.FillBy(this.tURISMODataSet.Reserva);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ReservaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Fill__ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.reservaTableAdapter.Fill__(this.tURISMODataSet.Reserva);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Fill__ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.reservaTableAdapter.Fill__(this.tURISMODataSet.Reserva);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("ID FUNCIONARIO: " + comboBox1.SelectedValue);
        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
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
