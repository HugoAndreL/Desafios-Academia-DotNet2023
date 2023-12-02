using System;
using System.Collections.Generic;

namespace DesafioDBFirst.DataModels;

public partial class Nota
{
    public int Id { get; set; }

    public int FkCliente { get; set; }

    public int FkProd { get; set; }

    public string MetPagamento { get; set; } = null!;

    public DateTime DatCompra { get; set; }
}
