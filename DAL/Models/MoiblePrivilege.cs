using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("MOIBLE_PRIVILEGE")]
public partial class MoiblePrivilege
{
    [Column("FUNCTION_CODE")]
    [StringLength(50)]
    public string FunctionCode { get; set; }

    [Column("RESOURCE_CODE")]
    [StringLength(100)]
    public string ResourceCode { get; set; }

    [Column("PRIVILEGE_ID")]
    public int PrivilegeId { get; set; }
}
