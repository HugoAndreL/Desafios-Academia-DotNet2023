using System;
using System.Collections.Generic;

namespace DesafioDBFirst.DataModels;

public partial class Fornecedores
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Cnpj { get; set; } = null!;

    public string? Funcao { get; set; }

    public string? DatCriacao { get; set; }

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
