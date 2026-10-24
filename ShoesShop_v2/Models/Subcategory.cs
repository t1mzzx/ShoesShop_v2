using System;
using System.Collections.Generic;

namespace ShoesShop_v2.Models;

/// <summary>
/// Подкатегории: кроссовки, сапоги, босоножки, туфли, ботинки
/// </summary>
public partial class Subcategory
{
    public int SubcategoryId { get; set; }

    public string SubcategoryName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
