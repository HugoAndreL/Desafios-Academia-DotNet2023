namespace DesafioCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NavProd(object sender, EventArgs e)
        {
            frmProd prod = new();
            prod.Show();
        }

        private void NavForn(object sender, EventArgs e)
        {
            frmForn forn = new();
            forn.Show();
        }

        private void Back(object sender, EventArgs e)
        {
            Dispose();
        }

        private void NavCliente(object sender, EventArgs e)
        {
            frmClient client = new();
            client.Show();
        }

        private void NavNote(object sender, EventArgs e)
        {
            frmNota nota = new();
            nota.Show();
        }
    }
}
