using EntregaForms.Models;
using EntregaForms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregaForms
{
    public partial class frmLogin : Form
    {
        Usuario usuario = new Usuario();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LabelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxIlustrativa_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonNovoUsuario_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            // Esqueci que nao era para fazer validaçao de login.
            //if ((textBoxUsuario.Text == "Alibaba") && (textBoxSenha.Text == "1234"))
            //{
            //    new frmTelaUsuario().ShowDialog();
            //}else
            //if ((textBoxUsuario.Text == "Diego") && (textBoxSenha.Text == "1234")) {
                new frmTelaPrincipal().ShowDialog();
            //}else
            //{
            //    MessageBox.Show("Usuario ou senha incorreto.",
            //                    "Aviso", MessageBoxButtons.OK,
            //                     MessageBoxIcon.Information);
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelRelogio.Text = DateTime.Now.ToString("HH:mm:ss:fff");
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer fechar?", "Confirmação",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //para fechar o form principal
                this.Close();
                //para sair da aplicação
                Application.Exit();
            }
        }

        private void labelRelogio_Click(object sender, EventArgs e)
        {

        }
    }
}
