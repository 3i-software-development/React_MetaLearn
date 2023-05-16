using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("DISPATCHES_USER")]
public partial class DispatchesUser
{
    [Key]
    [Column("GROUP_USER_CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string GroupUserCode { get; set; }

    [Required]
    [Column("USER_ID")]
    [StringLength(50)]
    [Unicode(false)]
    public string UserId { get; set; }
}
