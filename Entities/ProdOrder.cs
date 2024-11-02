using System;
using System.Collections.Generic;

namespace EEcomercEE.Entities;

public partial class ProdOrder
{
    public int ProdId { get; set; }

    public double OId { get; set; }

    public int? Quantity { get; set; }

    public int? Price { get; set; }

    public int? Discount { get; set; }

    public virtual Orderr OIdNavigation { get; set; } = null!;

    public virtual Product Prod { get; set; } = null!;
}
