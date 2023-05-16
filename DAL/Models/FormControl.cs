using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FORM_CONTROL")]
public partial class FormControl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FC_CODE")]
    [StringLength(255)]
    public string FcCode { get; set; }

    [Column("FC_NAME")]
    [StringLength(255)]
    public string FcName { get; set; }

    [Column("FC_PARENT")]
    [StringLength(255)]
    public string FcParent { get; set; }

    [Column("FC_ATTRIBUTE")]
    public string FcAttribute { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }
}
