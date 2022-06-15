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
    public partial class frm_novopaciente : Form
    {
        Contato contato = new Contato();
        Endereco endereco = new Endereco();
        Paciente paciente = new Paciente();

        public frm_novopaciente()
        {
            InitializeComponent();
        }

        private void frm_novopaciente_Load(object sender, EventArgs e)
        {

        }
        private void dtp_datanascimento_ValueChanged(object sender, EventArgs e)
        {

            DateTime nascPaciente = dtp_datanascimento.Value;
            DateTime DataAtual = DateTime.Now;
            int Anos = new DateTime(DateTime.Now.Subtract(nascPaciente).Ticks).Year - 1;
            DateTime ResultAnos = nascPaciente.AddYears(Anos);
            int meses = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (ResultAnos.AddMonths(i) == DataAtual)
                {
                    meses = i;
                    break;
                }
                else if (ResultAnos.AddMonths(i) >= DataAtual)
                {
                    meses = i - 1;
                    break;
                }
            }
            int dias = DataAtual.Subtract(ResultAnos.AddMonths(meses)).Days;

            label3.Text = $" {Anos} anos {meses} meses {dias} dias";

            if (Anos >= 18)
            {
                pn_menoridade.Visible = false;
            }
            else
            {
                pn_menoridade.Visible = true;
            }

        }
        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Dispose();
            frm_inicio frm = new frm_inicio();
            frm.ShowDialog();
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nomecompleto.Clear();
            rdb_fem.Checked = false;
            rdb_masc.Checked = false;
            dtp_datanascimento.Value = DateTime.Now;
            txt_tipodocumento.Clear();
            txt_numerodocumento.Clear();
            txt_cpf.Clear();
            txt_responsavelnome.Clear();
            txt_docresponsavel.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txt_celular.Clear();
            txt_telefone.Clear();
            txt_email.Clear();
            txt_rua.Clear();
            txt_num_endereco.Clear();
            txt_cep.Clear();
            txt_bairro.Clear();
            txt_cidade.Clear();
            txt_uf.Clear();

            pn_menoridade.Visible = false;

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            endereco = paciente.Endereco();

            endereco {
                Bair = txt_bairro
            }
        }
    }
}
