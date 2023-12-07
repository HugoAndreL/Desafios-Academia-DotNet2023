namespace DesafioCodeFirst.DataModels
{
    internal class Note
    {
        public int Id { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
