using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CmsSetting
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Value { get; set; }

    public bool? Published { get; set; }

    public int? Ordering { get; set; }
}
