using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeTurismo
{
    //"User ID = sa; Initial Catalog = SYSLOGIN; Data Source =(local); Password = 1234567"
    //Data Source = wellnote; Initial Catalog = SYSLOGIN; Integrated Security = True
    class Conexao
    {
       // SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-ILP5CFV; Initial Catalog = TURISMO; Integrated Security = True");
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-ILP5CFV; Initial Catalog = TURISMO; Integrated Security = True");

        public SqlConnection Conectar()
        {
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na Conexão");
            }
            return con;
        }

        public SqlConnection Desconectar()
        {
            try
            {
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show ("Erro na Conexão");
            }
            return con;
        }

    }
}
