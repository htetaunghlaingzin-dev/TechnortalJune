using System;
using System.Collections.Generic;

namespace TechnortalJune.DatabaseFirstEFCore.AppDbContextDbFirstModels;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string? Location { get; set; }
}
