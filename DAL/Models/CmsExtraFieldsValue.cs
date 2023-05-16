using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CmsExtraFieldsValue
{
    public int Id { get; set; }

    /// <summary>
    /// Tiêu đề
    /// </summary>
    public string FieldValue { get; set; }

    /// <summary>
    /// Vị trí
    /// </summary>
    public int? FieldGroup { get; set; }

    /// <summary>
    /// Thứ tự
    /// </summary>
    public int? Ordering { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public bool? Trash { get; set; }

    public bool? Publish { get; set; }

    public DateTime? DatePost { get; set; }
}
