using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nutrisystem1._2
{
    internal class Endereco
    {
        private string cod_Endereco;
        private string tipoLogradouro;
        private string logradouro;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;
        private Banco banco;

        public void atualizarContato()
        {
            this.banco.NonQuerry("update endereco set Tipo='" + this.tipoLogradouro + "', Logradouro='" + this.logradouro + "', Numero='" + this.numero + "', Complemento='" + this.complemento + "', Bairro'"
                + this.bairro + "', Cidade='" + this.cidade + "', UF='" + this.uf + "', CEP='" + this.cep + "' where Cod_Endereco=" + this.cod_Endereco + ";");
        }

        public void cadastrarContato()
        {
            this.banco.NonQuerry("insert into endereco (Tipo, Logradouro, Numero, Complemento, Bairro, Cidade, UF, CEP ) values ('" + this.tipoLogradouro + "', '" + this.Logradouro + "', '"
                + this.numero + "','" + this.bairro + "','" + this.cidade + "','" + this.uf + "','" + this.cep + "');");
        }

        public void excluirContato()
        {
            this.banco.NonQuerry("delete from endereco where Cod_Endereco=" + this.cod_Endereco + ";");
        }

        public MySqlDataReader listarUsuarios()
        {
            return this.banco.Querry("Select * from endereco order by Cod_Endereco asc");
        }

        public MySqlDataReader listarUsuarios(String campo, String filtro)
        {
            if (filtro == "")
            {
                return listarUsuarios();
            }
            return this.banco.Querry("Select * from endereco where " + campo + " = '" + filtro + "' order by Cod_Endereco asc");
        }

        public string Cod_Endereco { get => cod_Endereco; set => cod_Endereco = value; }
        public string TipoLogradouro { get => tipoLogradouro; set => tipoLogradouro = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Cep { get => cep; set => cep = value; }
    }
}
