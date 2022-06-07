using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nutrisystem1._2
{
    internal class Pagamento
    {
        private string cod_Pagamento;
        private string tipoPagamento;
        private string valor;
        private string data;
        private string recibo;
        private Banco banco;

        public void atualizarContato()
        {
            this.banco.NonQuerry("update pagamento_efetuado set TipoPagamento='" + this.tipoPagamento + "', Valor='" + this.valor + "', Data_Pag='" + this.data + "', Recibo='" 
                + this.recibo + "' where Cod_PagEfetuado=" + this.cod_Pagamento + ";");
        }

        public void cadastrarContato()
        {
            this.banco.NonQuerry("insert into pagamento_efetuado (TipoPagamento, Valor, Data_Pag, Recibo) values ('" + this.tipoPagamento + "','" + this.valor + "', '" 
                + this.data + "', '"+ this.recibo + "');");
        }

        public void excluirContato()
        {
            this.banco.NonQuerry("delete from pagamento_efetuado where Cod_PagEfetuado=" + this.cod_Pagamento + ";");
        }

        public MySqlDataReader listarUsuarios()
        {
            return this.banco.Querry("Select * from pagamento_efetuado order by Cod_PagEfetuado asc");
        }

        public MySqlDataReader listarUsuarios(String campo, String filtro)
        {
            if (filtro == "")
            {
                return listarUsuarios();
            }
            return this.banco.Querry("Select * from pagamento_efetuado where " + campo + " = '" + filtro + "' order by Cod_PagEfetuado asc");
        }

        public string Cod_Pagamento { get => cod_Pagamento; set => cod_Pagamento = value; }
        public string TipoPagamento { get => tipoPagamento; set => tipoPagamento = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Data { get => data; set => data = value; }
        public string Recibo { get => recibo; set => recibo = value; }
    }
}