using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestao.Modelo;
using SistemaGestao.Telas;


namespace SistemaGestao.Telas
{
    public partial class TelaEntrar : Form
    {
        private Form formulario_filho_atual;

        public TelaEntrar()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Txb_usuarioEntrar_Click(object sender, EventArgs e)
        {
            if (Txb_usuarioEntrar.Focus())
            {
                Txb_usuarioEntrar.BackColor = Color.White;
                panel_txb_usuarioEntrar.BackColor = Color.White;

                panel_Txb_senhsEntrar.BackColor = SystemColors.Control;
                Txb_senhaEntrar.BackColor = SystemColors.Control;
                

            }

        }

        private void Txb_usuarioEntrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txb_senhaEntrar_Click(object sender, EventArgs e)
        {
            if (Txb_senhaEntrar.Focus())
            {
                Txb_senhaEntrar.BackColor = Color.White;
                panel_Txb_senhsEntrar.BackColor = Color.White;

                Txb_usuarioEntrar.BackColor = SystemColors.Control;
                panel_txb_usuarioEntrar.BackColor = SystemColors.Control;
                
            }
            
        }


        private void AbrirJanelaCadastro(Form fh)
        {
            formulario_filho_atual = fh;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            panel2.Controls.Add(fh);
            panel2.Tag = formulario_filho_atual;
            formulario_filho_atual.BringToFront();
            formulario_filho_atual.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirJanelaCadastro(new TelaCadastrar());
            Btn_cadastrarEntrar.BackColor = SystemColors.ActiveCaption;
            Btn_login2.BackColor = SystemColors.Control;
            Btn_login2.Enabled = true;
            Btn_cadastrarEntrar.Enabled = false;
        }


      




      private void button1_Click(object sender, EventArgs e)
      {

            if (Txb_senhaEntrar.UseSystemPasswordChar)
            {
                Txb_senhaEntrar.UseSystemPasswordChar = false;
            }
            else
            {
                Txb_senhaEntrar.UseSystemPasswordChar = true;
            }
      }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Btn_login2.Enabled = false;
            Btn_cadastrarEntrar.Enabled = true;
            formulario_filho_atual.Close();
            Btn_login2.BackColor = SystemColors.ActiveCaption;
            Btn_cadastrarEntrar.BackColor = SystemColors.Control;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void TelaEntrar_Load(object sender, EventArgs e)
        {

        }

        private void panel_txb_usuarioEntrar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_LoginEntrar_Click(object sender, EventArgs e)
        {
            
            Controle controle = new Controle();
            controle.Acessar(Txb_usuarioEntrar.Text, Txb_senhaEntrar.Text);
         

            if (controle.autenticado==false)
            {
                if (Txb_usuarioEntrar.Text == string.Empty && Txb_senhaEntrar.Text == string.Empty)
                {
                    timer1.Enabled = true;
                    Lbl_mensagem.Visible = true;
                    Lbl_mensagem.Text = "Os dois campos estão vazios, informe seu usuário e senha";

                }
               else if (Txb_usuarioEntrar.Text == string.Empty)
                {

                    timer1.Enabled = true;
                    Lbl_mensagem.Visible = true;
                    Lbl_mensagem.Text = "Preencha o campo de usuário";

                }
                else if (Txb_senhaEntrar.Text == string.Empty)
                {

                    timer1.Enabled = true;
                    Lbl_mensagem.Visible = true;
                    Lbl_mensagem.Text = "Preencha o campo de senha";
                }
                else
                {
                    timer1.Enabled = true;
                    Lbl_mensagem.Visible = true;
                    Lbl_mensagem.Text = "O usuário ou senha estão incorretos,\n verifique usuário e senha";
                }
            }
            else
            {
                TelaPrincipal tela_Principal = new TelaPrincipal();
                tela_Principal.Show();
                this.Close();

           
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_mensagem.Visible = false;
            Lbl_mensagem.Text = "";
        }

        private void Btn_esqueciSenha_Click(object sender, EventArgs e)
        {
            TelaRecuperacaoSenha recuperacaoSenha = new TelaRecuperacaoSenha();

            recuperacaoSenha.ShowDialog();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
} 