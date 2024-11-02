using System;
using System.Collections.Generic;

namespace EEcomercEE.Models.Entitiess;

public partial class Inventory
{
    public int InventoryId { get; set; }

    public string InventoryName { get; set; } = null!;

    public string? QuantitySold { get; set; }

    public string? QuantityInStock { get; set; }

    public virtual ICollection<ProdInventory> ProdInventories { get; set; } = new List<ProdInventory>();
}
