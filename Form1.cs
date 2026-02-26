namespace T_systems.ProjetoCurso.WindowsForms.UI
{
    public partial class FFormularioinicial : Form
    {
        public FFormularioinicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FFormularioinicial_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor();
            
            
            List <Fornecedor> listafornecedores = new List<Fornecedor>();
            listafornecedores.Add(retornarFornecedor(fornecedor));

            DGVFornecedores.DataSource = listafornecedores;
        }

        private Fornecedor retornarFornecedor(Fornecedor fornecedor)
        {
            #region ValidacaoFornecedor

            if (txtFornecedor.Text != string.Empty)
            {
                fornecedor.fornecedor = txtFornecedor.Text;
            }
            else
            {
                MessageBox.Show("Você ainda não digitou o fornecedor");
            }

            if (txtEndereco.Text != string.Empty)
            {
                fornecedor.Endereco = txtEndereco.Text;
            }
            else
            {
                MessageBox.Show("Você ainda não digitou o Endereco");
            }

            if (txtNomeDoContato.Text != string.Empty)
            {
                fornecedor.Nome_de_Contato = txtNomeDoContato.Text;
            }
            else
            {
                MessageBox.Show("Você ainda não digitou o Nome_de_Contato");
            }

            if (TXTTelefone.Text != string.Empty)
            {
                fornecedor.Telefone = TXTTelefone.Text;
            }
            else
            {
                MessageBox.Show("Você ainda não digitou o Telefone");
            }

            #endregion

            return fornecedor;
        }
    }
} 
