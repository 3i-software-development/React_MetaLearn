using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("FACE_FACE_ID")]
public partial class FaceFaceId
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FACE_ID")]
    [StringLength(60)]
    public string FaceId { get; set; }

    [Column("NAME")]
    [StringLength(255)]
    public string Name { get; set; }

    [Column("IMG_PATH")]
    [StringLength(255)]
    [Unicode(false)]
    public string ImgPath { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }
}
