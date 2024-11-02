using System;
using System.Collections.Generic;

namespace EEcomercEE.entities;

public partial class CustPhone
{
    public int CustId { get; set; }

    public string? PhoneNumber { get; set; }

    public int CustTempId1 { get; set; }

    public virtual Customer CustTempId1Navigation { get; set; } = null!;
}
