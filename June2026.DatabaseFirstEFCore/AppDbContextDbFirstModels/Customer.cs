using System;
using System.Collections.Generic;

namespace TechnortalJune.DatabaseFirstEFCore.AppDbContextDbFirstModels;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? Address { get; set; }

    public string? Phone { get; set; }
}
