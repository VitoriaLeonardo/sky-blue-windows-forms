using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgenciaDeTurismo
{
    public partial class frmConsultaFuncionario : Form
    {
        public frmConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmConsultaFuncionario_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        private void DgvConsPagamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvConsPagamento_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnVoltConsFunc_Click(object sender, EventArgs e)
        {
            frmConsultaCadastro cadastro = new frmConsultaCadastro();
            cadastro.Show();

            this.Visible = false;

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Modelos mod = new Modelos();
            Comandos com = new Comandos();

            mod.codFunc = Convert.ToInt32(txtIdConsFunc.Text);
            mod.nomeFunc = txtNomeConsFunc.Text;
            mod.emailFunc = txtEmailConsFunc.Text;
            mod.telFunc = mskTelConsFunc.Text;
            mod.cpfFunc = mskCpfConsFunc.Text;

            if (com.AlteraFuncionario(mod))
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
                SqlCommand sql = new SqlCommand("select * from Funcionario", con.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();

                da.Fill(ds); //da passa os dados para o ds, através do método Fill
                dgvConsFuncionario.DataSource = ds;
                dgvConsFuncionario.DataMember = ds.Tables[0].TableName;


                con.Desconectar();

                //Renomear as colunas do DataGridView
                dgvConsFuncionario.Columns[0].HeaderText = "ID";
                dgvConsFuncionario.Columns[1].HeaderText = "Nome";
                dgvConsFuncionario.Columns[2].HeaderText = "Email";
                dgvConsFuncionario.Columns[3].HeaderText = "Telefone";
                dgvConsFuncionario.Columns[4].HeaderText = "CPF";

                //Define os tamanhos das colunas do DataGridView
                dgvConsFuncionario.Columns[0].Width = 35;
                dgvConsFuncionario.Columns[1].Width = 150;
                dgvConsFuncionario.Columns[2].Width = 210;
                dgvConsFuncionario.Columns[3].Width = 150;
                dgvConsFuncionario.Columns[4].Width = 150;
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtIdConsFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvConsFuncionario_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvConsFuncionario.CurrentRow != null)
            {
                txtIdConsFunc.Text = Convert.ToInt32(dgvConsFuncionario.CurrentRow.Cells[0].Value).ToString();
                txtNomeConsFunc.Text = dgvConsFuncionario.CurrentRow.Cells[1].Value.ToString();
                txtEmailConsFunc.Text = dgvConsFuncionario.CurrentRow.Cells[2].Value.ToString();
                mskTelConsFunc.Text = dgvConsFuncionario.CurrentRow.Cells[3].Value.ToString();
                mskCpfConsFunc.Text = dgvConsFuncionario.CurrentRow.Cells[4].Value.ToString();
            }
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
