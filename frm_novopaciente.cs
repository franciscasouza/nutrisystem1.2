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
    public partial class frm_novopaciente : Form
    {
        Paciente paciente = new Paciente();
        Endereco endereco = new Endereco();
        Contato contato = new Contato();
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

        private void btn_limpar_Click_1(object sender, EventArgs e)
        {
            txt_nomecompleto.Clear();
            rdb_fem.Checked = false;
            rdb_masc.Checked = false;
            dtp_datanascimento.Value = DateTime.Now;
            txt_tipodocumento.Clear();
            txt_numerodocumento.Clear();
            txt_cpf.Clear();
            txt_responsavelnome.Clear();
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
            string gen;
            try
            {
                //ENDERECO
                paciente.Endereco1 = endereco.Cod_Endereco;
                this.endereco.TipoLogradouro = txt_tipoEnd.Text;
                this.endereco.Logradouro = txt_rua.Text;
                this.endereco.Numero = txt_num_endereco.Text;
                this.endereco.Bairro = txt_bairro.Text;
                this.endereco.Complemento = txt_complemento.Text;
                this.endereco.Cep = txt_cep.Text;
                this.endereco.Cidade = txt_cidade.Text;
                this.endereco.Uf = txt_uf.Text;
                this.endereco.cadastrarEndereco();

                //CONTATO
                paciente.Contato1 = contato.Cod_Contato;
                this.contato.Telefone = txt_telefone.Text;
                this.contato.Celular = txt_celular.Text;
                this.contato.Email = txt_email.Text;
                this.contato.cadastrarContato();

                //PACIENTE
                DateTimePicker dtNasc = dtp_datanascimento;

                this.paciente.Nome = txt_nomecompleto.Text;
                this.paciente.Cpf = txt_cpf.Text;
                this.paciente.TipoDoc = txt_tipodocumento.Text;
                this.paciente.Rg = txt_numerodocumento.Text;
                if (rdb_fem.Checked == true)
                {
                    gen = "F";
                    this.paciente.Sexo = gen;
                }
                else
                {
                    gen = "M";
                    this.paciente.Sexo = gen;
                }
                this.paciente.DataNascimento = dtp_datanascimento.Value.ToString("yyyy-MM-dd");
                this.paciente.NomeResponsavel = txt_responsavelnome.Text;
                paciente.cadastrarPaciente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void rdb_masc_Enter(object sender, EventArgs e)
        {
            rdb_masc.Checked = true;
        }

        private void rdb_fem_Enter(object sender, EventArgs e)
        {
            rdb_fem.Checked = true;
        }
    }
}
