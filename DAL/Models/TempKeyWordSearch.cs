using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("TEMP_KEY_WORD_SEARCH")]
public partial class TempKeyWordSearch
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Code { get; set; }

    [Column("VALUE")]
    public string Value { get; set; }

    [Column("UNIT")]
    [StringLength(255)]
    [Unicode(false)]
    public string Unit { get; set; }

    [Column("DATA_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string DataType { get; set; }

    [Column("DOCUMENT_ID")]
    [StringLength(255)]
    [Unicode(false)]
    public string DocumentId { get; set; }

    [Column("GROUP")]
    [StringLength(255)]
    [Unicode(false)]
    public string Group { get; set; }

    [Column("CREATED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(10)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("KEY_SEARCH")]
    [StringLength(255)]
    public string KeySearch { get; set; }
}
