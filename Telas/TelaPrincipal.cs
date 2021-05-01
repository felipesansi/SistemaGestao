using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestao.Telas
{
    public partial class TelaPrincipal : Form
    {
        private Form formulario_filho_atual = new Form();
        public TelaPrincipal()
        {

            InitializeComponent();

        }


        private void Painel_Pricipal_Paint(object sender, PaintEventArgs e)
        {
           
        }

        
         
        
       








        // MÉTODO DE REDIMENSIONAMENTO PARA REDIMENTAR / ALTERAR O TAMANHO PARA FORMATO NO TEMPO DE EXECUÇÃO ----------------------------------- -----------------------

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        // ---------------- DESENHO RETANGLE / EXCLUIR PAINEL DE CANTO
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.Painel_Pricipal.Region = region;
            this.Invalidate();
        }
        // ---------------- COR E GRIP RETÂNGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(36, 48, 60));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);


        }
     public   bool janela_aberta = false;
        public bool verificar_janela_aberta()
        {
            if (Application.OpenForms.OfType<TelaAddCategoria>().Count() > 0)
            {
                janela_aberta = true;
                
            }
            else if (Application.OpenForms.OfType<TelacadasCliente>().Count() > 0)
            {
                janela_aberta = true;

            }
            else if (Application.OpenForms.OfType<TelaAddProduto>().Count() > 0)
            {
                janela_aberta = true;


            }
            else
            {
                janela_aberta = false;
            }
            return janela_aberta;
        }
        public void ativar_botoes_menu()
        {
            Btn_Cadastro_Produto.Enabled = true;
            Btn_Cadatro_Cliente.Enabled = true;
            Btn_Confi_Sys.Enabled = true;
            Btn_Ver_Dados.Enabled = true;
            Btn_casdastro_categoria.Enabled = true;
        }

        public void desativar_botoes_menu()
        {
            Btn_Cadastro_Produto.Enabled = false;
            Btn_Cadatro_Cliente.Enabled = false;
            Btn_Confi_Sys.Enabled = false;
            Btn_Ver_Dados.Enabled = false;
            Btn_casdastro_categoria.Enabled = false;
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirJanela(Form fh)
        {

            formulario_filho_atual = fh;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            Painel_Pricipal.Controls.Add(fh);
            Painel_Pricipal.Tag = formulario_filho_atual;
            formulario_filho_atual.BringToFront();
            formulario_filho_atual.Show();
        }
        public void expandir_menu()
        {
            ativar_botoes_menu();

            if (Painel_Menu.Width == 267)
            {
                Painel_Menu.Width = 47;
                desativar_botoes_menu();
                
                

                
            }
            else
            {
                Painel_Menu.Width = 267;

            }
        }
       
      public  bool aberto;


        private void Btn_Expandir_Menu_Click(object sender, EventArgs e)
        {
            expandir_menu();
        }

        private void Btn_maximizar_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Maximized)
            {
                Btn_maximizar.Text = "Maximizar";
                WindowState = FormWindowState.Normal;
            }
            else
            {
                Btn_maximizar.Text = "Normal";
           
                WindowState = FormWindowState.Maximized;
            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_Cadatro_Cliente_Click(object sender, EventArgs e)
        {
            aberto = verificar_janela_aberta();

            if (aberto)
            {
                MessageBox.Show("A tela de Cadastro de cliente está aberta\né necessário fechar está tela", "Tela Aberta", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                expandir_menu();
                AbrirJanela(new TelacadasCliente());
            }
            
        }

        private void Painel_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_casdastro_categoria_Click(object sender, EventArgs e)
        {
            aberto = verificar_janela_aberta();
            if (aberto)
            {
                MessageBox.Show("A tela de Cadastro de categoria está aberta\né necessário fechar está tela", "Tela Aberta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                expandir_menu();
                AbrirJanela(new TelaAddCategoria());
                
            }

        }

        private void Btn_Cadastro_Produto_Click_1(object sender, EventArgs e)
        {

            aberto = verificar_janela_aberta();
            if (aberto)
            {
                MessageBox.Show("A tela de Cadastro de produtos está aberta\né necessário fechar está tela", "Tela Aberta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                expandir_menu();
                AbrirJanela(new TelaAddProduto());
               

            }   
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            Lbl_data.Text = DateTime.Now.ToString("dd/MMMMM/yyyy");
            Lbl_horario.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
