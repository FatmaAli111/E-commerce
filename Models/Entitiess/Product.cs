using System;
using System.Collections.Generic;

namespace EEcomercEE.Models.Entitiess;

public partial class Product
{
    public int PId { get; set; }

    public string PName { get; set; } = null!;

    public int? Price { get; set; }

    public string? Description { get; set; }

    public string? Imagepath { get; set; }

    public virtual ICollection<ProdOrder> ProdOrders { get; set; } = new List<ProdOrder>();
}
