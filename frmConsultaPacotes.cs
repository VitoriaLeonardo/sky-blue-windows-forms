using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeTurismo
{
    public partial class frmConsultaPacotes : Form
    {
        public frmConsultaPacotes()
        {
            InitializeComponent();
        }

        private void FrmConsultaPacotes_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        private void TxtOrigemPacotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvConsPacotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvConsPacotes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvConsPacotes.CurrentRow != null)
            {
                txtIdPacotes.Text = dgvConsPacotes.CurrentRow.Cells[0].Value.ToString();
                txtTipoPacotes.Text = dgvConsPacotes.CurrentRow.Cells[1].Value.ToString();
                txtOrigemPacotes.Text = dgvConsPacotes.CurrentRow.Cells[2].Value.ToString();
                txtDestinoPacotes.Text = dgvConsPacotes.CurrentRow.Cells[3].Value.ToString();
                nmrQuPasConsPac.Value = Convert.ToInt32(dgvConsPacotes.CurrentRow.Cells[4].Value);
                txtDescPacotes.Text = dgvConsPacotes.CurrentRow.Cells[5].Value.ToString();
                mskValorPacotes.Text = dgvConsPacotes.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void BtnAlterarPacotes_Click(object sender, EventArgs e)
        {
            Modelos mod = new Modelos();
            Comandos com = new Comandos();

            mod.codPac = Convert.ToInt32(txtIdPacotes.Text);
            mod.tipoPac = txtTipoPacotes.Text;
            mod.origemPac = txtOrigemPacotes.Text;
            mod.destinoPac = txtDestinoPacotes.Text;
            mod.quantPasPac = Convert.ToInt32(nmrQuPasConsPac.Text);;
            mod.descPac = txtDescPacotes.Text;
            mod.valorPac = mskValorPacotes.Text;

            if (com.AlteraPacotes(mod))
            {
                MessageBox.Show("Alterado com sucesso!");
                AtualizarDataGrid();
            }

            else
            {
                MessageBox.Show("Erro ao alterar!");
            }
        }

        private void AtualizarDataGrid()
        {
            Conexao con = new Conexao();

            try
            {
                SqlCommand sql = new SqlCommand("select * from Pacotes", con.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();

                da.Fill(ds); //da passa os dados para o ds, através do método Fill
                dgvConsPacotes.DataSource = ds;
                dgvConsPacotes.DataMember = ds.Tables[0].TableName;

                con.Desconectar();

                //Renomear as colunas do DataGridView
                dgvConsPacotes.Columns[0].HeaderText = "ID";
                dgvConsPacotes.Columns[1].HeaderText = "Tipo de pacote";
                dgvConsPacotes.Columns[2].HeaderText = "Origem";
                dgvConsPacotes.Columns[3].HeaderText = "Destino";
                dgvConsPacotes.Columns[4].HeaderText = "Quantidade passagens";
                dgvConsPacotes.Columns[5].HeaderText = "Descrição do pacote";
                dgvConsPacotes.Columns[6].HeaderText = "Valor";


                //Define os tamanhos das colunas do DataGridView
                dgvConsPacotes.Columns[4].Width = 230;
                dgvConsPacotes.Columns[5].Width = 230;
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
        }

        private void BtnVoltConsPac_Click(object sender, EventArgs e)
        {
            frmConsultaCadastro cadastro = new frmConsultaCadastro();
            cadastro.Show();

            this.Visible = false;
        }

        private void TxtDescPacotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void MskValorPacotes_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtIdPacotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTipoPacotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
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
