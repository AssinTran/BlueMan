using System;
using System.Collections.Generic;

namespace Models;

public partial class Review
{
    public string Id { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public int? Rating { get; set; }

    public string? Content { get; set; }

    public DateTime? Date { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
