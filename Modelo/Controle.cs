using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestao.Base_de_dados;
using SistemaGestao.Telas;

namespace SistemaGestao.Modelo
{
    class Controle
    {
        public string mensagem = "";
        public string mensagem2 = "";
        public bool autenticado = false;
        BaseDeDados baseDeDados = new BaseDeDados();
     
       
        
        public string CadastroSistema(string nome_completo, string email, string usuario, string senha, string confi_senha)
        {
            
            this.mensagem = baseDeDados.Cadastrar_usuario(nome_completo, email, usuario, senha, confi_senha);
            
            if (baseDeDados.Autenticado )
            {
                autenticado = true;
            }

            return mensagem;
        }

        public bool Acessar(string usuario, string senha)
        {
            
            autenticado = baseDeDados.VerificarBanco(usuario, senha);

            if (!baseDeDados.mensagem.Equals(""))
            {
                this.mensagem = baseDeDados.mensagem;
            }

            return autenticado;
        }

        public string CadastroCategoria(string nome_categoria,string descricao_categoria)
        {

            this.mensagem = baseDeDados.CadastroCategoria(nome_categoria, descricao_categoria);

            if (baseDeDados.Autenticado)
            {
                autenticado = true;

            } 
                return mensagem;
        }

        public string CadastoProduto(string nome_produto, int quant_Produto, decimal preco_venda, string desc_produto, string pergunta_aluguel, decimal preco_aluguel)
        {
            this.mensagem = baseDeDados.CadastroProdutos(nome_produto, quant_Produto,preco_venda,desc_produto,pergunta_aluguel,preco_aluguel);

            if (baseDeDados.Autenticado)
            {
                autenticado = true;
            }       
            
            return mensagem;
        }

        public string CadastroCliente(string nome_cliente, string sexo, string cpf, string bairro, string endereco, string celular)
        {

            this.mensagem = baseDeDados.CadastroCliente(nome_cliente, sexo, cpf, bairro, endereco, celular);

            if (baseDeDados.Autenticado)
            {
                autenticado = true;
            }

            return mensagem;
        }
        
        public string redefinicaoSenha(string txb_emailouUsuario)
        {
            this.mensagem = baseDeDados.EnviarEmail(txb_emailouUsuario);
            if (baseDeDados.Autenticado)
            {
                autenticado = true;
            }
            return mensagem;
        }
      
        public bool codigo_igual(string codigo_digitado)
        {
            if (mensagem.Equals(codigo_digitado))
            {
                autenticado = true;
              
            }
            else
            {
                autenticado = false;
                mensagem2 = "Codigo errado";
            }
            return autenticado;
        }
    }
}
