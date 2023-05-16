using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CmsAttachment
{
    public int Id { get; set; }

    public int ItemId { get; set; }

    public string FileName { get; set; }

    public string Title { get; set; }

    public string TitleAttribute { get; set; }

    public int? Hits { get; set; }

    public string FileUrl { get; set; }

    public string FilePath { get; set; }

    public string FileType { get; set; }
}
