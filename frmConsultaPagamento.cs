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
    public partial class frmConsultaPagamento : Form
    {
        public frmConsultaPagamento()
        {
            InitializeComponent();
        }

        private void DgvConsPacotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dgvConsPagamento.Columns[0].Width = 10;
        }

        private void BtnVoltConsPag_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();

            this.Visible = false;
        }
        private void AtualizarDataGrid()
        {
            Conexao con = new Conexao();

            try
            {
                SqlCommand sql = new SqlCommand("select * from Pagamento", con.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();

                da.Fill(ds); //da passa os dados para o ds, através do método Fill
                dgvConsPagamento.DataSource = ds;
                dgvConsPagamento.DataMember = ds.Tables[0].TableName;


                con.Desconectar();

                //Renomear as colunas do DataGridView
                dgvConsPagamento.Columns[0].HeaderText = "ID pagamento";
                dgvConsPagamento.Columns[1].HeaderText = "ID reserva";
                dgvConsPagamento.Columns[2].HeaderText = "Tipo de pagamento";
                dgvConsPagamento.Columns[3].HeaderText = "Valor total";
                dgvConsPagamento.Columns[4].HeaderText = "Nome do titular";
                dgvConsPagamento.Columns[5].HeaderText = "Número do cartão";
                dgvConsPagamento.Columns[6].HeaderText = "Data de validade";
                dgvConsPagamento.Columns[7].HeaderText = "Código de segurança";

                //Define os tamanhos das colunas do DataGridView
                dgvConsPagamento.Columns[0].Width = 100;
                dgvConsPagamento.Columns[1].Width = 100;
                dgvConsPagamento.Columns[2].Width = 120;
                dgvConsPagamento.Columns[3].Width = 100;
                dgvConsPagamento.Columns[4].Width = 200;
                dgvConsPagamento.Columns[5].Width = 100;
                dgvConsPagamento.Columns[6].Width = 100;
                dgvConsPagamento.Columns[7].Width = 100;
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
        }

        private void FrmConsultaPagamento_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
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
