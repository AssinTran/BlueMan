using System;
using System.Collections.Generic;

namespace Models;

public partial class Cart
{
    public string Id { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public int Quantity { get; set; }

    public double Price { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
