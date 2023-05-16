using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_MOVE_BOX_LOG_DOCUMENT")]
public partial class EdmsMoveBoxLogDocument
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("BOX_CODE")]
    [StringLength(255)]
    public string BoxCode { get; set; }

    [Column("RACK_CODE_OLD")]
    [StringLength(255)]
    public string RackCodeOld { get; set; }

    [Column("RACK_CODE_NEW")]
    [StringLength(255)]
    public string RackCodeNew { get; set; }

    [Column("RACK_POSITION")]
    [StringLength(255)]
    public string RackPosition { get; set; }

    [Column("ORDERING")]
    [StringLength(255)]
    public string Ordering { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }
}
