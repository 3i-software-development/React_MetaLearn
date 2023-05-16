using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace ESEIM.Models
{
    [Table("PRODUCT_ENTITY_MAPPING")]
    public class ProductEntityMapping
    {
        public ProductEntityMapping()
        {
            ListCoil = new List<ProdPackageInfoCustom>();
            ListLogs = new List<ProductEntityLog>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(255)]
        public string Ordering { get; set; }

        public string MappingCode { get; set; }

        [NotMapped]
        public List<ProductEntityLog> ListLogs { get; set; }
        
        public string MappingLog
        {
            get => JsonConvert.SerializeObject(ListLogs);
            set =>
                ListLogs = string.IsNullOrEmpty(value)
                    ? new List<ProductEntityLog>()
                    : JsonConvert.DeserializeObject<List<ProductEntityLog>>(value);
        }

        [StringLength(255)]
        public string ProductQrCode { get; set; }

        public string ProductCode { get; set; }

        public bool IsDeleted { get; set; }

        public decimal? Quantity { get; set; }
        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(maximumLength: 50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedTime { get; set; }

        [StringLength(maximumLength: 50)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public string TicketImpCode { get; set; }

        [StringLength(255)]
        public string WHS_Code { get; set; }

        [StringLength(255)]
        public string FloorCode { get; set; }

        [StringLength(255)]
        public string LineCode { get; set; }

        [StringLength(255)]
        public string RackCode { get; set; }

        [StringLength(255)]
        public string RackPosition { get; set; }

        [NotMapped]
        public List<ProdPackageInfoCustom> ListCoil { get; set; }

        [NotMapped]
        public string PositionInStore { get; set; }
        [NotMapped]
        public string TicketCode { get; set; }
        [NotMapped]
        public decimal? Remain { get; set; }

        [NotMapped]
        public decimal? Size { get; set; }
        [NotMapped]
        public string UnitCode { get; set; }
        [NotMapped]
        public string ProductType { get; set; }
        [NotMapped]
        public string PackType { get; set; }
        [NotMapped]
        public ProductEntityLog EntryLog { get; set; }
        public string ProductNo
        {
            get => string.Join(", ", ListProductNo ?? new List<int>());
            set =>
                ListProductNo = string.IsNullOrEmpty(value)
                    ? new List<int>()
                    : value.Split(", ").Select(int.Parse).ToList();
        }
        [NotMapped]
        public List<int> ListProductNo { get; set; }
        [NotMapped]
        public int? StartNo { get; set; }
        [NotMapped]
        public int? EndNo { get; set; }
    }

    public class ProductEntityLog
    {
        public string OldMappingCode { get; set; }
        public string NewMappingCode { get; set; }
        public decimal Value { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
