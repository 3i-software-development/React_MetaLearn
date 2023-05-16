using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FUND_ACC_ENTRY_TRACKING")]
public partial class FundAccEntryTracking
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("AET_CODE")]
    [StringLength(255)]
    public string AetCode { get; set; }

    [Column("ACTION")]
    public string Action { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("FROM_DEVICE")]
    [StringLength(255)]
    [Unicode(false)]
    public string FromDevice { get; set; }

    [Column("LOCATION_TEXT")]
    [StringLength(255)]
    public string LocationText { get; set; }

    [Column("LOCATION_GPS")]
    [StringLength(255)]
    public string LocationGps { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
