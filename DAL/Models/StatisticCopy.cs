using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class StatisticCopy
{
    public int Id { get; set; }

    public string SessionId { get; set; }

    public DateTime? VisitTime { get; set; }

    public string VisitIp { get; set; }
}
