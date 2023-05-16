using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("PAYMENT_GATEWAY")]
public partial class PaymentGateway
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("SERVICE_TYPE")]
    [StringLength(50)]
    public string ServiceType { get; set; }

    [Column("LOGO")]
    [StringLength(1000)]
    public string Logo { get; set; }

    [Column("GATEWAY_CODE")]
    [StringLength(255)]
    public string GatewayCode { get; set; }

    [Column("GATEWAY_NAME")]
    [StringLength(255)]
    public string GatewayName { get; set; }

    [Column("EMAIL")]
    [StringLength(255)]
    public string Email { get; set; }

    [Column("CONFIG_JSON")]
    public string ConfigJson { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }
}
