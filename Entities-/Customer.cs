using System;
using System.Collections.Generic;

namespace EEcomercEE.Entities;

public partial class Customer
{
    public int CustId { get; set; }

    public string CustName { get; set; } = null!;

    public string? Street { get; set; }

    public string? City { get; set; }

    public virtual ICollection<CustOrder> CustOrders { get; set; } = new List<CustOrder>();

    public virtual CustPhone? CustPhone { get; set; }
}
