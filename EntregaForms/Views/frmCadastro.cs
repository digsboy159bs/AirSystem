using EntregaForms.Models;
using EntregaForms.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntregaForms.Views
{
    public partial class frmCadastro : Form
    {
        private Usuario usuario = null;
        public frmCadastro()
        {
            InitializeComponent();
        }

        public frmCadastro(Usuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
        }



        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //O filtro - somente apresentar os arquivos de imagem
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            //Chamar a janela - entrar somente se confirma a seleção do arquivo
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Carregar a imagem selecionada no picturebox
                pictureBoxFoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBoxSenha.Text != textBoxConSenha.Text)
            {
                MessageBox.Show("Senha nao bate com sua confirmacao.",
                               "Aviso", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }else
            if (!Utils.temCamposVazio(this))
            //8. Armazena os dados do novo usuário nas propriedades da classe e carrega na lista (para alimentar o datagrid)
            //instanciar a classe UsuarioRepository onde estão criados os métodos de acesso aos dados

            {
                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {
                    //Atribui nas propriedades da classe usuários os valores dos campos do formulário
                    Usuario usuario = new Usuario
                    {
                        Nome = textBoxNome.Text,
                        SobreNome = textBoxSobrenome.Text,
                        Senha = "1234",
                        Nascimento = dateTimePicker1.Value,
                        User = textBoxUsuario.Text,
                        Endereco = textBoxEndereco.Text,
                        ConfirmarSenha = textBoxConSenha.Text,
                        Numero = Convert.ToInt32(textBoxNumero.Text)

                        
                    };
                    //chama o método adicionar - passando a classe usuario
                    repository.adicionar(usuario);

                    //Todos os campos foram preenchidos - Salva os campos no BD
                    MessageBox.Show("Dados Salvos.",
                                    "Aviso", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);

                }
                else 
                {
                    //alimenta as propriedades da classe com o conteúdo dos campos do formulário

                    this.usuario.Nome = textBoxNome.Text;
                    this.usuario.SobreNome = textBoxSobrenome.Text;
                    this.usuario.Senha = "1234";
                    this.usuario.Nascimento = dateTimePicker1.Value;
                    this.usuario.User = textBoxUsuario.Text;
                    this.usuario.Endereco = textBoxEndereco.Text;
                    this.usuario.ConfirmarSenha = textBoxConSenha.Text;
                    this.usuario.Numero = Convert.ToInt32(textBoxNumero.Text);



                    //Chama o método para editar 
                    //Atalho para criar o método -> Alt Enter para criar o método editar

                    repository.editar(usuario);
                }
                this.Close();

            }
            else
            {   //Texto , Título, Botões, Ícone
                MessageBox.Show("Todos os campos são obrigatórios.",
                                "Aviso", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            
        }

        

        private void textBoxNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                textBoxNome.Text = usuario.Nome;
                textBoxSobrenome.Text = usuario.SobreNome;
                textBoxEndereco.Text = usuario.Endereco;
                textBoxUsuario.Text = usuario.User;
            }
        }
    }
}
