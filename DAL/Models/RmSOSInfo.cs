using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("RM_SOS_INFO")]
public partial class RmSosInfo
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string Code { get; set; }

    [Column("TITLE")]
    [StringLength(100)]
    public string Title { get; set; }

    [Column("DATA")]
    [StringLength(1000)]
    [Unicode(false)]
    public string Data { get; set; }

    [Column("PRIORITY")]
    public int? Priority { get; set; }

    [Column("NOTE")]
    [StringLength(100)]
    public string Note { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("ADDRESS")]
    [StringLength(255)]
    public string Address { get; set; }

    [Column("IMAGE_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ImageCode { get; set; }
}
