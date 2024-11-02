using System;
using System.Collections.Generic;

namespace EEcomercEE.Entities;

public partial class ProdInventory
{
    public int ProdId { get; set; }

    public int InventoryId { get; set; }

    public virtual Inventory Inventory { get; set; } = null!;

    public virtual Product? Product { get; set; }
}
