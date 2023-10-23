using System;
using System.Collections.Generic;

namespace EntityLayer.Entities;

public partial class Prescription
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Patient { get; set; } = null!;

    public string Treatment { get; set; } = null!;

    public string Medicines { get; set; } = null!;

    public decimal Cost { get; set; }

    public int Quantity { get; set; }
}
