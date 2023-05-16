using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("ORDER_REQUEST_RAW_FILES_27_5")]
public partial class OrderRequestRawFiles275
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FILE_NAME")]
    [StringLength(255)]
    public string FileName { get; set; }

    [Column("FILE_TYPE")]
    [StringLength(100)]
    public string FileType { get; set; }

    [Column("FILE_SIZE")]
    [StringLength(100)]
    public string FileSize { get; set; }

    [Column("DESCRIPTION")]
    public string Description { get; set; }

    [Column("FILE_PATH")]
    [StringLength(255)]
    public string FilePath { get; set; }

    [Column("REQ_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ReqCode { get; set; }

    [Column("CREATED_BY")]
    [StringLength(50)]
    public string CreatedBy { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(50)]
    public string UpdatedBy { get; set; }

    [Column("UPDATED_TIME")]
    public DateTime? UpdatedTime { get; set; }

    [Column("DELETED_BY")]
    [StringLength(50)]
    public string DeletedBy { get; set; }

    [Column("DELETED_TIME")]
    public DateTime? DeletedTime { get; set; }

    [Column("IS_DELETED")]
    public bool IsDeleted { get; set; }
}
