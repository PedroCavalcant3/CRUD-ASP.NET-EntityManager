using System;
using System.Collections.Generic;

namespace ProductApp.Models;

public partial class Product
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Price { get; set; }

    public string? Category { get; set; }

    public int? quantity { get; set; }
}
