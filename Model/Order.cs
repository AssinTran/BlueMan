using System;
using System.Collections.Generic;

namespace Models;

public partial class Order
{
    public string Id { get; set; } = null!;

    public DateTime Date { get; set; }

    public string UserId { get; set; } = null!;

    public int Quantity { get; set; }

    public string Status { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public double Price { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
