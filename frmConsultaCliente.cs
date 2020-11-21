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
    public partial class frmConsultaCliente : Form
    {
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvConsCli.CurrentRow != null)
            {
                txtId.Text = Convert.ToInt32(dgvConsCli.CurrentRow.Cells[0].Value).ToString();
                txtNome.Text = dgvConsCli.CurrentRow.Cells[1].Value.ToString();
                txtDataNascimento.Text = dgvConsCli.CurrentRow.Cells[2].Value.ToString();
                txtTelefone.Text = dgvConsCli.CurrentRow.Cells[3].Value.ToString();
                txtNacionalidade.Text = dgvConsCli.CurrentRow.Cells[4].Value.ToString();
                txtCpf.Text = dgvConsCli.CurrentRow.Cells[5].Value.ToString();
                txtEmail.Text = dgvConsCli.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void MskTelConsFunc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnAlterarCliente_Click(object sender, EventArgs e)
        {

            Modelos mod = new Modelos();
            Comandos com = new Comandos();

            mod.codCli = Convert.ToInt32(txtId.Text);
            mod.nomeCli = txtNome.Text;
            mod.dataCli = txtDataNascimento.Text;
            mod.telCli = txtTelefone.Text;
            mod.nacioCli = txtNacionalidade.Text;
            mod.cpfCli = txtCpf.Text;
            mod.emailCli = txtEmail.Text;

            if (com.AlteraCliente(mod))
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
                SqlCommand sql = new SqlCommand("select * from Cliente", con.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();

                da.Fill(ds); //da passa os dados para o ds, através do método Fill
                dgvConsCli.DataSource = ds;
                dgvConsCli.DataMember = ds.Tables[0].TableName;


                con.Desconectar();

                //Renomear as colunas do DataGridView
                dgvConsCli.Columns[0].HeaderText = "ID";
                dgvConsCli.Columns[1].HeaderText = "Nome";
                dgvConsCli.Columns[2].HeaderText = "Data de nascimento";
                dgvConsCli.Columns[3].HeaderText = "Telefone";
                dgvConsCli.Columns[4].HeaderText = "Nacionalidade";
                dgvConsCli.Columns[5].HeaderText = "CPF";
                dgvConsCli.Columns[6].HeaderText = "Email";

                //Define os tamanhos das colunas do DataGridView
                dgvConsCli.Columns[0].Width = 100;
                dgvConsCli.Columns[1].Width = 150;
                dgvConsCli.Columns[2].Width = 130;
                dgvConsCli.Columns[3].Width = 150;
                dgvConsCli.Columns[4].Width = 150;
                dgvConsCli.Columns[5].Width = 100;
                dgvConsCli.Columns[6].Width = 150;
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
        }

        private void TxtDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnVoltConsCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCadastro cadastro = new frmConsultaCadastro();
            cadastro.Show();

            this.Visible = false;
        }

        private void Lkj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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
