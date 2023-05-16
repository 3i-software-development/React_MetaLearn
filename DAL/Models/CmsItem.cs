using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CmsItem
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Alias { get; set; }

    public int? CatId { get; set; }

    public bool? Published { get; set; }

    public string IntroText { get; set; }

    public string FullText { get; set; }

    public string Video { get; set; }

    public string Gallery { get; set; }

    public string ExtraFields { get; set; }

    public string ExtraFieldsSearch { get; set; }

    public DateTime? Created { get; set; }

    public int? CreatedBy { get; set; }

    public string CreatedByAlias { get; set; }

    public int? CheckedOut { get; set; }

    public DateTime? CheckedOutTime { get; set; }

    public DateTime? Modified { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? PublishUp { get; set; }

    public DateTime? PublishDown { get; set; }

    public bool? Trash { get; set; }

    public int? Access { get; set; }

    public int? Ordering { get; set; }

    public short? Featured { get; set; }

    public int? FeaturedOrdering { get; set; }

    public string ImageCaption { get; set; }

    public string ImageCredits { get; set; }

    public string VideoCaption { get; set; }

    public string VideoCredits { get; set; }

    public int? Hits { get; set; }

    public string Params { get; set; }

    public string MetaDesc { get; set; }

    public string MetaData { get; set; }

    public string MetaKey { get; set; }

    public string Plugins { get; set; }

    public string Language { get; set; }

    public int? Template { get; set; }

    public DateTime? DatePost { get; set; }
}
