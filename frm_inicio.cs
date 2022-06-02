using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using nutrisystem1._2.Properties;

namespace nutrisystem1._2
{
    public partial class frm_inicio : Form
    {
        private bool isCollapsed;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public frm_inicio()
        {
            InitializeComponent();
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = pnl_conteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnl_conteudo.Visible = true;
                pnl_conteudo.Controls.Add(formulario);
                pnl_conteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                formulario.BringToFront();
            }
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            pnl_conteudo.Visible=false;
            pnl_conteudo.Controls.Clear();
        }

        private void btn_Financeiro_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frm_financeiro>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnPacientes.Image = Resources.arrow_up2;
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btnPacientes.Image = Resources.arrow_down2;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
