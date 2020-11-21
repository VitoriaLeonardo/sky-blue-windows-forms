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
    public partial class frmConsultaVenda : Form
    {
        public frmConsultaVenda()
        {
            InitializeComponent();
        }

        private void DgvConsVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnVoltarConsVend_Click(object sender, EventArgs e)
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

                SqlCommand sql = new SqlCommand(@"select Cod_Venda, Nome_Funcionario, P.Nome_Titular, L.Nome_Cliente,  S.Destino, 
                                                  Data_Venda from Venda V INNER JOIN Funcionario F on V.Cod_Funcionario = F.Cod_Funcionario
                                                  INNER JOIN Pagamento P on V.Cod_Pagamento = P.Cod_Pagamento
                                                  INNER JOIN Cliente L
                                                  on V.Cod_Cliente = L.Cod_Cliente
                                                  INNER JOIN Pacotes S
                                                  on V.Cod_Pacotes = S.Cod_Pacote", con.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();

                da.Fill(ds); //da passa os dados para o ds, através do método Fill
                dgvConsVendas.DataSource = ds;
                dgvConsVendas.DataMember = ds.Tables[0].TableName;

                con.Desconectar();

                //Renomear as colunas do DataGridView
                dgvConsVendas.Columns[0].HeaderText = "ID";
                dgvConsVendas.Columns[1].HeaderText = "Nome do funcionário";
                dgvConsVendas.Columns[2].HeaderText = "Titular do pagamento";
                dgvConsVendas.Columns[3].HeaderText = "Nome do cliente";
                dgvConsVendas.Columns[4].HeaderText = "Destino";
                dgvConsVendas.Columns[5].HeaderText = "Data de venda";

                //Define o tmanho das colunas do DataGridView
                dgvConsVendas.Columns[0].Width = 100;
                dgvConsVendas.Columns[1].Width = 100;
                dgvConsVendas.Columns[2].Width = 100;
                dgvConsVendas.Columns[3].Width = 230;
                dgvConsVendas.Columns[4].Width = 100;
                dgvConsVendas.Columns[5].Width = 100;
            }

            catch (Exception ex)
            {
                string a = ex.Message;
            }
        }

        private void FrmConsultaVenda_Load(object sender, EventArgs e)
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
