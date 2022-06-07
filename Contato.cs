using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nutrisystem1._2
{
    internal class Contato
    {
        private string cod_Contato;
        private string telefone;
        private string celular;
        private string email;
        private Banco banco;

        public void atualizarContato()
        {
            this.banco.NonQuerry("update contato set Telefone='" + this.telefone + "', Celular='" + this.celular + "', E_mail='" + this.email + "' where Cod_Contato=" + this.cod_Contato + ";");
        }

        public void cadastrarContato()
        {
            this.banco.NonQuerry("insert into contato (Telefone, Celular, E_mail ) values ('" + this.telefone + "', '" + this.celular + "', '"+ this.email + "');");
        }

        public void excluirContato()
        {
            this.banco.NonQuerry("delete from contato where Cod_Contato=" + this.cod_Contato + ";");

        }

        public MySqlDataReader listarUsuarios()
        {
            return this.banco.Querry("Select * from contato order by Cod_Contato asc");
        }

        public MySqlDataReader listarUsuarios(String campo, String filtro)
        {
            if (filtro == "")
            {
                return listarUsuarios();
            }
            return this.banco.Querry("Select * from contato where " + campo + " = '" + filtro + "' order by Cod_Contato asc");
        }

        public string Cod_Contato { get => cod_Contato; set => cod_Contato = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
    }
}
