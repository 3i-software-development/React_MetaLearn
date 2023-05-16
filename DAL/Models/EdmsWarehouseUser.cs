using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("EDMS_WAREHOUSE_USERS")]
public partial class EdmsWarehouseUser
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("WHS_CODE")]
    [StringLength(255)]
    public string WhsCode { get; set; }

    [Column("USER_ID")]
    [StringLength(255)]
    public string UserId { get; set; }

    [Column("ROLE")]
    [StringLength(255)]
    public string Role { get; set; }

    [Column("START_TIME", TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column("END_TIME", TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [Column("NOTE")]
    [StringLength(255)]
    public string Note { get; set; }

    [Column("USER_NAME")]
    [StringLength(255)]
    public string UserName { get; set; }
}
