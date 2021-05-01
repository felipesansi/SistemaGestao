namespace SistemaGestao.Telas
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.Painel_Pricipal = new System.Windows.Forms.Panel();
            this.Lbl_data = new System.Windows.Forms.Label();
            this.Lbl_horario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Btn_maximizar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Painel_Menu = new System.Windows.Forms.Panel();
            this.Btn_Cadastro_Produto = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Btn_casdastro_categoria = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Btn_Cadatro_Cliente = new System.Windows.Forms.Button();
            this.Btn_Ver_Dados = new System.Windows.Forms.Button();
            this.Btn_Confi_Sys = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Expandir_Menu = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.Painel_Pricipal.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Painel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Painel_Pricipal
            // 
            this.Painel_Pricipal.BackColor = System.Drawing.SystemColors.Control;
            this.Painel_Pricipal.Controls.Add(this.Lbl_data);
            this.Painel_Pricipal.Controls.Add(this.Lbl_horario);
            this.Painel_Pricipal.Controls.Add(this.panel2);
            this.Painel_Pricipal.Controls.Add(this.Painel_Menu);
            this.Painel_Pricipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Painel_Pricipal.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Painel_Pricipal.Location = new System.Drawing.Point(0, 0);
            this.Painel_Pricipal.Name = "Painel_Pricipal";
            this.Painel_Pricipal.Size = new System.Drawing.Size(964, 542);
            this.Painel_Pricipal.TabIndex = 0;
            this.Painel_Pricipal.Paint += new System.Windows.Forms.PaintEventHandler(this.Painel_Pricipal_Paint);
            // 
            // Lbl_data
            // 
            this.Lbl_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_data.AutoSize = true;
            this.Lbl_data.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_data.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_data.ForeColor = System.Drawing.Color.Gray;
            this.Lbl_data.Location = new System.Drawing.Point(399, 201);
            this.Lbl_data.Name = "Lbl_data";
            this.Lbl_data.Size = new System.Drawing.Size(0, 30);
            this.Lbl_data.TabIndex = 8;
            // 
            // Lbl_horario
            // 
            this.Lbl_horario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_horario.AutoSize = true;
            this.Lbl_horario.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_horario.Font = new System.Drawing.Font("Ebrima", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_horario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Lbl_horario.Location = new System.Drawing.Point(393, 130);
            this.Lbl_horario.Name = "Lbl_horario";
            this.Lbl_horario.Size = new System.Drawing.Size(0, 65);
            this.Lbl_horario.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_Fechar);
            this.panel2.Controls.Add(this.Btn_maximizar);
            this.panel2.Controls.Add(this.Btn_minimizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(48, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 41);
            this.panel2.TabIndex = 6;
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Fechar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Fechar.FlatAppearance.BorderSize = 0;
            this.Btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fechar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.Btn_Fechar.Location = new System.Drawing.Point(876, 0);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(40, 40);
            this.Btn_Fechar.TabIndex = 1;
            this.Btn_Fechar.Text = "x";
            this.Btn_Fechar.UseVisualStyleBackColor = false;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Btn_maximizar
            // 
            this.Btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_maximizar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_maximizar.FlatAppearance.BorderSize = 0;
            this.Btn_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_maximizar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_maximizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.Btn_maximizar.Location = new System.Drawing.Point(786, 0);
            this.Btn_maximizar.Name = "Btn_maximizar";
            this.Btn_maximizar.Size = new System.Drawing.Size(87, 40);
            this.Btn_maximizar.TabIndex = 4;
            this.Btn_maximizar.Text = "Normal";
            this.Btn_maximizar.UseVisualStyleBackColor = false;
            this.Btn_maximizar.Click += new System.EventHandler(this.Btn_maximizar_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_minimizar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.Btn_minimizar.Location = new System.Drawing.Point(753, -2);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(40, 40);
            this.Btn_minimizar.TabIndex = 3;
            this.Btn_minimizar.Text = "-";
            this.Btn_minimizar.UseVisualStyleBackColor = false;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Painel_Menu
            // 
            this.Painel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Painel_Menu.Controls.Add(this.Btn_Cadastro_Produto);
            this.Painel_Menu.Controls.Add(this.panel7);
            this.Painel_Menu.Controls.Add(this.Btn_casdastro_categoria);
            this.Painel_Menu.Controls.Add(this.panel6);
            this.Painel_Menu.Controls.Add(this.Btn_Cadatro_Cliente);
            this.Painel_Menu.Controls.Add(this.Btn_Ver_Dados);
            this.Painel_Menu.Controls.Add(this.Btn_Confi_Sys);
            this.Painel_Menu.Controls.Add(this.panel4);
            this.Painel_Menu.Controls.Add(this.panel3);
            this.Painel_Menu.Controls.Add(this.Btn_Expandir_Menu);
            this.Painel_Menu.Controls.Add(this.panel5);
            this.Painel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Painel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Painel_Menu.Name = "Painel_Menu";
            this.Painel_Menu.Size = new System.Drawing.Size(48, 542);
            this.Painel_Menu.TabIndex = 2;
            this.Painel_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Painel_Menu_Paint);
            // 
            // Btn_Cadastro_Produto
            // 
            this.Btn_Cadastro_Produto.Enabled = false;
            this.Btn_Cadastro_Produto.FlatAppearance.BorderSize = 0;
            this.Btn_Cadastro_Produto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.Btn_Cadastro_Produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cadastro_Produto.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadastro_Produto.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Cadastro_Produto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cadastro_Produto.Image")));
            this.Btn_Cadastro_Produto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cadastro_Produto.Location = new System.Drawing.Point(15, 197);
            this.Btn_Cadastro_Produto.Name = "Btn_Cadastro_Produto";
            this.Btn_Cadastro_Produto.Size = new System.Drawing.Size(263, 33);
            this.Btn_Cadastro_Produto.TabIndex = 20;
            this.Btn_Cadastro_Produto.Text = "Cadastro de Produto";
            this.Btn_Cadastro_Produto.UseVisualStyleBackColor = true;
            this.Btn_Cadastro_Produto.Click += new System.EventHandler(this.Btn_Cadastro_Produto_Click_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel7.Location = new System.Drawing.Point(3, 197);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(21, 33);
            this.panel7.TabIndex = 21;
            // 
            // Btn_casdastro_categoria
            // 
            this.Btn_casdastro_categoria.Enabled = false;
            this.Btn_casdastro_categoria.FlatAppearance.BorderSize = 0;
            this.Btn_casdastro_categoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.Btn_casdastro_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_casdastro_categoria.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_casdastro_categoria.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_casdastro_categoria.Image = ((System.Drawing.Image)(resources.GetObject("Btn_casdastro_categoria.Image")));
            this.Btn_casdastro_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_casdastro_categoria.Location = new System.Drawing.Point(15, 90);
            this.Btn_casdastro_categoria.Name = "Btn_casdastro_categoria";
            this.Btn_casdastro_categoria.Size = new System.Drawing.Size(263, 33);
            this.Btn_casdastro_categoria.TabIndex = 18;
            this.Btn_casdastro_categoria.Text = "Cadastro de Categoria";
            this.Btn_casdastro_categoria.UseVisualStyleBackColor = true;
            this.Btn_casdastro_categoria.Click += new System.EventHandler(this.Btn_casdastro_categoria_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel6.Location = new System.Drawing.Point(3, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(21, 33);
            this.panel6.TabIndex = 19;
            // 
            // Btn_Cadatro_Cliente
            // 
            this.Btn_Cadatro_Cliente.Enabled = false;
            this.Btn_Cadatro_Cliente.FlatAppearance.BorderSize = 0;
            this.Btn_Cadatro_Cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.Btn_Cadatro_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cadatro_Cliente.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cadatro_Cliente.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Cadatro_Cliente.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cadatro_Cliente.Image")));
            this.Btn_Cadatro_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cadatro_Cliente.Location = new System.Drawing.Point(15, 143);
            this.Btn_Cadatro_Cliente.Name = "Btn_Cadatro_Cliente";
            this.Btn_Cadatro_Cliente.Size = new System.Drawing.Size(263, 33);
            this.Btn_Cadatro_Cliente.TabIndex = 16;
            this.Btn_Cadatro_Cliente.Text = "Cadastro de Cliente";
            this.Btn_Cadatro_Cliente.UseVisualStyleBackColor = true;
            this.Btn_Cadatro_Cliente.Click += new System.EventHandler(this.Btn_Cadatro_Cliente_Click);
            // 
            // Btn_Ver_Dados
            // 
            this.Btn_Ver_Dados.Enabled = false;
            this.Btn_Ver_Dados.FlatAppearance.BorderSize = 0;
            this.Btn_Ver_Dados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.Btn_Ver_Dados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ver_Dados.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ver_Dados.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Ver_Dados.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ver_Dados.Image")));
            this.Btn_Ver_Dados.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_Ver_Dados.Location = new System.Drawing.Point(12, 254);
            this.Btn_Ver_Dados.Name = "Btn_Ver_Dados";
            this.Btn_Ver_Dados.Size = new System.Drawing.Size(263, 42);
            this.Btn_Ver_Dados.TabIndex = 10;
            this.Btn_Ver_Dados.Text = "Ver Dados\r\nCadastrados dos Clientes";
            this.Btn_Ver_Dados.UseVisualStyleBackColor = true;
            // 
            // Btn_Confi_Sys
            // 
            this.Btn_Confi_Sys.Enabled = false;
            this.Btn_Confi_Sys.FlatAppearance.BorderSize = 0;
            this.Btn_Confi_Sys.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.Btn_Confi_Sys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Confi_Sys.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Confi_Sys.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Confi_Sys.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Confi_Sys.Image")));
            this.Btn_Confi_Sys.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_Confi_Sys.Location = new System.Drawing.Point(12, 318);
            this.Btn_Confi_Sys.Name = "Btn_Confi_Sys";
            this.Btn_Confi_Sys.Size = new System.Drawing.Size(263, 42);
            this.Btn_Confi_Sys.TabIndex = 14;
            this.Btn_Confi_Sys.Text = "Configuração do Sistema";
            this.Btn_Confi_Sys.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateGray;
            this.panel4.Location = new System.Drawing.Point(0, 318);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 42);
            this.panel4.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Location = new System.Drawing.Point(0, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 42);
            this.panel3.TabIndex = 12;
            // 
            // Btn_Expandir_Menu
            // 
            this.Btn_Expandir_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Expandir_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Expandir_Menu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Expandir_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GrayText;
            this.Btn_Expandir_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Expandir_Menu.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Expandir_Menu.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Expandir_Menu.Image")));
            this.Btn_Expandir_Menu.Location = new System.Drawing.Point(-5, 3);
            this.Btn_Expandir_Menu.Name = "Btn_Expandir_Menu";
            this.Btn_Expandir_Menu.Size = new System.Drawing.Size(53, 29);
            this.Btn_Expandir_Menu.TabIndex = 13;
            this.Btn_Expandir_Menu.UseVisualStyleBackColor = true;
            this.Btn_Expandir_Menu.Click += new System.EventHandler(this.Btn_Expandir_Menu_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel5.Location = new System.Drawing.Point(3, 143);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(21, 33);
            this.panel5.TabIndex = 17;
            // 
            // tempo
            // 
            this.tempo.Enabled = true;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 542);
            this.Controls.Add(this.Painel_Pricipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Painel_Pricipal.ResumeLayout(false);
            this.Painel_Pricipal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Painel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Panel Painel_Menu;
        private System.Windows.Forms.Button Btn_Confi_Sys;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_Ver_Dados;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_Expandir_Menu;
        private System.Windows.Forms.Button Btn_maximizar;
        private System.Windows.Forms.Button Btn_minimizar;
        public System.Windows.Forms.Panel Painel_Pricipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Cadatro_Cliente;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Btn_casdastro_categoria;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Btn_Cadastro_Produto;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label Lbl_horario;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.Label Lbl_data;
    }
}