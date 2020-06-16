namespace EntregaForms.Views
{
    partial class frmTelaUsuario
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
            this.buttonListarAvioesComum = new System.Windows.Forms.Button();
            this.buttonGerenciarRelatoriosComum = new System.Windows.Forms.Button();
            this.buttonGerenciarCompanhiaComum = new System.Windows.Forms.Button();
            this.buttonGerenciarAviaoComum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonListarAvioesComum
            // 
            this.buttonListarAvioesComum.Location = new System.Drawing.Point(188, 67);
            this.buttonListarAvioesComum.Name = "buttonListarAvioesComum";
            this.buttonListarAvioesComum.Size = new System.Drawing.Size(90, 70);
            this.buttonListarAvioesComum.TabIndex = 0;
            this.buttonListarAvioesComum.Text = "Listar Avioes";
            this.buttonListarAvioesComum.UseVisualStyleBackColor = true;
            // 
            // buttonGerenciarRelatoriosComum
            // 
            this.buttonGerenciarRelatoriosComum.Location = new System.Drawing.Point(355, 191);
            this.buttonGerenciarRelatoriosComum.Name = "buttonGerenciarRelatoriosComum";
            this.buttonGerenciarRelatoriosComum.Size = new System.Drawing.Size(90, 70);
            this.buttonGerenciarRelatoriosComum.TabIndex = 1;
            this.buttonGerenciarRelatoriosComum.Text = "Gerenciar Relatorios";
            this.buttonGerenciarRelatoriosComum.UseVisualStyleBackColor = true;
            // 
            // buttonGerenciarCompanhiaComum
            // 
            this.buttonGerenciarCompanhiaComum.Location = new System.Drawing.Point(524, 67);
            this.buttonGerenciarCompanhiaComum.Name = "buttonGerenciarCompanhiaComum";
            this.buttonGerenciarCompanhiaComum.Size = new System.Drawing.Size(90, 70);
            this.buttonGerenciarCompanhiaComum.TabIndex = 2;
            this.buttonGerenciarCompanhiaComum.Text = "Gerenciar Companhia";
            this.buttonGerenciarCompanhiaComum.UseVisualStyleBackColor = true;
            // 
            // buttonGerenciarAviaoComum
            // 
            this.buttonGerenciarAviaoComum.Location = new System.Drawing.Point(355, 67);
            this.buttonGerenciarAviaoComum.Name = "buttonGerenciarAviaoComum";
            this.buttonGerenciarAviaoComum.Size = new System.Drawing.Size(90, 70);
            this.buttonGerenciarAviaoComum.TabIndex = 3;
            this.buttonGerenciarAviaoComum.Text = "Gerenciar Aviao";
            this.buttonGerenciarAviaoComum.UseVisualStyleBackColor = true;
            // 
            // frmTelaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGerenciarAviaoComum);
            this.Controls.Add(this.buttonGerenciarCompanhiaComum);
            this.Controls.Add(this.buttonGerenciarRelatoriosComum);
            this.Controls.Add(this.buttonListarAvioesComum);
            this.Name = "frmTelaUsuario";
            this.Text = "frmTelaUsuario";
            this.Load += new System.EventHandler(this.frmTelaUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonListarAvioesComum;
        private System.Windows.Forms.Button buttonGerenciarRelatoriosComum;
        private System.Windows.Forms.Button buttonGerenciarCompanhiaComum;
        private System.Windows.Forms.Button buttonGerenciarAviaoComum;
    }
}