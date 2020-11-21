using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AgenciaDeTurismo
{
    class Controle
    {
        public bool T;
        public String mensagem = "";


        public bool Acessar(string usuario, String senha)
        {
            Comandos lcomando = new Comandos();
            SqlCommand cmd = new SqlCommand();
            T = lcomando.verificarLogin(usuario, senha);
            if (!lcomando.mensagem.Equals(""))
            {
                this.mensagem = lcomando.mensagem;
            }


            return T;

        }
    }
}
