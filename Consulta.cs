using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nutrisystem1._2
{
    internal class Consulta
    {
        private string cod_Consulta;
        private string hora;
        private string data;
        private string statusConsulta;
        private Banco banco;

        public void atualizarContato()
        {
            this.banco.NonQuerry("update consulta set HORA='" + this.hora + "', Data_Consulta='" + this.data + "', Status_Consulta='" + this.statusConsulta + "' where Cod_Consulta=" + this.cod_Consulta + ";");
        }

        public void cadastrarContato()
        {
            this.banco.NonQuerry("insert into consulta (HORA, Data_Consulta, Status_Consulta ) values ('" + this.hora + "', '" + this.data + "', '" + this.statusConsulta + "');");
        }

        public void excluirContato()
        {
            this.banco.NonQuerry("delete from consulta where Cod_Consulta=" + this.cod_Consulta + ";");
        }

        public MySqlDataReader listarUsuarios()
        {
            return this.banco.Querry("Select * from consulta order by Cod_Consulta asc");
        }

        public MySqlDataReader listarUsuarios(String campo, String filtro)
        {
            if (filtro == "")
            {
                return listarUsuarios();
            }
            return this.banco.Querry("Select * from consulta where " + campo + " = '" + filtro + "' order by Cod_Consulta asc");
        }

        public string Cod_Consulta { get => cod_Consulta; set => cod_Consulta = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Data { get => data; set => data = value; }
        public string StatusConsulta { get => statusConsulta; set => statusConsulta = value; }
    }
}
