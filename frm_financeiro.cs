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

        private void frm_financeiro_Load(object sender, EventArgs e)
        {

        }
    }
}
