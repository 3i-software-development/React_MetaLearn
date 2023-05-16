using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ESEIM.Models
{
    [Table("CRAWLER_RUNNING_LOG_2")]
    public class CrawlerRunningLog2
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string BotCode { get; set; }
        public string  SessionCode{ get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime?  EndTime{ get; set; }

        public string  JsonReturn{ get; set; }
        public string FileSaveUrl { get; set; }

        public string  TextCrawler{ get; set; }
        public int? TimeScan { get; set; }
        public int?  KeyWord{ get; set; }

        public int? FileSizeDownload { get; set; }


        public DateTime? CreatedTime { get; set; }
        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }
        public DateTime? UpdatedTime { get; set; }

        public bool? IsDeleted { get; set; }
        public string DeletedBy { get; set; }

        public DateTime? DeletedTime { get; set; }


    }
}
