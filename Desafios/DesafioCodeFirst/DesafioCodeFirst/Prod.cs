using DesafioCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace DesafioCodeFirst
{
    public partial class frmProd : Form
    {
        public frmProd()
        {
            InitializeComponent();
            Read();
        }

        private void Add(object sender, EventArgs e)
        {
            using (Context c = new())
            {
                Fornecedor f = c.Fornecedores.FirstOrDefault(f => f.Id == int.Parse(tbForn.Text));

                c.Produtos.Add(new Produto()
                {
                    Nome = tbNome.Text,
                    Fornecedor = f,
                    Preco = decimal.Parse(tbPreco.Text),
                    Descricao = tbDesc.Text
                });

                c.SaveChanges();
            }

            Read();
        }

        private void Back(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Read()
        {
            using (Context c = new())
            {
                List<Produto> lstProds = (from Produto p in c.Produtos select p)
                     .Include(p => p.Fornecedor)
                     .ToList();

                dgvProd.DataSource = lstProds;
            }
        }
    }
}
