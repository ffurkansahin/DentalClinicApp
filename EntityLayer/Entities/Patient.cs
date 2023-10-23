using System;
using System.Collections.Generic;

namespace EntityLayer.Entities;

public partial class Patient
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public string Gender { get; set; } = null!;

    public string Allergies { get; set; } = null!;
}
