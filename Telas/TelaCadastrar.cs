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
    public partial class TelaCadastrar : Form
    {
        public TelaCadastrar()
        {
            InitializeComponent();
        }

        private void Txb_senhaCadas_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
            for  (int contador = 0; contador<=Txb_senhaCadas.TextLength; contador++)
            {
                if (contador==0)
                {
                    lbl_leitor.Text = "";
                }
               else if (contador < 8)
                {
                    lbl_leitor.Text = "A senha é fraca ";
                    lbl_leitor.ForeColor = Color.Red;
                }
                else if (contador >= 8  && contador < 11) 
                {
                    lbl_leitor.Text = " A Senha é média";
                    lbl_leitor.ForeColor = Color.DarkOrange;
                }
                else if (contador >10)
                {
                    lbl_leitor.Text = "A Senha é forte";
                    lbl_leitor.ForeColor = Color.Green;
                }
            }
        }

        private void Txb_confCadas_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
            for (int contador2 = 0; contador2 <= Txb_confCadas.TextLength; contador2++)
            {

                if (contador2==0)
                {
                    lbl_leitor2.Text = "";
                }
                else if (contador2 < 8)
                {
                    lbl_leitor2.Text = "A senha é fraca ";
                    lbl_leitor2.ForeColor = Color.Red;
                }
                else if (contador2 >= 8 && contador2 < 11)
                {
                    lbl_leitor2.Text = "A Senha é média";
                    lbl_leitor2.ForeColor = Color.DarkOrange;
                }
                else if (contador2 > 10)
                {
                    lbl_leitor2.Text = "A Senha é forte";
                    lbl_leitor2.ForeColor = Color.Green;
                }
            }
        }
        
        private void Btn_cadas_Cadas_Click(object sender, EventArgs e)
        {
            

            Controle controle = new Controle();
         
            string mensagem = controle.CadastroSistema(Txb_nomeCadas.Text, Txb_emailCadas.Text, Txb_usuarioCadas.Text, Txb_senhaCadas.Text, Txb_confCadas.Text);

            if (controle.autenticado)
            {
                MessageBox.Show(mensagem, "Cadastro feito com sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show(controle.mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void Txb_usuarioCadas_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();
            for (int i = 0; i <= Txb_usuarioCadas.TextLength; i++)
            {
               
                if (i ==0)
                {
                    lblMensagem2.Text = "";
                }
               else if (i < 5)
                {
                    lblMensagem2.Text = "O nome de usuário está curto demais";
                    lblMensagem2.ForeColor = Color.Red;
                }
                else if (i >= 5)
                {
                    lblMensagem2.Text = "O nome de usuário está bom";
                    lblMensagem2.ForeColor = Color.Green;
                }
            }
        }

        private void BtnMostrarSenha1_Click(object sender, EventArgs e)
        {
            if (Txb_senhaCadas.UseSystemPasswordChar)
            {
                Txb_senhaCadas.UseSystemPasswordChar = false;
            }
            else
            {
                Txb_senhaCadas.UseSystemPasswordChar = true; 
            }
        }

        private void BtnMostrarSenha2_Click(object sender, EventArgs e)
        {
            if (Txb_confCadas.UseSystemPasswordChar)
            {
                Txb_confCadas.UseSystemPasswordChar = false;

            }
            else
            {
                Txb_confCadas.UseSystemPasswordChar = true;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            lblMensagem2.Text = "";
            lbl_leitor.Text = "";
            lbl_leitor2.Text = "";
        }
    }
}
