using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Model;

[Table("JOBCARD_DATA_LOGGER")]
public partial class JobcardDataLogger
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DT_CODE")]
    [StringLength(255)]
    public string DtCode { get; set; }

    [Column("DT_TITLE")]
    [StringLength(255)]
    public string DtTitle { get; set; }

    [Column("DT_VALUE")]
    [StringLength(255)]
    public string DtValue { get; set; }

    [Column("DT_UNIT")]
    [StringLength(255)]
    public string DtUnit { get; set; }

    [Column("DT_GROUP")]
    [StringLength(255)]
    public string DtGroup { get; set; }

    [Column("DT_VALUE_TYPE")]
    [StringLength(255)]
    public string DtValueType { get; set; }

    [Column("SHIFT_CODE")]
    [StringLength(255)]
    public string ShiftCode { get; set; }

    [Column("ITEM_LIST")]
    public string ItemList { get; set; }

    [Column("JOBCARD_CODE")]
    [StringLength(255)]
    public string JobcardCode { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("FLAG")]
    public bool? Flag { get; set; }

    [Column("ACT_INST_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ActInstCode { get; set; }

    [Column("WF_INST_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string WfInstCode { get; set; }

    [Column("SESSION_ID")]
    [StringLength(50)]
    [Unicode(false)]
    public string SessionId { get; set; }
}
