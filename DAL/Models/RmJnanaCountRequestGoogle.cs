using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QuickApp.Model;

[Table("RM_JNANA_COUNT_REQUEST_GOOGLE")]
public partial class RmJnanaCountRequestGoogle
{
    [Key]
    public int Id { get; set; }

    [Column("Create_time")]
    public DateTime CreateTime { get; set; }

    public string Date { get; set; }

    [Column("Is_limit")]
    public int IsLimit { get; set; }

    public string Key { get; set; }

    [Column("Num_request")]
    public int NumRequest { get; set; }

    [Column("Service_type")]
    [StringLength(50)]
    public string ServiceType { get; set; }

    [Column("Update_time")]
    public DateTime UpdateTime { get; set; }

    [Column("device")]
    [StringLength(255)]
    public string Device { get; set; }
}
