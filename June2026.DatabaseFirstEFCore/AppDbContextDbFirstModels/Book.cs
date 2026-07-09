using System;
using System.Collections.Generic;

namespace TechnortalJune.DatabaseFirstEFCore.AppDbContextDbFirstModels;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string? Author { get; set; }

    public decimal? Price { get; set; }
}
