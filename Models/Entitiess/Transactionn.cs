using System;
using System.Collections.Generic;

namespace EEcomercEE.Models.Entitiess;

public partial class Transactionn
{
    public int PaymentId { get; set; }

    public int? Amount { get; set; }

    public string? PayStatus { get; set; }

    public string? TranStatus { get; set; }

    public virtual ICollection<OrderTransaction> OrderTransactions { get; set; } = new List<OrderTransaction>();
}
