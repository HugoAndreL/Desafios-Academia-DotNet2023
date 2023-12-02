using System;
using System.Collections.Generic;

namespace DesafioDBFirst.DataModels;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string? DatNasc { get; set; }
}
