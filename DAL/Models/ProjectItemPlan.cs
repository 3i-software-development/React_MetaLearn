using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ESEIM.Models
{
    [Table("PROJECT_ITEM_PLAN")]
    public class ProjectItemPlan
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(255)]
        public string ItemCode { get; set; }
        [StringLength(255)]
        public string ItemName { get; set; }
        [StringLength(255)]
        public string ItemLevel { get; set; }

        [DataType("decimal(18,0)")]
        public decimal ItemWeight { get; set; }

        [StringLength(255)]
        public string ItemParent { get; set; }

        [StringLength(255)]
        public string ProjectCode { get; set; }

        [DataType("decimal(18,0)")]
        public string DurationTime { get; set; }

        [StringLength(255)]
        public string DurationUnit { get; set; }

        [DataType("decimal(18,0)")]
        public string Cost { get; set; }

        [StringLength(255)]
        public string CostUnit { get; set; }
    }
}
