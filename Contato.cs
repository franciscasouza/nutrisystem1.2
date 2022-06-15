using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nutrisystem1._2
{
    internal class Contato
    {
        private int cod_Contato;
        private string telefone;
        private string celular;
        private string email;

        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
        public int Cod_Contato { get => cod_Contato; set => cod_Contato = value; }

        private Banco banco;

        public Contato()
        {
            this.banco = new Banco();
        }

        public void cadastrarContato()
        {
            MySqlDataReader reader;
            this.banco.Conectar();
            this.banco.NonQuerry("insert into contato (Telefone, Celular, E_mail) values ('" + this.telefone + "', '" + this.celular + "', '" + this.email + "');");
            reader = this.banco.Querry("select Cod_Contato from contato where Telefone = '" + this.telefone + "' and Celular = '" + this.celular + "' and E_mail = '" + this.email + "';");
            reader.Read();
            int contato = reader.GetInt32(0);
            this.banco.Close();
            this.cod_Contato = contato;
        }
    }
}
