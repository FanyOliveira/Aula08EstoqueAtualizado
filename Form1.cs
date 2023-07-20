namespace Aula08Estoque
{
    public partial class Form1 : Form
    {
        //VÁRIAVEIS GLOBAIS

        List<string> produto_nome = new List<string>();
        List<int> produto_quantidade = new List<int>();

        Utilidades utilidades = new Utilidades();



        public Form1()
        {
            InitializeComponent();
        }

        // MINHAS FUNÇÕES 
        void adicionaProduto ( )
        {
            if (utilidades.textBoxEstaVazio(txtNome) == true)
            {
                MessageBox.Show("O nome está vazio");
                return;
            } 
           
            utilidades.textBoxEstaVazio( txtNome );
            string nome = txtNome.Text;
            int quantidade = int.Parse ( txtQuantidade.Text );    
            produto_nome.Add( nome );
            produto_quantidade.Add( quantidade );
        }

        void atualizaInterface()
        {
            // CONTABILIZA A QUANTIDADE CADASTRADA

            int quantidadeCadastrada = produto_nome.Count();
            lblCadastros.Text = quantidadeCadastrada.ToString();

            //CONTABILIZA TODOS OS PRODUTOS EM ESTOQUE
            //FOR: A VÁRIAVEL CONTROLADORA ; CONDIÇÃO ; INCREMENTAR O CONTROLADOR
            int estoque = 0;
            for ( int i = 0; i < produto_quantidade.Count; i++ )
            {
                int quantidade = produto_quantidade[i];
                estoque += quantidade;
            }
            lblQuantidade.Text = estoque.ToString();
        }

        void limpaCampos ()
        {
            txtNome.Clear();
            txtQuantidade.Clear();
            txtNome.Focus();
        }
      
        void mostraPrododuto( bool primeiro )          // BOOL true - false      // VAR - PODE SER SUBSTITUÍDA POR VÁRIAVEIS
        {

            if ( listaEstaVazia() == true)
            {
                MessageBox.Show("Você não pode ver a Lista ainda...");
                return;
            }
            

            string nome;
            int quantidade;

            if (primeiro == true)
            {
                nome = produto_nome[0];
                quantidade = produto_quantidade[0];
            }
            else
            {
                nome = produto_nome [ produto_nome.Count() - 1 ];
                quantidade = produto_quantidade [ produto_quantidade.Count() - 1 ];
            }

            MessageBox.Show($"Nome:{nome} , Quantidade: {quantidade} ");
        }

        void removerProduto ()
        {
            if ( listaEstaVazia () == true)
            {
                MessageBox.Show("Você não pode remover!");
            }
            else
            {
                produto_nome.RemoveAt(0);
                produto_quantidade.RemoveAt(0);
            }

        }

        bool listaEstaVazia()
        {
            if ( produto_nome.Count > 0 )
            {
                return false;
            }
            else
            {
                return true;         
            }

        }

        // ------------------------------------------------------------------------------------------

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            adicionaProduto();
            atualizaInterface();
            limpaCampos();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            mostraPrododuto( true );
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            mostraPrododuto(false);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            
            removerProduto();
            atualizaInterface();
            MessageBox.Show("Item removido com sucesso!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utilidades utilidades= new Utilidades();
            utilidades.mostraMensagem();
        }
    }
}