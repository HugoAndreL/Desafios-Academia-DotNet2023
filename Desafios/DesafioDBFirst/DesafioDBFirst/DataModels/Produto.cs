using System;
using System.Collections.Generic;

namespace DesafioDBFirst.DataModels;

public partial class Produto
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int FkForn { get; set; }

    public decimal? Preco { get; set; }

    public string Descricao { get; set; } = null!;

    public virtual Fornecedores FkFornNavigation { get; set; } = null!;
}
