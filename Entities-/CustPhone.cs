using System;
using System.Collections.Generic;

namespace EEcomercEE.Entities;

public partial class CustPhone
{
    public int CustId { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual Customer Cust { get; set; } = null!;
}
