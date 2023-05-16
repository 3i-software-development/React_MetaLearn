using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FORM_CAT")]
public partial class FormCat
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FORM_CODE")]
    [StringLength(255)]
    public string FormCode { get; set; }

    [Column("FORM_NAME")]
    [StringLength(255)]
    public string FormName { get; set; }

    [Column("FORM_NOTE")]
    [StringLength(255)]
    public string FormNote { get; set; }

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
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("FORM_TYPE")]
    [StringLength(255)]
    public string FormType { get; set; }

    [Column("FORM_GROUP")]
    [StringLength(255)]
    public string FormGroup { get; set; }
}
