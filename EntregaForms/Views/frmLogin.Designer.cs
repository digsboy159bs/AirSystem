namespace EntregaForms
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonNovoUsuario = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelRelogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxIlustrativa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIlustrativa)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Location = new System.Drawing.Point(492, 174);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(43, 13);
            this.LabelUsuario.TabIndex = 0;
            this.LabelUsuario.Text = "Usuario";
            this.LabelUsuario.Click += new System.EventHandler(this.LabelUsuario_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(541, 171);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(165, 20);
            this.textBoxUsuario.TabIndex = 1;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(492, 224);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(541, 221);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(165, 20);
            this.textBoxSenha.TabIndex = 3;
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Location = new System.Drawing.Point(492, 276);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(38, 13);
            this.labelIdioma.TabIndex = 4;
            this.labelIdioma.Text = "Idioma";
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(441, 315);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(66, 23);
            this.buttonEntrar.TabIndex = 8;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(530, 315);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(67, 23);
            this.buttonSair.TabIndex = 9;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonNovoUsuario
            // 
            this.buttonNovoUsuario.Location = new System.Drawing.Point(607, 315);
            this.buttonNovoUsuario.Name = "buttonNovoUsuario";
            this.buttonNovoUsuario.Size = new System.Drawing.Size(99, 23);
            this.buttonNovoUsuario.TabIndex = 10;
            this.buttonNovoUsuario.Text = "Novo Usuario";
            this.buttonNovoUsuario.UseVisualStyleBackColor = true;
            this.buttonNovoUsuario.Click += new System.EventHandler(this.buttonNovoUsuario_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Portugues",
            "Ingles"});
            this.comboBox1.Location = new System.Drawing.Point(541, 273);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // labelRelogio
            // 
            this.labelRelogio.AutoSize = true;
            this.labelRelogio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRelogio.Location = new System.Drawing.Point(604, 9);
            this.labelRelogio.Name = "labelRelogio";
            this.labelRelogio.Size = new System.Drawing.Size(36, 15);
            this.labelRelogio.TabIndex = 12;
            this.labelRelogio.Text = "13:18";
            this.labelRelogio.Click += new System.EventHandler(this.labelRelogio_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo.Image = global::EntregaForms.Properties.Resources.images;
            this.pictureBoxLogo.Location = new System.Drawing.Point(530, 53);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(172, 88);
            this.pictureBoxLogo.TabIndex = 7;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxIlustrativa
            // 
            this.pictureBoxIlustrativa.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxIlustrativa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIlustrativa.Image = global::EntregaForms.Properties.Resources._260px_São_Paulo_at_night;
            this.pictureBoxIlustrativa.Location = new System.Drawing.Point(70, 74);
            this.pictureBoxIlustrativa.Name = "pictureBoxIlustrativa";
            this.pictureBoxIlustrativa.Size = new System.Drawing.Size(260, 167);
            this.pictureBoxIlustrativa.TabIndex = 6;
            this.pictureBoxIlustrativa.TabStop = false;
            this.pictureBoxIlustrativa.Click += new System.EventHandler(this.pictureBoxIlustrativa_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(740, 350);
            this.Controls.Add(this.labelRelogio);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonNovoUsuario);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxIlustrativa);
            this.Controls.Add(this.labelIdioma);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.LabelUsuario);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmLogin";
            this.Text = "Entrega Forms";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIlustrativa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.PictureBox pictureBoxIlustrativa;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonNovoUsuario;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelRelogio;
        private System.Windows.Forms.Timer timer1;
    }
}

