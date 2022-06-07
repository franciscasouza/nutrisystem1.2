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
        private string cod_Paciente;
        private string nome;
        private string cpf;
        private string rg;
        private string sexo;
        private string dataNascimento;
        private string nomeResponsavel;
        private string status;
        private Banco banco;

        public void atualizarContato()
        {
            this.banco.NonQuerry("update paciente set Nome='" + this.nome + "', CPF='" + this.cpf + "', RG='" + this.rg + "', Sexo='" + this.sexo + "', Data_Nascimento='"
                + this.dataNascimento + "', Nome_Responsavel='" + this.nomeResponsavel + "', Status='" + this.status + "' where Cod_Paciente=" + this.cod_Paciente + ";");
        }

        public void cadastrarContato()
        {
            this.banco.NonQuerry("insert into paciente (Nome, CPF, RG, Sexo, Data_Nascimento, Nome_Responsavel, Status) values ('" + this.nome + "', '" + this.cpf + "', '" 
                + this.rg + "','" + this.sexo + "','" + this.dataNascimento + "','" + this.nomeResponsavel + "','" + this.status + "');");
        }

        public void excluirContato()
        {
            this.banco.NonQuerry("delete from paciente where Cod_Paciente=" + this.cod_Paciente + ";");

        }

        public MySqlDataReader listarUsuarios()
        {
            return this.banco.Querry("Select * from paciente order by Cod_Paciente asc");
        }

        public MySqlDataReader listarUsuarios(String campo, String filtro)
        {
            if (filtro == "")
            {
                return listarUsuarios();
            }
            return this.banco.Querry("Select * from paciente where " + campo + " = '" + filtro + "' order by Cod_Paciente asc");
        }

        public string Cod_Paciente { get => cod_Paciente; set => cod_Paciente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string NomeResponsavel { get => nomeResponsavel; set => nomeResponsavel = value; }
        public string Status { get => status; set => status = value; }
    }
}
