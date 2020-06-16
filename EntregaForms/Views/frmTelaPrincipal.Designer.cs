namespace EntregaForms.Views
{
    partial class frmTelaPrincipal
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
            this.buttonListarUsuarios = new System.Windows.Forms.Button();
            this.buttonListarAvioes = new System.Windows.Forms.Button();
            this.buttonGerenciarAvioes = new System.Windows.Forms.Button();
            this.buttonGerenciarCompanhia = new System.Windows.Forms.Button();
            this.buttonGerenciarRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonListarUsuarios
            // 
            this.buttonListarUsuarios.Location = new System.Drawing.Point(155, 69);
            this.buttonListarUsuarios.Name = "buttonListarUsuarios";
            this.buttonListarUsuarios.Size = new System.Drawing.Size(86, 70);
            this.buttonListarUsuarios.TabIndex = 0;
            this.buttonListarUsuarios.Text = "Listar Usuarios";
            this.buttonListarUsuarios.UseVisualStyleBackColor = true;
            this.buttonListarUsuarios.Click += new System.EventHandler(this.buttonListarUsuarios_Click);
            // 
            // buttonListarAvioes
            // 
            this.buttonListarAvioes.Location = new System.Drawing.Point(334, 69);
            this.buttonListarAvioes.Name = "buttonListarAvioes";
            this.buttonListarAvioes.Size = new System.Drawing.Size(84, 70);
            this.buttonListarAvioes.TabIndex = 1;
            this.buttonListarAvioes.Text = "Listar Avioes";
            this.buttonListarAvioes.UseVisualStyleBackColor = true;
            // 
            // buttonGerenciarAvioes
            // 
            this.buttonGerenciarAvioes.Location = new System.Drawing.Point(505, 69);
            this.buttonGerenciarAvioes.Name = "buttonGerenciarAvioes";
            this.buttonGerenciarAvioes.Size = new System.Drawing.Size(84, 70);
            this.buttonGerenciarAvioes.TabIndex = 2;
            this.buttonGerenciarAvioes.Text = "Gerenciar Avioes";
            this.buttonGerenciarAvioes.UseVisualStyleBackColor = true;
            // 
            // buttonGerenciarCompanhia
            // 
            this.buttonGerenciarCompanhia.Location = new System.Drawing.Point(155, 190);
            this.buttonGerenciarCompanhia.Name = "buttonGerenciarCompanhia";
            this.buttonGerenciarCompanhia.Size = new System.Drawing.Size(84, 70);
            this.buttonGerenciarCompanhia.TabIndex = 3;
            this.buttonGerenciarCompanhia.Text = "Gerenciar Companhia";
            this.buttonGerenciarCompanhia.UseVisualStyleBackColor = true;
            // 
            // buttonGerenciarRelatorios
            // 
            this.buttonGerenciarRelatorios.Location = new System.Drawing.Point(334, 190);
            this.buttonGerenciarRelatorios.Name = "buttonGerenciarRelatorios";
            this.buttonGerenciarRelatorios.Size = new System.Drawing.Size(84, 70);
            this.buttonGerenciarRelatorios.TabIndex = 4;
            this.buttonGerenciarRelatorios.Text = "Gerenciar Relatorios";
            this.buttonGerenciarRelatorios.UseVisualStyleBackColor = true;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 305);
            this.Controls.Add(this.buttonGerenciarRelatorios);
            this.Controls.Add(this.buttonGerenciarCompanhia);
            this.Controls.Add(this.buttonGerenciarAvioes);
            this.Controls.Add(this.buttonListarAvioes);
            this.Controls.Add(this.buttonListarUsuarios);
            this.Name = "frmTelaPrincipal";
            this.Text = "frmTelaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonListarUsuarios;
        private System.Windows.Forms.Button buttonListarAvioes;
        private System.Windows.Forms.Button buttonGerenciarAvioes;
        private System.Windows.Forms.Button buttonGerenciarCompanhia;
        private System.Windows.Forms.Button buttonGerenciarRelatorios;
    }
}