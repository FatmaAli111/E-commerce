using System;
using System.Collections.Generic;

namespace EEcomercEE.Entities;

public partial class Orderr
{
    public double OrdId { get; set; }

    public string? TotalAmount { get; set; }

    public string? OStatus { get; set; }

    public DateOnly? ODate { get; set; }

    public virtual CustOrder? CustOrder { get; set; }

    public virtual OrderTransaction Ord { get; set; } = null!;

    public virtual ICollection<ProdOrder> ProdOrders { get; set; } = new List<ProdOrder>();
}
