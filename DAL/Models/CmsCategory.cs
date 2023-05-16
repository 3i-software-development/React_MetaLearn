using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CmsCategory
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Alias { get; set; }

    public string Description { get; set; }

    public int? Parent { get; set; }

    public int? ExtraFieldsGroup { get; set; }

    public bool? Published { get; set; }

    public int? Access { get; set; }

    public int? Ordering { get; set; }

    public string Image { get; set; }

    public string Params { get; set; }

    public bool? Trash { get; set; }

    public string Plugins { get; set; }

    public string Language { get; set; }

    public int? Template { get; set; }
}
