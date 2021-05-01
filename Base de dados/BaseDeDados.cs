using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using SistemaGestao.Modelo;
using System.Windows.Forms;
using SistemaGestao.Telas;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace SistemaGestao.Base_de_dados
{
    class BaseDeDados
    {
        //comandosSql: É comandos derivados do sql
        SqlCommand comandosSql = new SqlCommand();

        //Variavel de leitura
        SqlDataReader leituraDadosSql;

        //chamada da clesse conexao
        Conexao Conexao_BD = new Conexao();

        public bool Autenticado = false;

        public string mensagem = "";
        public string email;
        public string senha;
        public int codigo;
        validaçao validaçao = new validaçao();


        private string PrimeiraLetra(string nome)
        {


            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
        }

        public string Cadastrar_usuario(string nome_completo, string email, string usuario, string senha, string confi_senha)
        {
            if (nome_completo == string.Empty || email == string.Empty || usuario == string.Empty || senha == string.Empty || confi_senha == string.Empty)
            {
                this.mensagem = "Existe algum campo vazio\nPreencha todos os campos";
            }

            else if (UsuarioExistenteja(usuario))
            {
                this.mensagem = "Este nome de usuário Não pode ser colocado, tente outro";

                Autenticado = false;
            }

            else if (EmailExistenteja(email))
            {
                this.mensagem = "Este e-mail Não pode ser colocado, tente outro";

                Autenticado = false;
            }

            else if (email.Contains("hotmail.com") || email.Contains("outlook.com") || email.Contains("gmail.com") || email.Contains(".com"))
            {
                if (confi_senha.Equals(senha))
                {
                    if (senha.Length >= 8)
                    {
                        PrimeiraLetra(nome_completo);

                        if (usuario.Length >= 4)
                        {
                            comandosSql.CommandText = "insert into Tb_login values(@n,@e, @u, @s)";

                            comandosSql.Parameters.AddWithValue("@n", nome_completo);

                            comandosSql.Parameters.AddWithValue("@e", email);

                            comandosSql.Parameters.AddWithValue("@u", usuario);

                            comandosSql.Parameters.AddWithValue("@s", senha);

                            try
                            {
                                comandosSql.Connection = Conexao_BD.Conectar();

                                leituraDadosSql.Close();

                                comandosSql.ExecuteNonQuery();

                                Autenticado = true;

                                this.mensagem = "Cadastro feito com sucesso";
                            }
                            catch (SqlException erro)
                            {
                                this.mensagem = "Problemas com Banco de Dados" + erro;
                            }
                        }
                        else
                        {
                            this.mensagem = "O nome de usuário deve ter no minimo 4 caracteres";
                        }
                    }
                    else
                    {
                        this.mensagem = "A Senha deve conter no minimo 8 caracteres";
                    }
                }
                else
                {
                    this.mensagem = "A senha e confirmar senha não correspondem";
                }
            }
            return mensagem;
        }

        public bool VerificarBanco(string usuario, string senha)
        {
            comandosSql.CommandText = "Select * from Tb_login where Usuario = @usuario or Email = @email and Senha = @senha";

            comandosSql.Parameters.AddWithValue("@usuario", usuario);

            comandosSql.Parameters.AddWithValue("@email", usuario);

            comandosSql.Parameters.AddWithValue("@senha", senha);

            try
            {
                comandosSql.Connection = Conexao_BD.Conectar();

                leituraDadosSql = comandosSql.ExecuteReader();

                if (leituraDadosSql.HasRows)
                {
                    Autenticado = true;
                }

            }
            catch (SqlException erro)
            {
                mensagem = "Problemas com Banco de dados" + erro;

            }

            return Autenticado;
        }

        public bool UsuarioExistenteja(string usuario)
        {
            comandosSql.CommandText = "Select * from Tb_login where Usuario = @usuario ";

            comandosSql.Parameters.AddWithValue("@usuario", usuario);
            try
            {
                comandosSql.Connection = Conexao_BD.Conectar();
                leituraDadosSql = comandosSql.ExecuteReader();

                if (leituraDadosSql.HasRows)
                {
                    Autenticado = true;

                }
            }
            catch (SqlException erro)
            {
                Conexao_BD.desconectar();
                mensagem = "Problemas com Banco de dados" + erro;

            }
            return Autenticado;
        }

        public bool EmailExistenteja(string email)
        {
            comandosSql.CommandText = "Select * from Tb_login where email = @email ";

            comandosSql.Parameters.AddWithValue("@email", email);
            try
            {
                comandosSql.Connection = Conexao_BD.Conectar();

                leituraDadosSql.Close();

                leituraDadosSql = comandosSql.ExecuteReader();

                if (leituraDadosSql.HasRows)
                {
                    Autenticado = true;

                }
            }
            catch (SqlException)
            {

                mensagem = "Problemas com Banco de dados";

            }
            return Autenticado;
        }

        public bool CategoriaExistente(string nome_categoria, string desc_categoria)
        {
            comandosSql.CommandText = "Select * from Tb_categoria where nome_categoria = @nome_categoria and desc_categoria = @desc_categoria";

            comandosSql.Parameters.AddWithValue("@nome_categoria", nome_categoria);

            comandosSql.Parameters.AddWithValue("@desc_categoria", desc_categoria);


            try
            {

                comandosSql.Connection = Conexao_BD.Conectar();

                leituraDadosSql.Close();

                leituraDadosSql = comandosSql.ExecuteReader();

                if (leituraDadosSql.HasRows)
                {
                    Autenticado = true;
                }

            }
            catch (SqlException)
            {
                mensagem = "Problemas com Banco de dados";


            }



            return Autenticado;
        }

        public string CadastroCategoria(string nome_categoria, string desc_categoria)
        {
            if (CategoriaExistente(nome_categoria, desc_categoria))
            {
                this.mensagem = "Está categoria´já existe";
                Autenticado = false;
            }
            else
            {
                comandosSql.CommandText = "insert into Tb_categoria values(@nome_categoria,@des_categoria)";

                comandosSql.Parameters.AddWithValue("@nome_categoria", nome_categoria);

                comandosSql.Parameters.AddWithValue("@des_categoria", desc_categoria);
                try
                {
                    comandosSql.Connection = Conexao_BD.Conectar();

                    leituraDadosSql.Close();

                    comandosSql.ExecuteNonQuery();

                    Autenticado = true;

                    this.mensagem = "Cadastro de Categoria feito com Sucesso";
                }
                catch (SqlException)
                {
                    mensagem = "Problemas com Banco de dados";
                }

            }

            return mensagem;
        }

        public bool ProdutoExistente(string nome_produto, string desc_produto)
        {

            comandosSql.CommandText = "select * from Tb_produtos  = @nome_produto and desc_produto = @desc_produto ";

            comandosSql.Parameters.AddWithValue("@nome_produto", nome_produto);

            comandosSql.Parameters.AddWithValue(" @desc_produto ", desc_produto);

            try
            {
                comandosSql.Connection = Conexao_BD.Conectar();

                leituraDadosSql.Close();

                leituraDadosSql = comandosSql.ExecuteReader();


                if (leituraDadosSql.HasRows)
                {
                    Autenticado = true;

                }
            }
            catch (SqlException)
            {
                mensagem = "Problemas com Banco de dados";

            }
            return Autenticado;
        }

        public string CadastroProdutos(string nome_produto, int quant_Produto, decimal preco_venda, string desc_produto, string pergunta_aluguel, decimal preco_aluguel)
        {
            if (ProdutoExistente(nome_produto, desc_produto))
            {
                Autenticado = false;

                this.mensagem = "Este produo´já existe";

            }
            else
            {


                comandosSql.CommandText = "insert into Tb_produtos values( @n, @q,  @pv, @d, @per, @pa) ";

                comandosSql.Parameters.AddWithValue("@n", nome_produto);

                comandosSql.Parameters.AddWithValue("@q", quant_Produto);

                comandosSql.Parameters.AddWithValue("@pv", preco_venda);

                comandosSql.Parameters.AddWithValue("@d", desc_produto);

                comandosSql.Parameters.AddWithValue("@per", pergunta_aluguel);

                comandosSql.Parameters.AddWithValue("@pa", preco_aluguel);

                try
                {
                    comandosSql.Connection = Conexao_BD.Conectar();

                    leituraDadosSql.Close();

                    comandosSql.ExecuteNonQuery();

                    Autenticado = true;

                    this.mensagem = "Cadastro de Produto efeituado com Sucesso";
                }
                catch (SqlException)
                {

                    mensagem = "Problemas com Banco de dados";
                }

            }
            return mensagem;
        }

        public bool ClienteExistente(string nome)
        {
            comandosSql.CommandText = "Select * from Tb_cliente where nomecliente = @nome_cliente ";

            comandosSql.Parameters.AddWithValue("@nome_cliente", nome);

            try
            {
                comandosSql.Connection = Conexao_BD.Conectar();



                leituraDadosSql = comandosSql.ExecuteReader();

                if (leituraDadosSql.HasRows)
                {
                    Autenticado = true;

                }


            }
            catch (SqlException)
            {

                mensagem = "Problemas com Banco de dados";

            }


            return Autenticado;
        }

        public string CadastroCliente(string nome_cliente, string sexo, string cpf, string bairro, string endereco, string celular)
        {

            if (ClienteExistente(nome_cliente))
            {
                Autenticado = true;

                this.mensagem = "Este Cliente está no Sistma";
            }

            else if (validaçao.ValidaCPF(cpf))
            {

                comandosSql.CommandText = "insert into Tb_cliente values(@n, @s, @c, @b, @e, @cel)";

                comandosSql.Parameters.AddWithValue("@n", nome_cliente);

                comandosSql.Parameters.AddWithValue("@s", sexo);

                comandosSql.Parameters.AddWithValue("@c", cpf);

                comandosSql.Parameters.AddWithValue("@b", bairro);

                comandosSql.Parameters.AddWithValue("@e", endereco);

                comandosSql.Parameters.AddWithValue("@cel", celular);

                try
                {
                    comandosSql.Connection = Conexao_BD.Conectar();

                    comandosSql.ExecuteNonQuery();

                    Autenticado = true;

                    this.mensagem = "Cadastro de Cliente efeituado com Sucesso";

                }
                catch (SqlException erro)
                {
                    mensagem = "Problemas com Banco de dados" + erro;
                    Conexao_BD.desconectar();

                }
            }
            else
            {
                this.mensagem = "CPF invalido.\nDigite o CPF Novamente";

            }


            return mensagem;
        }


        public bool EmailouUsuarioExistente(string email_usuario)
        {
            comandosSql.CommandText = "Select * from Tb_login where usuario = @u or email = @e";

            comandosSql.Parameters.AddWithValue("@u", email_usuario);

            comandosSql.Parameters.AddWithValue("@e", email_usuario);

            try
            {
                comandosSql.Connection = Conexao_BD.Conectar();

                leituraDadosSql = comandosSql.ExecuteReader();

                if (leituraDadosSql.HasRows)
                {
                    Autenticado = true;
                    Conexao_BD.desconectar();
                }
                else
                {
                    Autenticado = false;

                    mensagem = "Não existe conta associada a este email";

                    Conexao_BD.desconectar();
                }
            }
            catch (SqlException)
            {

                mensagem = "Problemas com Banco de Dados";
            }


            return Autenticado;
        }


        public string codigo1;

        public string GerarCodigo()
        {
            Random NumeroAleatorio = new Random();
            codigo = NumeroAleatorio.Next(1000, 9000);
            codigo1 = codigo.ToString();

            return codigo1;
        }
        public string EnviarEmail(string destinatario)
        {
            GerarCodigo();
            string remetente = "softwaresuporte1@gmail.com", senha_remetente = "admin123_", stmp = "smtp.gmail.com"; int port = 587;


            if (EmailouUsuarioExistente(destinatario))
            {
                comandosSql.CommandText = "Select * from Tb_login where usuario = @user or email = @email";

                comandosSql.Parameters.AddWithValue("@user", destinatario);

                comandosSql.Parameters.AddWithValue("@email", destinatario);
                try
                {
                    comandosSql.Connection = Conexao_BD.Conectar();
                    leituraDadosSql = comandosSql.ExecuteReader();
                    if (leituraDadosSql.Read())
                    {
                        email = leituraDadosSql.GetString(2);
                        senha = leituraDadosSql.GetString(4);
                    }
                }
                catch (Exception erro)
                {
                    mensagem = "erro inesperado" + erro;

                }
                
                SmtpClient client;
                NetworkCredential login;
                MailMessage msg;

                try
                {
                    login = new NetworkCredential(remetente, senha_remetente);
                    client = new SmtpClient(stmp);
                    client.Port = port;
                    client.EnableSsl = true;
                    client.Credentials = login;

                    msg = new MailMessage();
                    msg.To.Add(email);
                    msg.From = new MailAddress(remetente);
                    msg.Subject = "Solicitação de Recuperação de senha - Software Solution";
                    msg.Body = codigo1;

                    Controle controle = new Controle();
                    controle.mensagem = codigo1;

                    msg.BodyEncoding = Encoding.UTF8;
                    msg.IsBodyHtml = false;
                    msg.Priority = MailPriority.High;
                    client.Send(msg);
                    this.mensagem = "Enviamos um E-mail para o seu email" + email + " cadastrado no sistma\nVerifique seu email";
                }
                catch (Exception)
                {

                    MessageBox.Show("Houve algum problema");
                }
            }
            return mensagem;
        }
       


    }
}
