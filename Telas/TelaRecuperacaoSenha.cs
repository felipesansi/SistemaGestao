using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestao.Base_de_dados;
using SistemaGestao.Modelo;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace SistemaGestao.Telas
{
    public partial class TelaRecuperacaoSenha : Form
    {
        public TelaRecuperacaoSenha()
        {
            InitializeComponent();
        }

        
        private void Btn_Fechar_recuperacao_Click(object sender, EventArgs e)
        {
           DialogResult = MessageBox.Show("Deseja reamente fechar está tela?","Fechar Tela",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(DialogResult == DialogResult.Yes)
            {
                this.Close();

            }
            else
            {
                
            }
        }

        private void Btn_recuperar_Click(object sender, EventArgs e)
        { 
            Controle controle = new Controle();
            string mensagem = controle.redefinicaoSenha(Txb_recuperacao.Text);

            if (Txb_recuperacao.Text == string.Empty)
            {
                Lbl_mensagem_recuperacao.Text = "Preencha com seu e-mail ou nome de usuário para recuperar sua senha";
                
            }
          else if (controle.autenticado)
            {
                Lbl_mensagem_recuperacao.ForeColor = SystemColors.Control;
                Lbl_mensagem_recuperacao.Text = mensagem;
                Painel_recuperao.Enabled = true;
                Txb_codigo.Enabled = true;
                Btn_verificar_codigo.Enabled = true;
            }
            else
            {
                Lbl_mensagem_recuperacao.Text = controle.mensagem;
            }


        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_verificar_codigo_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            bool codiogo = controle.codigo_igual(Txb_codigo.Text);
            if (codiogo)
            {
                TelaNovaSenha telaNovaSenha = new TelaNovaSenha();
                telaNovaSenha.ShowDialog();
            }
            else
            {
                MessageBox.Show(controle.mensagem2);
            }
        }
    }
}
        

        
    


 