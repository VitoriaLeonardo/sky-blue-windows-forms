using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeTurismo
{
    class Modelos
    {
        //TABELA CLIENTE
        public int codCli { get; set; }
        public string nomeCli { get; set; }
        public string dataCli { get; set; }
        public string telCli { get; set; }
        public string nacioCli { get; set; }
        public string cpfCli { get; set; }
        public string emailCli { get; set; }

        //TABELA FUNCIONÁRIO
        public int codFunc { get; set; }
        public string nomeFunc { get; set; }
        public string emailFunc { get; set; }
        public string telFunc { get; set; }
        public string cpfFunc { get; set; }

        //TABELA PACOTES
        public int codPac { get; set; }
        public string tipoPac { get; set; }
        public string origemPac { get; set; }
        public string destinoPac { get; set; }
        public int quantPasPac { get; set; }
        public string descPac { get; set; }
        public string valorPac { get; set; }

        //TABELA PAGAMENTO
        public string codPag { get; set; }
        public string tipoPag { get; set; }
        public string nomeTitPag { get; set; }
        public string numCartPag { get; set; }
        public string dataValPag { get; set; } //Tipo Date no sql
        public string codSegPag { get; set; }
        public string valorTotPag { get; set; }

        //TABELA RESERVA
        public int codRes { get; set; }
        public DateTime dataRes { get; set; }
        public string nomeTitRes { get; set; }
        public DateTime datFinRes { get; set; }

    }
}
