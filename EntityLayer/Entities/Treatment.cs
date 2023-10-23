using System;
using System.Collections.Generic;

namespace EntityLayer.Entities;

public partial class Treatment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Cost { get; set; }

    public string Description { get; set; } = null!;
}
