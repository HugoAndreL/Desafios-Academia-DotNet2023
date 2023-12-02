namespace DesafioDBFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NavigateForn(object sender, EventArgs e)
        {
            Forn forn = new();
            forn.Show();
        }

        private void NavigateProd(object sender, EventArgs e)
        {
            Prod prod = new();
            prod.Show();
        }

        private void NavigateClient(object sender, EventArgs e)
        {
            Client client = new();
            client.Show();
        }

        private void NavigateNote(object sender, EventArgs e)
        {
            Note note = new();
            note.Show();
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        // Scaffold-DbContext "Data Source=HGNOTEBOOK;Initial Catalog=dboMiniERP;Persist Security Info=True;User ID=MiniERP;Password=MiniERP123;Encrypt=False;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer -o DataModels
    }
}
