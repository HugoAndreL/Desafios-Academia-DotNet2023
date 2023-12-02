using System;
using System.Collections.Generic;

namespace DesafioDBFirst.DataModels;

public partial class NotaProd
{
    public int FkNotaId { get; set; }

    public int FkProdId { get; set; }

    public virtual Nota FkNota { get; set; } = null!;

    public virtual Produto FkProd { get; set; } = null!;
}
