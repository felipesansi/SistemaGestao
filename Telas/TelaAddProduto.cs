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
    public partial class TelaAddProduto : Form
    {
        public TelaAddProduto()
        {
            InitializeComponent();
        }
        public  void AtivarBotoesProduto ()
        {
            //ativar botões tela produto

            Painel_mask_preco_venda_produto.Enabled = true;
            Painel__mask_quant_produto.Enabled = true;
            panel_txb_nome_produto.Enabled = true;
            //---------- txb e mask ---------
            Txb_nome_produto.Enabled = true;
            Mask_preco_produto.Enabled = true;
            Mask_quant_prod.Enabled = true;
            Mask_preco_aluguel_produto.Enabled = false;
            painel_aluguel_produto.Enabled = true;
            RbSim_produto.Enabled = true;
            RbNao_produto.Enabled = true;
            
            
        }

        private void TelaAddProduto_Load(object sender, EventArgs e)
        {

        }

        private void Btn_novo_produto_Click(object sender, EventArgs e)
        {
            AtivarBotoesProduto();
            
        }

        private void Btncancelarproduto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_salvar_produto_Click(object sender, EventArgs e)
        {

        }

        private void RbSim_produto_CheckedChanged(object sender, EventArgs e)
        {
            painel_aluguel_produto.Visible = true;
            Mask_preco_aluguel_produto.Visible = true;
        }

        
    }


}
