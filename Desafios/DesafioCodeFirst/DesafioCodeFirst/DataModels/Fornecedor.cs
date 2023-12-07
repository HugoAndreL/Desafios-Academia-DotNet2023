using System.ComponentModel;

namespace DesafioCodeFirst.DataModels
{
    internal class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Funcao { get; set; }
        public string DatNasc { get; set; }

        [Browsable(false)]
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
