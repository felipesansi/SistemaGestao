namespace SistemaGestao.Telas
{
    partial class TelaRecuperacaoSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRecuperacaoSenha));
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Txb_recuperacao = new System.Windows.Forms.TextBox();
            this.panel_txb_usuarioEntrar = new System.Windows.Forms.Panel();
            this.Lbl_mensagem_recuperacao = new System.Windows.Forms.Label();
            this.Btn_recuperar = new System.Windows.Forms.Button();
            this.Btn_Fechar_recuperacao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Painel_recuperao = new System.Windows.Forms.Panel();
            this.Txb_codigo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_verificar_codigo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_txb_usuarioEntrar.SuspendLayout();
            this.Painel_recuperao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Recuperação de senha";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // Txb_recuperacao
            // 
            this.Txb_recuperacao.BackColor = System.Drawing.SystemColors.Control;
            this.Txb_recuperacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_recuperacao.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_recuperacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Txb_recuperacao.Location = new System.Drawing.Point(49, 10);
            this.Txb_recuperacao.Name = "Txb_recuperacao";
            this.Txb_recuperacao.Size = new System.Drawing.Size(370, 22);
            this.Txb_recuperacao.TabIndex = 1;
            // 
            // panel_txb_usuarioEntrar
            // 
            this.panel_txb_usuarioEntrar.BackColor = System.Drawing.SystemColors.Control;
            this.panel_txb_usuarioEntrar.Controls.Add(this.Txb_recuperacao);
            this.panel_txb_usuarioEntrar.Controls.Add(this.pictureBox3);
            this.panel_txb_usuarioEntrar.Location = new System.Drawing.Point(22, 111);
            this.panel_txb_usuarioEntrar.Name = "panel_txb_usuarioEntrar";
            this.panel_txb_usuarioEntrar.Size = new System.Drawing.Size(450, 45);
            this.panel_txb_usuarioEntrar.TabIndex = 9;
            // 
            // Lbl_mensagem_recuperacao
            // 
            this.Lbl_mensagem_recuperacao.AutoSize = true;
            this.Lbl_mensagem_recuperacao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_mensagem_recuperacao.Location = new System.Drawing.Point(119, 159);
            this.Lbl_mensagem_recuperacao.Name = "Lbl_mensagem_recuperacao";
            this.Lbl_mensagem_recuperacao.Size = new System.Drawing.Size(0, 13);
            this.Lbl_mensagem_recuperacao.TabIndex = 11;
            // 
            // Btn_recuperar
            // 
            this.Btn_recuperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Btn_recuperar.FlatAppearance.BorderSize = 0;
            this.Btn_recuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_recuperar.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_recuperar.ForeColor = System.Drawing.Color.White;
            this.Btn_recuperar.Location = new System.Drawing.Point(22, 202);
            this.Btn_recuperar.Name = "Btn_recuperar";
            this.Btn_recuperar.Size = new System.Drawing.Size(185, 33);
            this.Btn_recuperar.TabIndex = 12;
            this.Btn_recuperar.Text = "Recuperar senha";
            this.Btn_recuperar.UseVisualStyleBackColor = false;
            this.Btn_recuperar.Click += new System.EventHandler(this.Btn_recuperar_Click);
            // 
            // Btn_Fechar_recuperacao
            // 
            this.Btn_Fechar_recuperacao.FlatAppearance.BorderSize = 0;
            this.Btn_Fechar_recuperacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn_Fechar_recuperacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fechar_recuperacao.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar_recuperacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.Btn_Fechar_recuperacao.Location = new System.Drawing.Point(449, -1);
            this.Btn_Fechar_recuperacao.Name = "Btn_Fechar_recuperacao";
            this.Btn_Fechar_recuperacao.Size = new System.Drawing.Size(40, 40);
            this.Btn_Fechar_recuperacao.TabIndex = 13;
            this.Btn_Fechar_recuperacao.Text = "x";
            this.Btn_Fechar_recuperacao.UseVisualStyleBackColor = true;
            this.Btn_Fechar_recuperacao.Click += new System.EventHandler(this.Btn_Fechar_recuperacao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 14);
            this.label5.TabIndex = 19;
            this.label5.Text = "Informe seu e-mail ou nome de usuário";
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_minimizar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(138)))), ((int)(((byte)(185)))));
            this.Btn_minimizar.Location = new System.Drawing.Point(401, -1);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(40, 40);
            this.Btn_minimizar.TabIndex = 20;
            this.Btn_minimizar.Text = "-";
            this.Btn_minimizar.UseVisualStyleBackColor = false;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Painel_recuperao
            // 
            this.Painel_recuperao.BackColor = System.Drawing.SystemColors.Control;
            this.Painel_recuperao.Controls.Add(this.Txb_codigo);
            this.Painel_recuperao.Controls.Add(this.pictureBox1);
            this.Painel_recuperao.Enabled = false;
            this.Painel_recuperao.Location = new System.Drawing.Point(22, 263);
            this.Painel_recuperao.Name = "Painel_recuperao";
            this.Painel_recuperao.Size = new System.Drawing.Size(450, 45);
            this.Painel_recuperao.TabIndex = 21;
            // 
            // Txb_codigo
            // 
            this.Txb_codigo.BackColor = System.Drawing.SystemColors.Control;
            this.Txb_codigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_codigo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_codigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Txb_codigo.Location = new System.Drawing.Point(49, 10);
            this.Txb_codigo.Name = "Txb_codigo";
            this.Txb_codigo.Size = new System.Drawing.Size(370, 22);
            this.Txb_codigo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_verificar_codigo
            // 
            this.Btn_verificar_codigo.BackColor = System.Drawing.Color.Green;
            this.Btn_verificar_codigo.Enabled = false;
            this.Btn_verificar_codigo.FlatAppearance.BorderSize = 0;
            this.Btn_verificar_codigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_verificar_codigo.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_verificar_codigo.ForeColor = System.Drawing.Color.White;
            this.Btn_verificar_codigo.Location = new System.Drawing.Point(22, 329);
            this.Btn_verificar_codigo.Name = "Btn_verificar_codigo";
            this.Btn_verificar_codigo.Size = new System.Drawing.Size(142, 31);
            this.Btn_verificar_codigo.TabIndex = 22;
            this.Btn_verificar_codigo.Text = "Verificar codigo";
            this.Btn_verificar_codigo.UseVisualStyleBackColor = false;
            this.Btn_verificar_codigo.Click += new System.EventHandler(this.Btn_verificar_codigo_Click);
            // 
            // TelaRecuperacaoSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(491, 372);
            this.Controls.Add(this.Btn_verificar_codigo);
            this.Controls.Add(this.Painel_recuperao);
            this.Controls.Add(this.Btn_minimizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Fechar_recuperacao);
            this.Controls.Add(this.Btn_recuperar);
            this.Controls.Add(this.Lbl_mensagem_recuperacao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel_txb_usuarioEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaRecuperacaoSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaRecuperacaoSenha";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_txb_usuarioEntrar.ResumeLayout(false);
            this.panel_txb_usuarioEntrar.PerformLayout();
            this.Painel_recuperao.ResumeLayout(false);
            this.Painel_recuperao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox Txb_recuperacao;
        public System.Windows.Forms.Panel panel_txb_usuarioEntrar;
        private System.Windows.Forms.Label Lbl_mensagem_recuperacao;
        public System.Windows.Forms.Button Btn_recuperar;
        private System.Windows.Forms.Button Btn_Fechar_recuperacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_minimizar;
        public System.Windows.Forms.Panel Painel_recuperao;
        private System.Windows.Forms.TextBox Txb_codigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button Btn_verificar_codigo;
    }
}