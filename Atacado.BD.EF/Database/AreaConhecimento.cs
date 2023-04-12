using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.BD.EF.Database;

[Table("AreaConhecimento")]

public partial class AreaConhecimento
{
    [Key]
    public int CodigoArea {get; set;}

    [Unicode(false)]
    public string? Descricao {get; set;}

    public bool? Situacao {get; set;}

    public DateTime? DataInclusao {get; set;}
}
