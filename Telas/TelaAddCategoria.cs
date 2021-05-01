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
    public partial class TelaAddCategoria : Form
    {
        public TelaAddCategoria()
        {
            InitializeComponent();
        }

        private void Btncancelarcategoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_salvar_categoria_Click(object sender, EventArgs e)
        {

            Controle controle = new Controle();

            string mensagem = controle.CadastroCategoria(Txb_nome_categoria.Text, Txb_descricao_categoria.Text);

            if (controle.autenticado)
            {
                MessageBox.Show(mensagem,"Categoria cadastrada com sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem, "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void Btn_novo_categoria_Click(object sender, EventArgs e)
        {
            
        }
    }
}
