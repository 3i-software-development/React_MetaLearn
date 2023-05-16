using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("SERVICE_CAT_ATTRIBUTE")]
public partial class ServiceCatAttribute
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ATTRIBUTE_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string AttributeCode { get; set; }

    [Column("ATTRIBUTE_NAME")]
    [StringLength(255)]
    public string AttributeName { get; set; }

    [Column("ATTRIBUTE_VALUE")]
    public string AttributeValue { get; set; }

    [Column("FIELD_TYPE")]
    [StringLength(255)]
    public string FieldType { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("SERVICE_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ServiceCode { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("CREATED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column("IS_DELETED")]
    public bool? IsDeleted { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeletedBy { get; set; }
}
