using DesafioCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;

namespace DesafioCodeFirst
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
            Read();
        }

        private void Add(object sender, EventArgs e)
        {
            using (Context c = new())
            {
                c.Clientes.Add(new Cliente()
                { 
                    Nome = tbNome.Text,
                    Idade = int.Parse(tbIdade.Text),
                    Cpf = tbCpf.Text,
                    Telefone = tbTel.Text,
                    DataNascimento = dtpDatNasc.Value.ToShortDateString()
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
                List<Cliente> lstClients = (from Cliente client in c.Clientes select client)
                    .Include(c => c.Notas)
                    .ToList();
                dgvClient.DataSource = lstClients;
            }
        }
    }
}
