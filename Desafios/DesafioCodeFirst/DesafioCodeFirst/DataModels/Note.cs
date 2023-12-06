using System.ComponentModel;

namespace DesafioCodeFirst.DataModels
{
    internal class Note
    {
        [Browsable(false)]
        public int? IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }

        [Browsable(false)]
        public int? IdProd { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
