using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("MATERIAL_ATTRIBUTE")]
public partial class MaterialAttribute
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ATTRIBUTE")]
    [StringLength(100)]
    public string Attribute { get; set; }

    [Column("ATTRIBUTE_VALUE")]
    [StringLength(255)]
    public string AttributeValue { get; set; }

    [Column("NOTE")]
    [StringLength(500)]
    public string Note { get; set; }

    [Column("PRODUCT_ID")]
    public int? ProductId { get; set; }
}
