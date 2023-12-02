using DesafioDBFirst.DataModels;

namespace DesafioDBFirst
{
    public partial class Forn : Form
    {
        public Forn()
        {
            InitializeComponent();

            using (DboMiniErpContext c = new())
            {
                dgvForn.DataSource = c.Fornecedores.ToList();
            }
        }

        private void Back(object sender, EventArgs e)
        {
            Close();
        }

        private void Add(object sender, EventArgs e)
        {
            using (DboMiniErpContext c = new())
            {
                Fornecedores forn = new Fornecedores
                {
                    Nome = tbNome.Text,
                    Cnpj = tbCNPJ.Text,
                    Funcao = tbFuncao.Text,
                    DatCriacao = tbDatCriacao.Text
                };

                c.Fornecedores.Add(forn);
                c.SaveChanges();

                dgvForn.DataSource = c.Fornecedores.ToList();
            }
        }
    }
}
