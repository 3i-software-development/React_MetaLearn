using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("OBJECT_TYPE_STATUS_GROUP")]
public partial class ObjectTypeStatusGroup
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("OBJECT_TYPE_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ObjectTypeCode { get; set; }

    [Column("STATUS_GROUP_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string StatusGroupCode { get; set; }
}
