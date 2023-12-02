using DesafioDBFirst.DataModels;
using System.Windows.Forms;

namespace DesafioDBFirst
{
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();

            using (DboMiniErpContext c  = new())
            {
                dgvNote.DataSource = c.Nota.ToList();
            }
        }

        private void Add(object sender, EventArgs e)
        {
            using (DboMiniErpContext c = new())
            {
                int fkClientTmp = int.Parse(tbClient.Text);
                Cliente client = c.Clients.Find(fkClientTmp);
                
                int fkProdTmp = int.Parse(tbProd.Text);
                Produto prod = c.Produtos.Find(fkProdTmp);

                Nota note = new()
                {
                    FkCliente = fkClientTmp,
                    FkProd = fkProdTmp,
                    MetPagamento = tbMetPagamento.Text,
                    DatCompra = DateTime.Parse(tbDatCompra.Text)
                };

                c.Nota.Add(note);
                c.SaveChanges();

                dgvNote.DataSource = c.Nota.ToList();
            }
        }

        private void Back(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
