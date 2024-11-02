using System;
using System.Collections.Generic;

namespace EEcomercEE.entities;

public partial class SuppCategory
{
    public int SupplierId { get; set; }

    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ProdCategory CategoryNavigation { get; set; } = null!;

    public virtual Supplier Supplier { get; set; } = null!;
}
