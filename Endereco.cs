using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nutrisystem1._2
{
    internal class Endereco
    {
        private int cod_Endereco;
        private string tipoLogradouro;
        private string logradouro;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;

        public string TipoLogradouro { get => tipoLogradouro; set => tipoLogradouro = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Cep { get => cep; set => cep = value; }
        public int Cod_Endereco { get => cod_Endereco; set => cod_Endereco = value; }

        private Banco banco;

        public Endereco()
        {
            this.banco = new Banco();
        }

        public void cadastrarEndereco()
        {
            MySqlDataReader reader;
            this.banco.Conectar();
            this.banco.NonQuerry("insert into endereco (Tipo, Logradouro, Numero, Complemento, Bairro, Cidade, UF, CEP) values ('" + this.tipoLogradouro + "', '" + this.logradouro + "', '" + this.numero + "','" + this.complemento + "','" + this.bairro + "','" + this.cidade + "','" + this.uf + "','" + this.cep + "');");
            reader = this.banco.Querry("select Cod_Endereco from endereco where CEP = '" + this.cep + "' and Logradouro = '" + this.logradouro +
                "' and Numero = '" + this.numero + "' and Bairro = '" + this.bairro + "' and Uf = '" + this.uf + "' and Cidade = '" + this.cidade + "';");
            reader.Read();
            int endereco = reader.GetInt32(0);
            this.banco.Close();
            this.cod_Endereco = endereco;
        }
    }
}
