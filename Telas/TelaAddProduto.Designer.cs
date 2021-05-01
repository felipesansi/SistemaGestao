namespace SistemaGestao.Telas
{
    partial class TelaAddProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAddProduto));
            this.Btn_salvar_produto = new System.Windows.Forms.Button();
            this.panel_txb_nome_produto = new System.Windows.Forms.Panel();
            this.Txb_nome_produto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Painel__mask_quant_produto = new System.Windows.Forms.Panel();
            this.Mask_quant_prod = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Painel_mask_preco_venda_produto = new System.Windows.Forms.Panel();
            this.Mask_preco_produto = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Cbx_categoria = new System.Windows.Forms.ComboBox();
            this.dataGridView1Produto = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_novo_produto = new System.Windows.Forms.Button();
            this.Txb_pesquisar_produto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_alterar_produto = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_excuir_produto = new System.Windows.Forms.Button();
            this.Btncancelarproduto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Txb_descricao_produto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.painel_aluguel_produto = new System.Windows.Forms.Panel();
            this.Mask_preco_aluguel_produto = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Painel_sexo_cliente = new System.Windows.Forms.Panel();
            this.RbSim_produto = new System.Windows.Forms.RadioButton();
            this.RbNao_produto = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_txb_nome_produto.SuspendLayout();
            this.Painel__mask_quant_produto.SuspendLayout();
            this.Painel_mask_preco_venda_produto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Produto)).BeginInit();
            this.painel_aluguel_produto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Painel_sexo_cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_salvar_produto
            // 
            this.Btn_salvar_produto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_salvar_produto.Enabled = false;
            this.Btn_salvar_produto.FlatAppearance.BorderSize = 0;
            this.Btn_salvar_produto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Btn_salvar_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salvar_produto.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salvar_produto.ForeColor = System.Drawing.Color.White;
            this.Btn_salvar_produto.Location = new System.Drawing.Point(215, 585);
            this.Btn_salvar_produto.Name = "Btn_salvar_produto";
            this.Btn_salvar_produto.Size = new System.Drawing.Size(171, 29);
            this.Btn_salvar_produto.TabIndex = 20;
            this.Btn_salvar_produto.Text = "Salvar Dados";
            this.Btn_salvar_produto.UseVisualStyleBackColor = false;
            this.Btn_salvar_produto.Click += new System.EventHandler(this.Btn_salvar_produto_Click);
            // 
            // panel_txb_nome_produto
            // 
            this.panel_txb_nome_produto.BackColor = System.Drawing.SystemColors.Control;
            this.panel_txb_nome_produto.Controls.Add(this.Txb_nome_produto);
            this.panel_txb_nome_produto.Enabled = false;
            this.panel_txb_nome_produto.Location = new System.Drawing.Point(17, 135);
            this.panel_txb_nome_produto.Name = "panel_txb_nome_produto";
            this.panel_txb_nome_produto.Size = new System.Drawing.Size(298, 45);
            this.panel_txb_nome_produto.TabIndex = 18;
            // 
            // Txb_nome_produto
            // 
            this.Txb_nome_produto.BackColor = System.Drawing.SystemColors.Control;
            this.Txb_nome_produto.Enabled = false;
            this.Txb_nome_produto.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_nome_produto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Txb_nome_produto.Location = new System.Drawing.Point(9, 10);
            this.Txb_nome_produto.Multiline = true;
            this.Txb_nome_produto.Name = "Txb_nome_produto";
            this.Txb_nome_produto.Size = new System.Drawing.Size(260, 24);
            this.Txb_nome_produto.TabIndex = 2;
            this.Txb_nome_produto.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(10, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(357, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cadastre seu produto em segundos...";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(14, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome do produto:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Selecione a Categoria do Produto:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(14, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Qual a  quantidade no Estoque:";
            // 
            // Painel__mask_quant_produto
            // 
            this.Painel__mask_quant_produto.BackColor = System.Drawing.SystemColors.Control;
            this.Painel__mask_quant_produto.Controls.Add(this.Mask_quant_prod);
            this.Painel__mask_quant_produto.Enabled = false;
            this.Painel__mask_quant_produto.Location = new System.Drawing.Point(17, 212);
            this.Painel__mask_quant_produto.Name = "Painel__mask_quant_produto";
            this.Painel__mask_quant_produto.Size = new System.Drawing.Size(298, 45);
            this.Painel__mask_quant_produto.TabIndex = 26;
            // 
            // Mask_quant_prod
            // 
            this.Mask_quant_prod.BackColor = System.Drawing.SystemColors.Control;
            this.Mask_quant_prod.Enabled = false;
            this.Mask_quant_prod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Mask_quant_prod.Location = new System.Drawing.Point(9, 14);
            this.Mask_quant_prod.Mask = "00000";
            this.Mask_quant_prod.Name = "Mask_quant_prod";
            this.Mask_quant_prod.RejectInputOnFirstFailure = true;
            this.Mask_quant_prod.Size = new System.Drawing.Size(260, 20);
            this.Mask_quant_prod.TabIndex = 28;
            this.Mask_quant_prod.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.Mask_quant_prod.ValidatingType = typeof(int);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(207, 585);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 29);
            this.panel2.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(14, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Qual o Preço de Venda:";
            // 
            // Painel_mask_preco_venda_produto
            // 
            this.Painel_mask_preco_venda_produto.BackColor = System.Drawing.SystemColors.Control;
            this.Painel_mask_preco_venda_produto.Controls.Add(this.Mask_preco_produto);
            this.Painel_mask_preco_venda_produto.Controls.Add(this.pictureBox2);
            this.Painel_mask_preco_venda_produto.Enabled = false;
            this.Painel_mask_preco_venda_produto.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Painel_mask_preco_venda_produto.Location = new System.Drawing.Point(17, 287);
            this.Painel_mask_preco_venda_produto.Name = "Painel_mask_preco_venda_produto";
            this.Painel_mask_preco_venda_produto.Size = new System.Drawing.Size(298, 45);
            this.Painel_mask_preco_venda_produto.TabIndex = 29;
            // 
            // Mask_preco_produto
            // 
            this.Mask_preco_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mask_preco_produto.BackColor = System.Drawing.SystemColors.Control;
            this.Mask_preco_produto.Enabled = false;
            this.Mask_preco_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mask_preco_produto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Mask_preco_produto.Location = new System.Drawing.Point(9, 9);
            this.Mask_preco_produto.Mask = "$:000 ,000";
            this.Mask_preco_produto.Name = "Mask_preco_produto";
            this.Mask_preco_produto.Size = new System.Drawing.Size(274, 26);
            this.Mask_preco_produto.SkipLiterals = false;
            this.Mask_preco_produto.TabIndex = 79;
            this.Mask_preco_produto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Cbx_categoria
            // 
            this.Cbx_categoria.Enabled = false;
            this.Cbx_categoria.FormattingEnabled = true;
            this.Cbx_categoria.Location = new System.Drawing.Point(17, 87);
            this.Cbx_categoria.Name = "Cbx_categoria";
            this.Cbx_categoria.Size = new System.Drawing.Size(295, 21);
            this.Cbx_categoria.TabIndex = 25;
            // 
            // dataGridView1Produto
            // 
            this.dataGridView1Produto.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Produto.GridColor = System.Drawing.Color.White;
            this.dataGridView1Produto.Location = new System.Drawing.Point(634, 69);
            this.dataGridView1Produto.Name = "dataGridView1Produto";
            this.dataGridView1Produto.Size = new System.Drawing.Size(529, 245);
            this.dataGridView1Produto.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(19, 585);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 29);
            this.panel1.TabIndex = 33;
            // 
            // Btn_novo_produto
            // 
            this.Btn_novo_produto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_novo_produto.FlatAppearance.BorderSize = 0;
            this.Btn_novo_produto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_novo_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_novo_produto.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_novo_produto.ForeColor = System.Drawing.Color.White;
            this.Btn_novo_produto.Location = new System.Drawing.Point(27, 585);
            this.Btn_novo_produto.Name = "Btn_novo_produto";
            this.Btn_novo_produto.Size = new System.Drawing.Size(171, 29);
            this.Btn_novo_produto.TabIndex = 32;
            this.Btn_novo_produto.Text = "Novo Protudo";
            this.Btn_novo_produto.UseVisualStyleBackColor = false;
            this.Btn_novo_produto.Click += new System.EventHandler(this.Btn_novo_produto_Click);
            // 
            // Txb_pesquisar_produto
            // 
            this.Txb_pesquisar_produto.Location = new System.Drawing.Point(634, 37);
            this.Txb_pesquisar_produto.Name = "Txb_pesquisar_produto";
            this.Txb_pesquisar_produto.Size = new System.Drawing.Size(529, 20);
            this.Txb_pesquisar_produto.TabIndex = 9999;
            this.Txb_pesquisar_produto.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(631, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Pesquisar Produto:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Chocolate;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(396, 585);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 29);
            this.panel3.TabIndex = 37;
            // 
            // Btn_alterar_produto
            // 
            this.Btn_alterar_produto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_alterar_produto.Enabled = false;
            this.Btn_alterar_produto.FlatAppearance.BorderSize = 0;
            this.Btn_alterar_produto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.Btn_alterar_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_alterar_produto.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_alterar_produto.ForeColor = System.Drawing.Color.White;
            this.Btn_alterar_produto.Location = new System.Drawing.Point(404, 585);
            this.Btn_alterar_produto.Name = "Btn_alterar_produto";
            this.Btn_alterar_produto.Size = new System.Drawing.Size(171, 29);
            this.Btn_alterar_produto.TabIndex = 36;
            this.Btn_alterar_produto.Text = "Alterar Dados";
            this.Btn_alterar_produto.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(585, 585);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 29);
            this.panel4.TabIndex = 39;
            // 
            // Btn_excuir_produto
            // 
            this.Btn_excuir_produto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_excuir_produto.Enabled = false;
            this.Btn_excuir_produto.FlatAppearance.BorderSize = 0;
            this.Btn_excuir_produto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn_excuir_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_excuir_produto.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_excuir_produto.ForeColor = System.Drawing.Color.White;
            this.Btn_excuir_produto.Location = new System.Drawing.Point(593, 585);
            this.Btn_excuir_produto.Name = "Btn_excuir_produto";
            this.Btn_excuir_produto.Size = new System.Drawing.Size(171, 29);
            this.Btn_excuir_produto.TabIndex = 38;
            this.Btn_excuir_produto.Text = "Excuir Dados";
            this.Btn_excuir_produto.UseVisualStyleBackColor = false;
            // 
            // Btncancelarproduto
            // 
            this.Btncancelarproduto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btncancelarproduto.FlatAppearance.BorderSize = 0;
            this.Btncancelarproduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btncancelarproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncancelarproduto.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncancelarproduto.ForeColor = System.Drawing.Color.White;
            this.Btncancelarproduto.Location = new System.Drawing.Point(774, 585);
            this.Btncancelarproduto.Name = "Btncancelarproduto";
            this.Btncancelarproduto.Size = new System.Drawing.Size(172, 29);
            this.Btncancelarproduto.TabIndex = 10000;
            this.Btncancelarproduto.Text = "Cancelar";
            this.Btncancelarproduto.UseVisualStyleBackColor = false;
            this.Btncancelarproduto.Click += new System.EventHandler(this.Btncancelarproduto_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(16, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 13);
            this.label7.TabIndex = 10015;
            this.label7.Text = "Escreva uma breve descrição do produto:";
            // 
            // Txb_descricao_produto
            // 
            this.Txb_descricao_produto.Enabled = false;
            this.Txb_descricao_produto.Location = new System.Drawing.Point(19, 367);
            this.Txb_descricao_produto.Multiline = true;
            this.Txb_descricao_produto.Name = "Txb_descricao_produto";
            this.Txb_descricao_produto.Size = new System.Drawing.Size(301, 156);
            this.Txb_descricao_produto.TabIndex = 10014;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(338, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 10019;
            this.label8.Text = "Qual o Preço para aluguel:";
            this.label8.Visible = false;
            // 
            // painel_aluguel_produto
            // 
            this.painel_aluguel_produto.BackColor = System.Drawing.SystemColors.Control;
            this.painel_aluguel_produto.Controls.Add(this.Mask_preco_aluguel_produto);
            this.painel_aluguel_produto.Controls.Add(this.pictureBox1);
            this.painel_aluguel_produto.Enabled = false;
            this.painel_aluguel_produto.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painel_aluguel_produto.Location = new System.Drawing.Point(341, 164);
            this.painel_aluguel_produto.Name = "painel_aluguel_produto";
            this.painel_aluguel_produto.Size = new System.Drawing.Size(198, 45);
            this.painel_aluguel_produto.TabIndex = 10018;
            this.painel_aluguel_produto.Visible = false;
            // 
            // Mask_preco_aluguel_produto
            // 
            this.Mask_preco_aluguel_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Mask_preco_aluguel_produto.BackColor = System.Drawing.SystemColors.Control;
            this.Mask_preco_aluguel_produto.Enabled = false;
            this.Mask_preco_aluguel_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mask_preco_aluguel_produto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Mask_preco_aluguel_produto.Location = new System.Drawing.Point(13, 10);
            this.Mask_preco_aluguel_produto.Mask = "$:000 ,000";
            this.Mask_preco_aluguel_produto.Name = "Mask_preco_aluguel_produto";
            this.Mask_preco_aluguel_produto.Size = new System.Drawing.Size(169, 26);
            this.Mask_preco_aluguel_produto.SkipLiterals = false;
            this.Mask_preco_aluguel_produto.TabIndex = 79;
            this.Mask_preco_aluguel_produto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
            // Painel_sexo_cliente
            // 
            this.Painel_sexo_cliente.BackColor = System.Drawing.SystemColors.Control;
            this.Painel_sexo_cliente.Controls.Add(this.RbSim_produto);
            this.Painel_sexo_cliente.Controls.Add(this.RbNao_produto);
            this.Painel_sexo_cliente.Enabled = false;
            this.Painel_sexo_cliente.Location = new System.Drawing.Point(341, 87);
            this.Painel_sexo_cliente.Name = "Painel_sexo_cliente";
            this.Painel_sexo_cliente.Size = new System.Drawing.Size(198, 45);
            this.Painel_sexo_cliente.TabIndex = 10021;
            // 
            // RbSim_produto
            // 
            this.RbSim_produto.AutoSize = true;
            this.RbSim_produto.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbSim_produto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.RbSim_produto.Location = new System.Drawing.Point(11, 11);
            this.RbSim_produto.Name = "RbSim_produto";
            this.RbSim_produto.Size = new System.Drawing.Size(47, 21);
            this.RbSim_produto.TabIndex = 27;
            this.RbSim_produto.TabStop = true;
            this.RbSim_produto.Text = "Sim";
            this.RbSim_produto.UseVisualStyleBackColor = true;
            this.RbSim_produto.CheckedChanged += new System.EventHandler(this.RbSim_produto_CheckedChanged);
            // 
            // RbNao_produto
            // 
            this.RbNao_produto.AutoSize = true;
            this.RbNao_produto.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbNao_produto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RbNao_produto.Location = new System.Drawing.Point(95, 10);
            this.RbNao_produto.Name = "RbNao_produto";
            this.RbNao_produto.Size = new System.Drawing.Size(51, 21);
            this.RbNao_produto.TabIndex = 28;
            this.RbNao_produto.TabStop = true;
            this.RbNao_produto.Text = "Não";
            this.RbNao_produto.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label9.Location = new System.Drawing.Point(338, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 13);
            this.label9.TabIndex = 10020;
            this.label9.Text = "Este produto de será alugado?";
            // 
            // TelaAddProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 650);
            this.Controls.Add(this.Painel_sexo_cliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.painel_aluguel_produto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txb_descricao_produto);
            this.Controls.Add(this.Btncancelarproduto);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Btn_excuir_produto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Btn_alterar_produto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txb_pesquisar_produto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_novo_produto);
            this.Controls.Add(this.dataGridView1Produto);
            this.Controls.Add(this.Cbx_categoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Painel_mask_preco_venda_produto);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Painel__mask_quant_produto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_salvar_produto);
            this.Controls.Add(this.panel_txb_nome_produto);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaAddProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaAddProduto";
            this.Load += new System.EventHandler(this.TelaAddProduto_Load);
            this.panel_txb_nome_produto.ResumeLayout(false);
            this.panel_txb_nome_produto.PerformLayout();
            this.Painel__mask_quant_produto.ResumeLayout(false);
            this.Painel__mask_quant_produto.PerformLayout();
            this.Painel_mask_preco_venda_produto.ResumeLayout(false);
            this.Painel_mask_preco_venda_produto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Produto)).EndInit();
            this.painel_aluguel_produto.ResumeLayout(false);
            this.painel_aluguel_produto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Painel_sexo_cliente.ResumeLayout(false);
            this.Painel_sexo_cliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_salvar_produto;
        private System.Windows.Forms.TextBox Txb_nome_produto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Mask_quant_prod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Cbx_categoria;
        private System.Windows.Forms.DataGridView dataGridView1Produto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_novo_produto;
        private System.Windows.Forms.TextBox Txb_pesquisar_produto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_alterar_produto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_excuir_produto;
        public System.Windows.Forms.MaskedTextBox Mask_preco_produto;
        private System.Windows.Forms.Button Btncancelarproduto;
        public System.Windows.Forms.Panel panel_txb_nome_produto;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel Painel__mask_quant_produto;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel Painel_mask_preco_venda_produto;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox Txb_descricao_produto;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Panel painel_aluguel_produto;
        public System.Windows.Forms.MaskedTextBox Mask_preco_aluguel_produto;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel Painel_sexo_cliente;
        private System.Windows.Forms.RadioButton RbSim_produto;
        private System.Windows.Forms.RadioButton RbNao_produto;
        public System.Windows.Forms.Label label9;
    }
}