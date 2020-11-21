using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AgenciaDeTurismo
{
    class Comandos
    {
        public bool T = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;



        // metodo verificar login vai até o banco verificar ver se contem email e senha e vai mandar um 
        //verdadeiro e o controle da model vai pegar o verdadeiro e mandar para o formulario dizendo pode 
        // entrar no sistema caso contrario não vai entrar e vai apresentar uma mensagem que não foi possivel.

        public bool verificarLogin(String usuario, String senha)
        {
            // comandos SQl para verificar se tem no banco de dados
            cmd.CommandText = "select * from LOGIN where usuario= @Usuario and senha =@Senha";
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    T = true;
                }

            }
            catch (SqlException)
            {
                this.mensagem = "ERRO COM BANCO DE DADOS!";
            }

            return T;
        }

        public bool InsereCliente(Modelos m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Cliente values (@nomeCliente,@dataNascimento,@telefoneCliente,@nacionalidade,@cpf,@emailCliente)", con.Conectar());

                //cmd.Parameters.Add("@codCliente", SqlDbType.VarChar).Value = m.codCli;
                cmd.Parameters.Add("@nomeCliente", SqlDbType.VarChar).Value = m.nomeCli;
                cmd.Parameters.Add("@dataNascimento", SqlDbType.Date).Value = DateTime.Parse(m.dataCli).ToString("dd/MM/yyyy");
                cmd.Parameters.Add("@telefoneCliente", SqlDbType.VarChar).Value = m.telCli;
                cmd.Parameters.Add("@nacionalidade", SqlDbType.VarChar).Value = m.nacioCli;
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = m.cpfCli;
                cmd.Parameters.Add("@emailCliente", SqlDbType.VarChar).Value = m.emailCli;
                cmd.ExecuteNonQuery();
                con.Desconectar();

                return true;
            }

            catch (Exception e)
            {
                con.Desconectar();
                return false;
            }
        }
        public bool AlteraCliente(Modelos m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Cliente set Nome_Cliente = @nomeCliente, Data_Nascimento = @dataNascCli, Telefone_Cliente = @telCli, Nacionalidade = @nacioCli, CPF_Cliente = @cpfCli, Email_Cliente = @emailCli where Cod_Cliente = @codCli", con.Conectar());

                cmd.Parameters.Add("@nomeCliente", SqlDbType.VarChar).Value = m.nomeCli;
                cmd.Parameters.Add("@dataNascCli", SqlDbType.Date).Value = DateTime.Parse(m.dataCli).ToString("dd/MM/yyyy");
                cmd.Parameters.Add("@telCli", SqlDbType.VarChar).Value = m.telCli;
                cmd.Parameters.Add("@nacioCli", SqlDbType.VarChar).Value = m.nacioCli;
                cmd.Parameters.Add("@cpfCli", SqlDbType.VarChar).Value = m.cpfCli;
                cmd.Parameters.Add("@emailCli", SqlDbType.VarChar).Value = m.emailCli;
                cmd.Parameters.Add("@codCli", SqlDbType.Int).Value = m.codCli;
                cmd.ExecuteNonQuery();
                con.Desconectar();
                return true;
            }
            catch (Exception e)
            {
                con.Desconectar();
                return false;
            }
        }


        public bool InsereFuncionario(Modelos m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Funcionario values (@nomeFuncionario,@emailFuncionario,@telefoneFuncionario,@cpfFuncionario)", con.Conectar());

                //cmd.Parameters.Add("@codFuncionario", SqlDbType.VarChar).Value = m.codFunc;
                cmd.Parameters.Add("@nomeFuncionario", SqlDbType.VarChar).Value = m.nomeFunc;
                cmd.Parameters.Add("@emailFuncionario", SqlDbType.VarChar).Value = m.emailFunc;
                cmd.Parameters.Add("@telefoneFuncionario", SqlDbType.VarChar).Value = m.telFunc;
                cmd.Parameters.Add("@cpfFuncionario", SqlDbType.VarChar).Value = m.cpfFunc;
                cmd.ExecuteNonQuery();
                con.Desconectar();
                return true;
            }

            catch (Exception e)
            {
                con.Desconectar();
                return false;
            }
        }

        public bool AlteraFuncionario(Modelos m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Funcionario set Nome_Funcionario = @nomeFuncionario, Email_Funcionario = @emailFuncionario, Telefone_Funcionario = @telFuncionario, CPF_Funcionario = @cpfFuncionario where Cod_Funcionario = @IdFuncionario", con.Conectar());

                cmd.Parameters.Add("@nomeFuncionario", SqlDbType.VarChar).Value = m.nomeFunc;
                cmd.Parameters.Add("@emailFuncionario", SqlDbType.VarChar).Value = m.emailFunc;
                cmd.Parameters.Add("@telFuncionario", SqlDbType.VarChar).Value = m.telFunc;
                cmd.Parameters.Add("@cpfFuncionario", SqlDbType.VarChar).Value = m.cpfFunc;
                cmd.Parameters.Add("@IdFuncionario", SqlDbType.Int).Value = m.codFunc;
                cmd.ExecuteNonQuery();
                con.Desconectar();
                return true;
            }
            catch (Exception e)
            {
                con.Desconectar();
                return false;
            }
        }
        public bool InserePacotes(Modelos m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Pacotes (Tipo_Pacote, Origem, Destino, Quant_Passagem, Desc_Pacote, Valor_Pacote) values (@tipoPacote,@origemPacote,@destinoPacote,@quantPasPacote,@descricaoPacote,@valorPacote)", con.Conectar());

                cmd.Parameters.Add("@tipoPacote", SqlDbType.VarChar).Value = m.tipoPac;
                cmd.Parameters.Add("@origemPacote", SqlDbType.VarChar).Value = m.origemPac;
                cmd.Parameters.Add("@destinoPacote", SqlDbType.VarChar).Value = m.destinoPac;
                cmd.Parameters.Add("@quantPasPacote", SqlDbType.Int).Value = m.quantPasPac;
                cmd.Parameters.Add("@descricaoPacote", SqlDbType.VarChar).Value = m.descPac;
                cmd.Parameters.Add("@valorPacote", SqlDbType.VarChar).Value = m.valorPac;
                cmd.ExecuteNonQuery();
                con.Desconectar();
                return true;
            }
            catch (Exception e)
            {
                con.Desconectar();
                return false;
            }
        }

        public bool AlteraPacotes(Modelos m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("update Pacotes set Tipo_Pacote = @tipoPacote, Origem = @origemPacote, Destino = @destinoPacote, Quant_Passagem = @quantPasPacote, Desc_Pacote = @descricaoPacote, Valor_Pacote = @valorPacote where Cod_Pacote = @Id", con.Conectar());

                cmd.Parameters.Add("@tipoPacote", SqlDbType.VarChar).Value = m.tipoPac;
                cmd.Parameters.Add("@origemPacote", SqlDbType.VarChar).Value = m.origemPac;
                cmd.Parameters.Add("@destinoPacote", SqlDbType.VarChar).Value = m.destinoPac;
                cmd.Parameters.Add("@quantPasPacote", SqlDbType.Int).Value = m.quantPasPac;
                cmd.Parameters.Add("@descricaoPacote", SqlDbType.VarChar).Value = m.descPac;
                cmd.Parameters.Add("@valorPacote", SqlDbType.VarChar).Value = m.valorPac;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = m.codPac;
                cmd.ExecuteNonQuery();
                con.Desconectar();
                return true;
            }
            catch (Exception e)
            {
                con.Desconectar();
                return false;
            }

        }

        public bool InserePagamento(Modelos m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Pagamento (Tipo_Pagamento, Nome_Titular, Numero_Cartao, Data_Validade, Valor_Total, " +
                    "Cod_Reserva, Cod_Seguranca) values (@tipoPagamento,@nomeTitPagamento,@numCartPagamento,@dataValPagamento,@valTotPagamento," +
                    "@codReserva,@codSegPagamento)", con.Conectar());

                cmd.Parameters.Add("@tipoPagamento", SqlDbType.VarChar).Value = m.tipoPag;
                cmd.Parameters.Add("@nomeTitPagamento", SqlDbType.VarChar).Value = m.nomeTitPag;
                cmd.Parameters.Add("@numCartPagamento", SqlDbType.VarChar).Value = m.numCartPag;
                cmd.Parameters.Add("@dataValPagamento", SqlDbType.VarChar).Value = m.dataValPag;
                cmd.Parameters.Add("@codSegPagamento", SqlDbType.VarChar).Value = m.codSegPag;
                cmd.Parameters.Add("@valTotPagamento", SqlDbType.VarChar).Value = m.valorTotPag;
                cmd.Parameters.Add("@codReserva", SqlDbType.Int).Value = m.codRes;
                cmd.ExecuteNonQuery();
                con.Desconectar();
                string ids = "SELECT Pagamento.Cod_Pagamento, Reserva.Cod_Cliente, Reserva.Cod_Pacote FROM Pagamento INNER JOIN Reserva on Pagamento.Cod_Reserva = Reserva.Cod_Reserva WHERE Pagamento.Cod_Pagamento in (SELECT MAX(Cod_Pagamento) FROM Pagamento)";
                SqlCommand comando = new SqlCommand(ids, con.Conectar());
                DataTable dt = new DataTable();
                SqlDataReader reader = comando.ExecuteReader();
                dt.Load(reader);
                if (dt.Rows.Count > 0)
                {
                    DataRow retorno_id = dt.Rows[0];
                    m.codPag = retorno_id[0].ToString();
                    m.codCli = Convert.ToInt32(retorno_id[1].ToString());
                    m.codPac = Convert.ToInt32(retorno_id[2].ToString());
                }
                con.Desconectar();
                InserirVenda(m);
                return true;
            }

            catch (Exception ex)
            {
                con.Desconectar();
                return false;
            }
        }

        private void InserirVenda(Modelos m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Venda (Cod_Pagamento, Cod_Cliente, Cod_Pacotes, Data_Venda, Cod_Funcionario) values (@codPag, @codCli, @codPac, @data, @codFunc)", con.Conectar());
                cmd.Parameters.Add("@codPag", SqlDbType.Int).Value = Convert.ToInt32(m.codPag);
                cmd.Parameters.Add("@codPac", SqlDbType.Int).Value = m.codPac;
                cmd.Parameters.Add("@codCli", SqlDbType.Int).Value = m.codCli;
                cmd.Parameters.Add("@data", SqlDbType.Date).Value = DateTime.Now.ToString("dd/MM/yyyy");
                cmd.Parameters.Add("@codFunc", SqlDbType.Int).Value = m.codFunc;
                cmd.ExecuteNonQuery();
                con.Desconectar();
            }
            catch (Exception e)
            {
                con.Desconectar();
                string error = e.Message;
            }
        }

        public bool InsereReserva(Modelos m)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Reserva ( Cod_Pacote, Cod_Cliente, Nome_Titular, Data_Reserva, Data_Final) values (@codPac,@codCli,@nomeTitRes,@dataInRes,@dataFinRes)", con.Conectar());
                cmd.Parameters.Add("@codPac", SqlDbType.Int).Value = m.codPac;
                cmd.Parameters.Add("@codCli", SqlDbType.Int).Value = m.codCli;
                cmd.Parameters.Add("@nomeTitRes", SqlDbType.VarChar).Value = m.nomeTitRes;
                cmd.Parameters.Add("@dataInRes", SqlDbType.Date).Value = DateTime.Parse(m.dataRes.ToString()).ToString("dd/MM/yyyy");
                cmd.Parameters.Add("@dataFinRes", SqlDbType.Date).Value = DateTime.Parse(m.datFinRes.ToString()).ToString("dd/MM/yyyy");
                cmd.ExecuteNonQuery();
                con.Desconectar();
                return true;
            }
            catch (Exception e)
            {
                con.Desconectar();
                return false;
            }
        }
    }
}
