using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Keyless]
[Table("EDMS_FILES")]
public partial class EdmsFile
{
    /// <summary>
    /// Customer Id
    /// </summary>
    [Column("FILE_ID")]
    public int FileId { get; set; }

    [Column("FILE_CODE")]
    [StringLength(100)]
    public string FileCode { get; set; }

    [Column("FILE_NAME")]
    [StringLength(255)]
    public string FileName { get; set; }

    [Column("FILE_SIZE", TypeName = "decimal(18, 0)")]
    public decimal? FileSize { get; set; }

    [Column("FILE_TYPE_PHYSIC")]
    [StringLength(255)]
    public string FileTypePhysic { get; set; }

    [Column("FILE_TYPE_WORK")]
    [StringLength(255)]
    public string FileTypeWork { get; set; }

    [Column("DESC")]
    public string Desc { get; set; }

    [Column("TAGS")]
    public string Tags { get; set; }

    [Column("URL")]
    [StringLength(255)]
    public string Url { get; set; }

    [Column("REPOS_CODE")]
    [StringLength(100)]
    [Unicode(false)]
    public string ReposCode { get; set; }

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

    [Column("NUMBER_DOCUMENT")]
    [StringLength(50)]
    public string NumberDocument { get; set; }

    [Column("MIME_TYPE")]
    [StringLength(255)]
    [Unicode(false)]
    public string MimeType { get; set; }

    [Column("CLOUD_FILE_ID")]
    [StringLength(100)]
    [Unicode(false)]
    public string CloudFileId { get; set; }

    [Column("IS_EDIT")]
    public bool? IsEdit { get; set; }

    [Column("IS_FILE_MASTER")]
    public bool? IsFileMaster { get; set; }

    [Column("IS_FILE_ORIGIN")]
    public bool? IsFileOrigin { get; set; }

    [Column("FILE_PARENT_ID")]
    public int? FileParentId { get; set; }

    [Column("EDITED_FILE_BY")]
    [StringLength(50)]
    [Unicode(false)]
    public string EditedFileBy { get; set; }

    [Column("EDITED_FILE_TIME")]
    public DateTime? EditedFileTime { get; set; }

    [Column("LIST_USER_VIEW")]
    public string ListUserView { get; set; }

    [Column("IS_SCAN")]
    public bool? IsScan { get; set; }

    [Column("QR_CODE")]
    public string QrCode { get; set; }

    [Column("META_DATA_EXT")]
    public string MetaDataExt { get; set; }

    [Column("IS_SEARCH_INDEX")]
    public bool? IsSearchIndex { get; set; }

    [Column("AUDIO_BOOK")]
    [StringLength(1000)]
    public string AudioBook { get; set; }

    [Column("PRICE", TypeName = "decimal(18, 0)")]
    public decimal? Price { get; set; }
}
