using DesafioCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;

namespace DesafioCodeFirst
{
    public partial class frmForn : Form
    {
        public frmForn()
        {
            InitializeComponent();
            Read();
        }

        private void Add(object sender, EventArgs e)
        {
            using (Context c = new())
            {
                Fornecedor forn = new Fornecedor()
                {
                    Nome = tbNome.Text,
                };

                c.Fornecedores.Add(forn);
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
                List<Fornecedor> lstForns = (from Fornecedor f in c.Fornecedores select f)
                    .Include(f => f.Produtos)
                    .ToList();
                dgvForn.DataSource = lstForns;
            }
        }
    }
}
