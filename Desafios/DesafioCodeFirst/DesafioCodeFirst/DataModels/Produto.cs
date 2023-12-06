namespace DesafioCodeFirst.DataModels
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Descricao { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
        public virtual ICollection<Note> Notas { get; set; }
    }
}
