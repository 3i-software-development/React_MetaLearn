using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CmsRating
{
    public int Id { get; set; }

    public int ItemId { get; set; }

    public int? RatingSum { get; set; }

    public int? RatingCount { get; set; }

    public string Lastip { get; set; }
}
