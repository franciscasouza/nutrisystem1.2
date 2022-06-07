using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nutrisystem1._2
{
    public partial class frm_financeiro : Form
    {
        private Paciente paciente;
        private Consulta consulta;
        private Endereco endereco;
        private Contato contato;
        public frm_financeiro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_recibo.Visible=false;
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            pnl_recibo.Visible = true;
        }

<<<<<<< HEAD
        private void AtualizarDtGrid()
        {
            MySqlDataReader temp = this.contato.listarUsuarios();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dtgv_lista.DataSource = dt;
        }

        private void frm_financeiro_Load(object sender, EventArgs e)
        {
            AtualizarDtGrid();
=======
        private void frm_financeiro_Load(object sender, EventArgs e)
        {

>>>>>>> 83a2c21c9dd92e67c26fa5c52c0d3eeaf3340f69
        }
    }
}
