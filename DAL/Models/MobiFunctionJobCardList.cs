using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MOBI_FUNCTION_JOBCARD_LIST")]
public partial class MobiFunctionJobcardList
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string Code { get; set; }

    [Column("VALUE")]
    [StringLength(255)]
    public string Value { get; set; }

    [Column("DESC")]
    public string Desc { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }
}
