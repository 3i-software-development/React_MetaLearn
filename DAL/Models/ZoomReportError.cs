using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Keyless]
[Table("ZOOM_REPORT_ERROR")]
public partial class ZoomReportError
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("ERROR_CONTENT")]
    [StringLength(2000)]
    public string ErrorContent { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }
}
