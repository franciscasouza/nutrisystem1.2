namespace nutrisystem1._2
{
    partial class frm_novopaciente
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_responsavelnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rdb_fem = new System.Windows.Forms.RadioButton();
            this.rdb_masc = new System.Windows.Forms.RadioButton();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.pn_menoridade = new System.Windows.Forms.Panel();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.txt_tipodocumento = new System.Windows.Forms.TextBox();
            this.dtp_datanascimento = new System.Windows.Forms.DateTimePicker();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.txt_numerodocumento = new System.Windows.Forms.TextBox();
            this.lbl_numdocumento = new System.Windows.Forms.Label();
            this.lbl_tipodocumento = new System.Windows.Forms.Label();
            this.lbl_datanasc = new System.Windows.Forms.Label();
            this.txt_nomecompleto = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.txt_tipoEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.lbl_uf = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.txt_num_endereco = new System.Windows.Forms.TextBox();
            this.lbl_numcasa = new System.Windows.Forms.Label();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.lbl_rua = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pn_menoridade.SuspendLayout();
            this.grbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cadastro de Paciente";
            // 
            // txt_responsavelnome
            // 
            this.txt_responsavelnome.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_responsavelnome.Location = new System.Drawing.Point(5, 30);
            this.txt_responsavelnome.Name = "txt_responsavelnome";
            this.txt_responsavelnome.Size = new System.Drawing.Size(425, 28);
            this.txt_responsavelnome.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nome Completo do Responsavel :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(190)))), ((int)(((byte)(175)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 68);
            this.panel1.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 85;
            // 
            // rdb_fem
            // 
            this.rdb_fem.AutoSize = true;
            this.rdb_fem.Font = new System.Drawing.Font("Arial", 12.25F);
            this.rdb_fem.Location = new System.Drawing.Point(690, 56);
            this.rdb_fem.Name = "rdb_fem";
            this.rdb_fem.Size = new System.Drawing.Size(64, 23);
            this.rdb_fem.TabIndex = 4;
            this.rdb_fem.TabStop = true;
            this.rdb_fem.Text = "Fem.";
            this.rdb_fem.UseVisualStyleBackColor = true;
            this.rdb_fem.Enter += new System.EventHandler(this.rdb_fem_Enter);
            // 
            // rdb_masc
            // 
            this.rdb_masc.AutoSize = true;
            this.rdb_masc.Font = new System.Drawing.Font("Arial", 12.25F);
            this.rdb_masc.Location = new System.Drawing.Point(618, 56);
            this.rdb_masc.Name = "rdb_masc";
            this.rdb_masc.Size = new System.Drawing.Size(71, 23);
            this.rdb_masc.TabIndex = 3;
            this.rdb_masc.TabStop = true;
            this.rdb_masc.Text = "Masc.";
            this.rdb_masc.UseVisualStyleBackColor = true;
            this.rdb_masc.Enter += new System.EventHandler(this.rdb_masc_Enter);
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.Location = new System.Drawing.Point(614, 32);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(68, 21);
            this.lbl_genero.TabIndex = 82;
            this.lbl_genero.Text = "Genero :";
            // 
            // pn_menoridade
            // 
            this.pn_menoridade.Controls.Add(this.txt_responsavelnome);
            this.pn_menoridade.Controls.Add(this.label1);
            this.pn_menoridade.Location = new System.Drawing.Point(16, 146);
            this.pn_menoridade.Name = "pn_menoridade";
            this.pn_menoridade.Size = new System.Drawing.Size(449, 70);
            this.pn_menoridade.TabIndex = 81;
            this.pn_menoridade.Visible = false;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(49, 533);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(104, 32);
            this.btn_limpar.TabIndex = 80;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click_1);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(703, 533);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(134, 32);
            this.btn_cadastrar.TabIndex = 78;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(416, 326);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(387, 29);
            this.txt_email.TabIndex = 11;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(412, 302);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(55, 21);
            this.lbl_email.TabIndex = 64;
            this.lbl_email.Text = "Email :";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(234, 326);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(144, 29);
            this.txt_telefone.TabIndex = 10;
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefone.Location = new System.Drawing.Point(230, 302);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(76, 21);
            this.lbl_telefone.TabIndex = 62;
            this.lbl_telefone.Text = "Telefone :";
            // 
            // txt_tipodocumento
            // 
            this.txt_tipodocumento.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipodocumento.Location = new System.Drawing.Point(16, 111);
            this.txt_tipodocumento.Name = "txt_tipodocumento";
            this.txt_tipodocumento.Size = new System.Drawing.Size(188, 29);
            this.txt_tipodocumento.TabIndex = 5;
            // 
            // dtp_datanascimento
            // 
            this.dtp_datanascimento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_datanascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_datanascimento.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.dtp_datanascimento.Location = new System.Drawing.Point(443, 56);
            this.dtp_datanascimento.Name = "dtp_datanascimento";
            this.dtp_datanascimento.Size = new System.Drawing.Size(121, 25);
            this.dtp_datanascimento.TabIndex = 2;
            this.dtp_datanascimento.ValueChanged += new System.EventHandler(this.dtp_datanascimento_ValueChanged);
            // 
            // txt_celular
            // 
            this.txt_celular.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celular.Location = new System.Drawing.Point(53, 326);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(144, 29);
            this.txt_celular.TabIndex = 9;
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_celular.Location = new System.Drawing.Point(49, 302);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(66, 21);
            this.lbl_celular.TabIndex = 58;
            this.lbl_celular.Text = "Celular :";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cpf.Location = new System.Drawing.Point(535, 111);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(232, 28);
            this.txt_cpf.TabIndex = 7;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpf.Location = new System.Drawing.Point(531, 87);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(44, 21);
            this.lbl_cpf.TabIndex = 56;
            this.lbl_cpf.Text = "CPF :";
            // 
            // txt_numerodocumento
            // 
            this.txt_numerodocumento.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numerodocumento.Location = new System.Drawing.Point(233, 111);
            this.txt_numerodocumento.Name = "txt_numerodocumento";
            this.txt_numerodocumento.Size = new System.Drawing.Size(269, 28);
            this.txt_numerodocumento.TabIndex = 6;
            // 
            // lbl_numdocumento
            // 
            this.lbl_numdocumento.AutoSize = true;
            this.lbl_numdocumento.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numdocumento.Location = new System.Drawing.Point(229, 87);
            this.lbl_numdocumento.Name = "lbl_numdocumento";
            this.lbl_numdocumento.Size = new System.Drawing.Size(182, 21);
            this.lbl_numdocumento.TabIndex = 54;
            this.lbl_numdocumento.Text = "Numero do Documento :";
            // 
            // lbl_tipodocumento
            // 
            this.lbl_tipodocumento.AutoSize = true;
            this.lbl_tipodocumento.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipodocumento.Location = new System.Drawing.Point(13, 87);
            this.lbl_tipodocumento.Name = "lbl_tipodocumento";
            this.lbl_tipodocumento.Size = new System.Drawing.Size(153, 21);
            this.lbl_tipodocumento.TabIndex = 53;
            this.lbl_tipodocumento.Text = "Tipo de Documento :";
            // 
            // lbl_datanasc
            // 
            this.lbl_datanasc.AutoSize = true;
            this.lbl_datanasc.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datanasc.Location = new System.Drawing.Point(439, 32);
            this.lbl_datanasc.Name = "lbl_datanasc";
            this.lbl_datanasc.Size = new System.Drawing.Size(157, 21);
            this.lbl_datanasc.TabIndex = 52;
            this.lbl_datanasc.Text = "Data de Nascimento :";
            // 
            // txt_nomecompleto
            // 
            this.txt_nomecompleto.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomecompleto.Location = new System.Drawing.Point(17, 55);
            this.txt_nomecompleto.Name = "txt_nomecompleto";
            this.txt_nomecompleto.Size = new System.Drawing.Size(394, 28);
            this.txt_nomecompleto.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(13, 31);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(132, 21);
            this.lbl_nome.TabIndex = 50;
            this.lbl_nome.Text = "Nome Completo :";
            // 
            // grbDados
            // 
            this.grbDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDados.Controls.Add(this.lbl_nome);
            this.grbDados.Controls.Add(this.txt_nomecompleto);
            this.grbDados.Controls.Add(this.lbl_datanasc);
            this.grbDados.Controls.Add(this.lbl_tipodocumento);
            this.grbDados.Controls.Add(this.label3);
            this.grbDados.Controls.Add(this.lbl_numdocumento);
            this.grbDados.Controls.Add(this.rdb_fem);
            this.grbDados.Controls.Add(this.txt_numerodocumento);
            this.grbDados.Controls.Add(this.rdb_masc);
            this.grbDados.Controls.Add(this.lbl_cpf);
            this.grbDados.Controls.Add(this.lbl_genero);
            this.grbDados.Controls.Add(this.txt_cpf);
            this.grbDados.Controls.Add(this.pn_menoridade);
            this.grbDados.Controls.Add(this.dtp_datanascimento);
            this.grbDados.Controls.Add(this.txt_tipodocumento);
            this.grbDados.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDados.Location = new System.Drawing.Point(49, 74);
            this.grbDados.MaximumSize = new System.Drawing.Size(0, 295);
            this.grbDados.MinimumSize = new System.Drawing.Size(806, 145);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(806, 220);
            this.grbDados.TabIndex = 89;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados Pessoais";
            // 
            // txt_tipoEnd
            // 
            this.txt_tipoEnd.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipoEnd.Location = new System.Drawing.Point(54, 402);
            this.txt_tipoEnd.Name = "txt_tipoEnd";
            this.txt_tipoEnd.Size = new System.Drawing.Size(140, 29);
            this.txt_tipoEnd.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 21);
            this.label6.TabIndex = 109;
            this.label6.Text = "Tipo";
            // 
            // txt_complemento
            // 
            this.txt_complemento.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_complemento.Location = new System.Drawing.Point(53, 459);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(170, 29);
            this.txt_complemento.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 107;
            this.label5.Text = "Complemento :";
            // 
            // txt_uf
            // 
            this.txt_uf.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uf.Location = new System.Drawing.Point(706, 458);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(123, 29);
            this.txt_uf.TabIndex = 106;
            // 
            // lbl_uf
            // 
            this.lbl_uf.AutoSize = true;
            this.lbl_uf.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uf.Location = new System.Drawing.Point(713, 434);
            this.lbl_uf.Name = "lbl_uf";
            this.lbl_uf.Size = new System.Drawing.Size(36, 21);
            this.lbl_uf.TabIndex = 105;
            this.lbl_uf.Text = "UF :";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.Location = new System.Drawing.Point(419, 458);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_cidade.Size = new System.Drawing.Size(280, 29);
            this.txt_cidade.TabIndex = 104;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidade.Location = new System.Drawing.Point(418, 434);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_cidade.Size = new System.Drawing.Size(65, 21);
            this.lbl_cidade.TabIndex = 103;
            this.lbl_cidade.Text = "Cidade :";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bairro.Location = new System.Drawing.Point(231, 459);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(181, 29);
            this.txt_bairro.TabIndex = 102;
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairro.Location = new System.Drawing.Point(228, 435);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(59, 21);
            this.lbl_bairro.TabIndex = 101;
            this.lbl_bairro.Text = "Bairro :";
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cep.Location = new System.Drawing.Point(646, 375);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(44, 21);
            this.lbl_cep.TabIndex = 100;
            this.lbl_cep.Text = "CEP :";
            // 
            // txt_cep
            // 
            this.txt_cep.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cep.Location = new System.Drawing.Point(650, 403);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(179, 29);
            this.txt_cep.TabIndex = 99;
            // 
            // txt_num_endereco
            // 
            this.txt_num_endereco.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_endereco.Location = new System.Drawing.Point(555, 403);
            this.txt_num_endereco.Name = "txt_num_endereco";
            this.txt_num_endereco.Size = new System.Drawing.Size(88, 29);
            this.txt_num_endereco.TabIndex = 98;
            // 
            // lbl_numcasa
            // 
            this.lbl_numcasa.AutoSize = true;
            this.lbl_numcasa.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numcasa.Location = new System.Drawing.Point(562, 375);
            this.lbl_numcasa.Name = "lbl_numcasa";
            this.lbl_numcasa.Size = new System.Drawing.Size(35, 21);
            this.lbl_numcasa.TabIndex = 97;
            this.lbl_numcasa.Text = "N° :";
            // 
            // txt_rua
            // 
            this.txt_rua.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rua.Location = new System.Drawing.Point(200, 402);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(349, 29);
            this.txt_rua.TabIndex = 96;
            // 
            // lbl_rua
            // 
            this.lbl_rua.AutoSize = true;
            this.lbl_rua.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rua.Location = new System.Drawing.Point(197, 374);
            this.lbl_rua.Name = "lbl_rua";
            this.lbl_rua.Size = new System.Drawing.Size(114, 21);
            this.lbl_rua.TabIndex = 95;
            this.lbl_rua.Text = "Rua / Avenina :";
            // 
            // frm_novopaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1175, 821);
            this.Controls.Add(this.txt_tipoEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_complemento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.lbl_uf);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.lbl_bairro);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.txt_num_endereco);
            this.Controls.Add(this.lbl_numcasa);
            this.Controls.Add(this.txt_rua);
            this.Controls.Add(this.lbl_rua);
            this.Controls.Add(this.txt_celular);
            this.Controls.Add(this.lbl_celular);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.grbDados);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_cadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_novopaciente";
            this.Text = "frm_novopaciente";
            this.Load += new System.EventHandler(this.frm_novopaciente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_menoridade.ResumeLayout(false);
            this.pn_menoridade.PerformLayout();
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_responsavelnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdb_fem;
        private System.Windows.Forms.RadioButton rdb_masc;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.Panel pn_menoridade;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.TextBox txt_tipodocumento;
        private System.Windows.Forms.DateTimePicker dtp_datanascimento;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.TextBox txt_numerodocumento;
        private System.Windows.Forms.Label lbl_numdocumento;
        private System.Windows.Forms.Label lbl_tipodocumento;
        private System.Windows.Forms.Label lbl_datanasc;
        private System.Windows.Forms.TextBox txt_nomecompleto;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.TextBox txt_tipoEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_uf;
        private System.Windows.Forms.Label lbl_uf;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.Label lbl_cep;
        private System.Windows.Forms.TextBox txt_cep;
        private System.Windows.Forms.TextBox txt_num_endereco;
        private System.Windows.Forms.Label lbl_numcasa;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.Label lbl_rua;
    }
}