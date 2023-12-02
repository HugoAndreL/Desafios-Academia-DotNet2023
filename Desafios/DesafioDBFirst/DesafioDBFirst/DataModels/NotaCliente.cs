using System;
using System.Collections.Generic;

namespace DesafioDBFirst.DataModels;

public partial class NotaCliente
{
    public int FkNotaId { get; set; }

    public int FkClientId { get; set; }

    public virtual Cliente FkClient { get; set; } = null!;

    public virtual Nota FkNota { get; set; } = null!;
}
