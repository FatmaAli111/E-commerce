using System;
using System.Collections.Generic;

namespace EEcomercEE.Entities;

public partial class Product
{
    public int PId { get; set; }

    public string PName { get; set; } = null!;

    public int? Price { get; set; }

    public string? Description { get; set; }

    public virtual ProdInventory PId1 { get; set; } = null!;

    public virtual ProdCategory PIdNavigation { get; set; } = null!;

    public virtual ICollection<ProdOrder> ProdOrders { get; set; } = new List<ProdOrder>();
}
