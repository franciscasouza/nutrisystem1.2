namespace nutrisystem1._2
{
    partial class frm_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.ttb_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ttb_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.FlatAppearance.BorderSize = 0;
            this.btn_Entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.btn_Entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.ForeColor = System.Drawing.Color.Coral;
            this.btn_Entrar.Location = new System.Drawing.Point(84, 400);
            this.btn_Entrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(191, 38);
            this.btn_Entrar.TabIndex = 25;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // ttb_Senha
            // 
            this.ttb_Senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttb_Senha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_Senha.Location = new System.Drawing.Point(86, 368);
            this.ttb_Senha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ttb_Senha.Name = "ttb_Senha";
            this.ttb_Senha.Size = new System.Drawing.Size(191, 22);
            this.ttb_Senha.TabIndex = 24;
            this.ttb_Senha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(135, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Usuario :";
            // 
            // ttb_Usuario
            // 
            this.ttb_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttb_Usuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_Usuario.Location = new System.Drawing.Point(87, 312);
            this.ttb_Usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ttb_Usuario.Name = "ttb_Usuario";
            this.ttb_Usuario.Size = new System.Drawing.Size(188, 22);
            this.ttb_Usuario.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(135, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 27;
            this.label2.Text = "Senha :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::nutrisystem1._2.Properties.Resources.Cópia_de_Cartão_de_Visita_removebg_preview;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(30, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 228);
            this.panel1.TabIndex = 26;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(362, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.ttb_Senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ttb_Usuario);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.TextBox ttb_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ttb_Usuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

