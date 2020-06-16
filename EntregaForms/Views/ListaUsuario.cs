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
    public partial class ListaUsuario : Form
    {
        UsuarioRepository repository = new UsuarioRepository();
        public ListaUsuario()
        {
            InitializeComponent();
        }

        private void dataGridViewListaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaUsuario_Load(object sender, EventArgs e)
        {
            carregaLista();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
            //Chama o método para carregar na lista
            carregaLista();
        }

        private void dataGridViewListaUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //captura a linha que foi selecionada
            DataGridViewRow linha = dataGridViewListaUsuario.Rows[e.RowIndex];
            //guarda nas variáveis os conteúdos das células
            string nome = linha.Cells[1].Value.ToString();
            string sobrenome = linha.Cells[2].Value.ToString();
            DateTime nascimento = Convert.ToDateTime(linha.Cells[3].Value.ToString());
            string user = linha.Cells[4].Value.ToString();
            string endereco = linha.Cells[5].Value.ToString();
            int numero = Convert.ToInt32(linha.Cells[6].Value.ToString());
            string senha = linha.Cells[7].Value.ToString();
            string confirmarsenha = linha.Cells[8].Value.ToString();
            
            //esse campo precisa ser convertido pois é numérico
            int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());
            //Joga nas propriedades do objeto usuario
            Usuario usuario = new Usuario
            {
                Codigo = codigo,
                Nome = nome,
                SobreNome = sobrenome,
                Endereco = endereco,
                Numero = numero,
                Nascimento = nascimento,
                User = user,
                Senha = senha,
                ConfirmarSenha = confirmarsenha
                
                

            };
            //Chama o formulário de cadastro passando a classe usuario

            new frmCadastro(usuario).ShowDialog();
            //chama o método para carregar o datagrid
            carregaLista();
        }


        private void carregaLista()
        {
            UsuarioRepository repository = new UsuarioRepository();
            dataGridViewListaUsuario.DataSource = null;
            dataGridViewListaUsuario.DataSource = repository.buscarTodos();
            alterarContador();
        }

        private void alterarContador()
        {
            //2 itens de 10
            lblContador.Text = $"{dataGridViewListaUsuario.RowCount} itens de {repository.buscarTodos().Count}";
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
            dataGridViewListaUsuario.DataSource = null;

            // filtra as lista recebida do repositório, verificando se o nome, 
            // email, usuario, contém o que está no campo filtro.
            dataGridViewListaUsuario.DataSource = repository.buscarTodos().FindAll(x =>
                x.Nome.ToUpper().Contains(textBoxFiltro.Text.ToUpper()) ||
                x.SobreNome.ToUpper().Contains(textBoxFiltro.Text.ToUpper()) ||
                x.Endereco.ToUpper().Contains(textBoxFiltro.Text.ToUpper())
            );

            alterarContador();
        }
        private void dgvListaAluno_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dr = MessageBox.Show("Deseja excluir este usuário?", "Atenção"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow linha = dataGridViewListaUsuario.Rows[e.RowIndex];

                    int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());

                    repository.deletar(codigo);

                    carregaLista();
                }
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            new frmTelaPrincipal().ShowDialog();
            Dispose();
        }
    }
}
