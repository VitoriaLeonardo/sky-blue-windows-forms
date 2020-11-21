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
    public partial class frmConsultaReserva : Form
    {
        public frmConsultaReserva()
        {
            InitializeComponent();
        }

        private void BtnVoltarConsRes_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();

            this.Visible = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void AtualizarDataGrid()
        {
            Conexao con = new Conexao();

            try
            {
                SqlCommand sql = new SqlCommand("select * from Reserva", con.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(sql);
                DataSet ds = new DataSet();

                da.Fill(ds); //da passa os dados para o ds, através do método Fill
                dgvConsReserva.DataSource = ds;
                dgvConsReserva.DataMember = ds.Tables[0].TableName;


                con.Desconectar();

                //Renomear as colunas do DataGridView
                dgvConsReserva.Columns[0].HeaderText = "ID reserva";
                dgvConsReserva.Columns[1].HeaderText = "ID pacote";
                dgvConsReserva.Columns[2].HeaderText = "ID cliente";
                dgvConsReserva.Columns[3].HeaderText = "Nome do titular";
                dgvConsReserva.Columns[4].HeaderText = "Data de ida";
                dgvConsReserva.Columns[5].HeaderText = "Data de volta";

                //Define os tamanhos das colunas do DataGridView
                dgvConsReserva.Columns[0].Width = 100;
                dgvConsReserva.Columns[1].Width = 100;
                dgvConsReserva.Columns[2].Width = 100;
                dgvConsReserva.Columns[3].Width = 230;
                dgvConsReserva.Columns[4].Width = 100;
                dgvConsReserva.Columns[5].Width = 100;
            }
            catch (Exception ex)
            {
                string a = ex.Message;
            }
        }

        private void FrmConsultaReserva_Load(object sender, EventArgs e)
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
