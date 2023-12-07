using DesafioCodeFirst.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

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
                Note n = new()
                {
                    Cliente = client,
                    Produto = prod
                };
                c.Notas.Add(n);
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
                List<Note> lstNotas = (from Note n in c.Notas select n)
                    .Include(n => n.Produto)
                    .Include(n => n.Cliente)
                    .ToList();
                dgvNotas.DataSource = lstNotas;
            }
        }
    }
}
