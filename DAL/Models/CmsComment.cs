using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CmsComment
{
    public int Id { get; set; }

    public int ItemId { get; set; }

    public int? UserId { get; set; }

    public string UserName { get; set; }

    public DateTime? CommentDate { get; set; }

    public string CommentText { get; set; }

    public string CommentEmail { get; set; }

    public string CommentUrl { get; set; }

    public bool? Published { get; set; }

    public string CommentTitle { get; set; }
}
