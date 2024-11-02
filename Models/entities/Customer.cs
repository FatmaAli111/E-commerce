using System;
using System.Collections.Generic;

namespace EEcomercEE.entities;

public partial class Customer
{
    public int CustId { get; set; }

    public string CustName { get; set; } = null!;

    public string? Street { get; set; }

    public string? City { get; set; }

    public string CustPhone { get; set; } = null!;

    public virtual ICollection<CustOrder> CustOrders { get; set; } = new List<CustOrder>();

    public virtual ICollection<CustPhone> CustPhones { get; set; } = new List<CustPhone>();
}
