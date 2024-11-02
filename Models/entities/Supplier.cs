using System;
using System.Collections.Generic;

namespace EEcomercEE.entities;

public partial class Supplier
{
    public int SupplierId { get; set; }

    public string Name { get; set; } = null!;

    public string? ContactInfo { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public virtual ICollection<SuppCategory> SuppCategories { get; set; } = new List<SuppCategory>();
}
