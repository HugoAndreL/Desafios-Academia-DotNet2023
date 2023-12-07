using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioCodeFirst.DataModels
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Preco { get; set; }
        public string Descricao { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }

        [Browsable(false)]
        public virtual ICollection<Note> Notas { get; set; }
    }
}
