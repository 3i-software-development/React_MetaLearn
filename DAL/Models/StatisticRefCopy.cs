using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class StatisticRefCopy
{
    public int Id { get; set; }

    public int? StatisticId { get; set; }

    public DateTime? VisitTime { get; set; }

    public string UrlRef { get; set; }
}
