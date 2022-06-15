using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nutrisystem1._2
{
    internal class Paciente
    {
        //paciente
        //private int cod_Paciente
        private string nome;
        private string cpf;
        private string tipoDoc;
        private string rg;
        private string sexo;
        private string dataNascimento;
        private string nomeResponsavel;
        private int endereco1;
        private int contato1;
        //private string status;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string TipoDoc { get => tipoDoc; set => tipoDoc = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string NomeResponsavel { get => nomeResponsavel; set => nomeResponsavel = value; }
        public int Endereco1 { get => endereco1; set => endereco1 = value; }
        public int Contato1 { get => contato1; set => contato1 = value; }

        //public string Status { get => status; set => status = value; }

        private Banco banco;

        public Paciente()
        {
            this.banco = new Banco();
        }

        public void cadastrarPaciente()
        {
            this.banco.Conectar();
            this.banco.NonQuerry("insert into paciente (Nome, CPF, TipoDoc, Documento, Sexo, Data_Nascimento, Nome_Responsavel, Cod_Endereco, Cod_Contato) values " +
                "('" + this.nome + "', '" + this.cpf + "', '" + this.tipoDoc + "', '" + this.rg + "', '" + this.sexo + "', '" + this.dataNascimento + "', '" + this.nomeResponsavel + "', " + this.endereco1 + ", " + this.contato1 + ");");
        }
    }
}