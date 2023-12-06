namespace DesafioCodeFirst.DataModels
{
    internal class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Funcao { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
