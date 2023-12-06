using DesafioCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;

namespace DesafioCodeFirst
{
    public partial class frmNota : Form
    {
        public frmNota()
        {
            InitializeComponent();
            Read();
        }

        private void Add(object sender, EventArgs e)
        {
            using (Context c = new())
            {
                Produto prod = c.Produtos.FirstOrDefault(p => p.Id == int.Parse(tbProd.Text));
                Cliente client = c.Clientes.FirstOrDefault(c => c.Id == int.Parse(tbClient.Text));

                c.Notas.Add(new Note()
                {
                    IdCliente = client.Id,
                    Cliente = client,

                    IdProd = prod.Id,
                    Produto = prod
                });

                Read();
            }
        }

        private void GerarPdf(object sender, EventArgs e)
        {
            using (Context c = new())
            {

            }
        }

        private void Back(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Read()
        {
            using (Context c = new())
            {
                List<Note> lstNotas = (from Note n in c.Notas select n)
                    .ToList();
                dgvNota.DataSource = lstNotas;
            }
        }
    }
}
