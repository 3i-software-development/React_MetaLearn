using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CmsTagsXref
{
    public int Id { get; set; }

    public int TagId { get; set; }

    public int ItemId { get; set; }
}
