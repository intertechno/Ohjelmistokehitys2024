using System;
using System.Collections.Generic;

namespace EntityFrameworkSqliteDemo;

public partial class Henkilot
{
    public int HenkiloId { get; set; }

    public string? Nimi { get; set; }

    public string? Osoite { get; set; }

    public string? Maa { get; set; }
}
