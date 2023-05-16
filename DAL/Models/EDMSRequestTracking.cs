﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_REQUEST_TRACKING")]
public partial class EdmsRequestTracking
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("REASON")]
    [StringLength(255)]
    public string Reason { get; set; }

    [Column("BR_CODE")]
    [StringLength(255)]
    public string BrCode { get; set; }

    [Column("RQ_ID")]
    public int? RqId { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }

    [Column("RQ_STATUS")]
    [StringLength(255)]
    public string RqStatus { get; set; }
}
