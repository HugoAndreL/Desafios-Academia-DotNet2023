namespace DesafioCodeFirst.DataModels
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string DataNascimento { get; set; }


        public virtual ICollection<Note> Notas { get; set; }
    }
}
