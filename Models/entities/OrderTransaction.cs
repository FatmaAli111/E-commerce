using System;
using System.Collections.Generic;

namespace EEcomercEE.entities;

public partial class OrderTransaction
{
    public double OId { get; set; }

    public int? PayId { get; set; }

    public virtual Orderr? Orderr { get; set; }

    public virtual Transactionn? Pay { get; set; }
}
