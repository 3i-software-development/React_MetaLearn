using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("CARD_MAPPING")]
public partial class CardMapping
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CARD_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string CardCode { get; set; }

    [Column("BOARD_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string BoardCode { get; set; }

    [Column("LIST_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ListCode { get; set; }

    [Column("PROJECT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ProjectCode { get; set; }

    [Column("CONTRACT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string ContractCode { get; set; }

    [Column("CUSTOMER_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string CustomerCode { get; set; }

    [Column("SUPPLIER_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string SupplierCode { get; set; }

    [Column("RELATIVE")]
    [StringLength(50)]
    [Unicode(false)]
    public string Relative { get; set; }

    [Column("TEAM_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string TeamCode { get; set; }

    [Column("GROUP_USER_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string GroupUserCode { get; set; }

    [Column("USER_ID")]
    [StringLength(255)]
    [Unicode(false)]
    public string UserId { get; set; }

    [Column("RESPONSIBILITY")]
    [StringLength(100)]
    [Unicode(false)]
    public string Responsibility { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }
}
