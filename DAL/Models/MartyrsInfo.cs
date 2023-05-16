using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class MartyrsInfo
{
    public int Id { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public string BirthYear { get; set; }

    /// <summary>
    /// Chức vụ
    /// </summary>
    public string Regency { get; set; }

    /// <summary>
    /// Quân hàm
    /// </summary>
    public string Rank { get; set; }

    /// <summary>
    /// Tình trạng hôn nhân
    /// </summary>
    public int? MaritalStatus { get; set; }

    public string Sex { get; set; }

    /// <summary>
    /// Quê quán
    /// </summary>
    public string Native { get; set; }

    /// <summary>
    /// Ngày nhập ngũ
    /// </summary>
    public DateTime? DateEntry { get; set; }

    /// <summary>
    /// Ngày hy sinh
    /// </summary>
    public DateTime? DeadDay { get; set; }

    /// <summary>
    /// Địa điểm hy sinh
    /// </summary>
    public string DeadPlace { get; set; }

    /// <summary>
    /// Địa điểm hy sinh GPS
    /// </summary>
    public string DeadPlaceGps { get; set; }

    /// <summary>
    /// Ảnh chân dung
    /// </summary>
    public string ImageFace { get; set; }

    public string Status { get; set; }

    /// <summary>
    /// Hình ảnh mộ
    /// </summary>
    public string ImageRip { get; set; }

    /// <summary>
    /// Địa điểm nghĩa trang
    /// </summary>
    public string CemeteryPlace { get; set; }

    /// <summary>
    /// Địa điểm nghĩa trang GPS
    /// </summary>
    public string CemeteryPlaceGps { get; set; }

    /// <summary>
    /// Mô tả kỷ vật
    /// </summary>
    public string SouvenirNote { get; set; }

    /// <summary>
    /// Ảnh kỷ vật
    /// </summary>
    public string SouvenirImage { get; set; }

    public string Note { get; set; }
}
