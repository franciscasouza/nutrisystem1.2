using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nutrisystem1._2
{
    internal class Prontuario
    {
        private string cod_Prontuario;
        private string descricao;
        private Banco banco;

        public void atualizarContato()
        {
            this.banco.NonQuerry("update prontuario set Descrição='" + this.descricao + "' where Cod_Prontuario=" + this.cod_Prontuario + ";");
        }

        public void cadastrarContato()
        {
            this.banco.NonQuerry("insert into prontuario (Descrição) values ('" + this.descricao + "');");
        }

        public void excluirContato()
        {
            this.banco.NonQuerry("delete from prontuario where Cod_Prontuario=" + this.cod_Prontuario + ";");
        }

        public MySqlDataReader listarUsuarios()
        {
            return this.banco.Querry("Select * from prontuario order by Cod_Prontuario asc");
        }

        public MySqlDataReader listarUsuarios(String campo, String filtro)
        {
            if (filtro == "")
            {
                return listarUsuarios();
            }
            return this.banco.Querry("Select * from prontuario where " + campo + " = '" + filtro + "' order by Cod_Prontuario asc");
        }

        public string Cod_Prontuario { get => cod_Prontuario; set => cod_Prontuario = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
