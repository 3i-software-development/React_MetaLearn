using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

[Table("OBE_AI_RECOGNITION_TRACKING")]
public partial class ObeAiRecognitionTracking
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FACE_ID")]
    [StringLength(255)]
    [Unicode(false)]
    public string FaceId { get; set; }

    [Column("OBJ_NAME")]
    [StringLength(255)]
    public string ObjName { get; set; }

    [Column("IMG_PATH")]
    [StringLength(255)]
    public string ImgPath { get; set; }

    [Column("CREATED_TIME")]
    public DateTime? CreatedTime { get; set; }

    [Required]
    [Column("DEVICE_ID")]
    [StringLength(255)]
    [Unicode(false)]
    public string DeviceId { get; set; }
}
