using System;
using System.Collections.Generic;

namespace EEcomercEE.Models.Entitiess;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<SuppCategory> SuppCategories { get; set; } = new List<SuppCategory>();
}
