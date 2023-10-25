using System;
using System.Collections.Generic;

namespace EntityLayer.Entities;

public partial class Appointment
{
    public int Id { get; set; }

    public string Patient { get; set; } = null!;

    public string Treatment { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Time { get; set; } = null!;
}
