using DesafioDBFirst.DataModels;

namespace DesafioDBFirst
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();

            using (DboMiniErpContext c = new())
            {
                dgvForn.DataSource = c.Clients.ToList();
            }
            // Read
        }

        private void Add(object sender, EventArgs e)
        {
            using (DboMiniErpContext c = new())
            {
                Cliente client = new Cliente
                {
                    Nome = tbNome.Text,
                    Cpf = tbCPF.Text,
                    DatNasc = tbDatNasc.Text
                };

                c.Clients.Add(client);
                c.SaveChanges();

                dgvForn.DataSource = c.Clients.ToList();
            }
        }

        private void Back(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
