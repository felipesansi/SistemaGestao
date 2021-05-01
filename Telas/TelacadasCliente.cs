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
namespace SistemaGestao.Telas
{
    public partial class TelacadasCliente : Form
    {
        private Form formulario_filho_atual = new Form();
        public string sexo;
        public TelacadasCliente()
        {
            InitializeComponent();
        }
        public void AtivarBotoesCliente()
        {
            panel_txb_nome_cliente.Enabled = true;
            panel_txb_endereco_cliente.Enabled = true;
            panel_txb_bairro_cliente.Enabled = true;
            Btn_novo_cliente.Enabled = false;
            Txb_nome_cliente.Enabled = true;
            RbF_cliente.Enabled = true;
            RbM_cliente.Enabled = true;
            Mask_cpf_cliente.Enabled = true;
            Mask_celular_cliente.Enabled = true;
            Txb_endereco_cliente.Enabled = true;
            Txb_bairro_cliente.Enabled = true;
            Painel_sexo_cliente.Enabled = true;
            Painel__mask_cpf_cliente.Enabled = true;
            Painel_mask_celular_cliente.Enabled = true;
            Btn_salvar_cliente.Enabled = true;
        }
        private void AbrirJanelaEmpresa(Form fh)
        {

            formulario_filho_atual = fh;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            PainelPrincipa3. Controls.Add(fh);
            PainelPrincipa3. Tag = formulario_filho_atual;
            formulario_filho_atual.BringToFront();
            formulario_filho_atual.Show();
        }

        private void Btncancelarcliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_cadasempresa_cliente_Click(object sender, EventArgs e)
        {
            AbrirJanelaEmpresa(new TelaCadsEmpresa());
        }
       
        private void Btn_novo_cliente_Click(object sender, EventArgs e)
        {
            AtivarBotoesCliente();
        }

        private void Btn_salvar_cliente_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem = controle.CadastroCliente(Txb_nome_cliente.Text,sexo,Mask_cpf_cliente.Text,Txb_bairro_cliente.Text,Txb_endereco_cliente.Text,Mask_celular_cliente.Text);
            if (controle.autenticado)
            {
                MessageBox.Show(mensagem, "Cadatro bem feito",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(mensagem,"erro" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                Mask_cpf_cliente.Focus();
                Mask_cpf_cliente.Clear();
                
            }
        }

        private void RbF_cliente_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Feminino";
        }

        private void RbM_cliente_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "Masculino";
        }

        private void Btn_fechartela_Click(object sender, EventArgs e)
        {
            TelaPrincipal tela_p = new TelaPrincipal();
            tela_p.janela_aberta = false;
            tela_p.aberto = false;
            this.Close();

            
        }
    }
}                                       