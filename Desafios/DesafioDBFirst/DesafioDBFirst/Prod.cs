using DesafioDBFirst.DataModels;

namespace DesafioDBFirst
{
    public partial class Prod : Form
    {
        public Prod()
        {
            InitializeComponent();

            using (DboMiniErpContext c = new())
            {
                dgvProd.DataSource = c.Produtos.ToList();
            }
        }

        private void Add(object sender, EventArgs e)
        {
            using (DboMiniErpContext context = new())
            {
                int fkFornTmp = int.Parse(tbForn.Text);
                Fornecedores forn = context.Fornecedores.Find(fkFornTmp);

                Produto prod = new()
                {
                    Nome = tbNome.Text,
                    FkForn = fkFornTmp,
                    Preco = decimal.Parse(tbPreco.Text),
                    Descricao = tbDesc.Text
                };

                context.Produtos.Add(prod);

                forn.Produtos.Add(new Produto()
                {
                    Nome = prod.Nome,
                    FkForn = prod.FkForn,
                    Preco = prod.Preco,
                    Descricao = prod.Descricao
                });

                context.SaveChanges();
            }
        }

        private void Back(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
