using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_BOX")]
public partial class EdmsBox
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("BOX_CODE")]
    [StringLength(255)]
    public string BoxCode { get; set; }

    [Column("QR_CODE")]
    [StringLength(255)]
    public string QrCode { get; set; }

    [Column("DEPART_CODE")]
    [StringLength(255)]
    public string DepartCode { get; set; }

    [Column("TYPE_PROFILE")]
    [StringLength(255)]
    public string TypeProfile { get; set; }

    [Column("BOX_SIZE")]
    [StringLength(255)]
    public string BoxSize { get; set; }

    [Column("M_CNT_BRIEF")]
    [StringLength(255)]
    public string MCntBrief { get; set; }

    [Column("CNT_BRIEF")]
    [StringLength(255)]
    public string CntBrief { get; set; }

    [Column("START_TIME", TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column("NUM_BOXTH")]
    [StringLength(255)]
    public string NumBoxth { get; set; }

    [Column("STORAGE_TIME", TypeName = "datetime")]
    public DateTime? StorageTime { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("LST_MEMBER_ID")]
    [StringLength(255)]
    public string LstMemberId { get; set; }

    [Column("STATUS_BOX")]
    [StringLength(255)]
    public string StatusBox { get; set; }

    [Column("WHS_CODE")]
    [StringLength(255)]
    public string WhsCode { get; set; }

    [Column("FLOOR_CODE")]
    [StringLength(255)]
    public string FloorCode { get; set; }

    [Column("LINE_CODE")]
    [StringLength(255)]
    public string LineCode { get; set; }

    [Column("RACK_CODE")]
    [StringLength(255)]
    public string RackCode { get; set; }

    [Column("CNT_CELL")]
    [StringLength(255)]
    public string CntCell { get; set; }

    [Column("END_TIME", TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [Column("STATUS_SECURITY")]
    [StringLength(255)]
    public string StatusSecurity { get; set; }

    [Column("STORAGE_PERIOD")]
    public int? StoragePeriod { get; set; }

    [Column("RQ_CODE")]
    [StringLength(255)]
    public string RqCode { get; set; }

    [Column("LST_TYPE_PROFILE_ID")]
    [StringLength(255)]
    public string LstTypeProfileId { get; set; }

    [Column("RC_CODE")]
    [StringLength(255)]
    public string RcCode { get; set; }

    [Column("RACK_POSITION")]
    [StringLength(255)]
    public string RackPosition { get; set; }

    [Column("ORDERING")]
    [StringLength(255)]
    public string Ordering { get; set; }

    [Column("IS_STORED")]
    public bool? IsStored { get; set; }

    [Column("RC_EX_CODE")]
    [StringLength(255)]
    public string RcExCode { get; set; }

    [Column("RQ_EX_CODE")]
    [StringLength(255)]
    public string RqExCode { get; set; }
}
