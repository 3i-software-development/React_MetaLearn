using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("WORK_OS_ADDRESS_CARD")]
public partial class WorkOsAddressCard
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CARD_CODE")]
    [StringLength(100)]
    public string CardCode { get; set; }

    [Column("LOCATION_TEXT")]
    public string LocationText { get; set; }

    [Column("LOCATION_GPS")]
    [StringLength(255)]
    [Unicode(false)]
    public string LocationGps { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(1)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }
}
