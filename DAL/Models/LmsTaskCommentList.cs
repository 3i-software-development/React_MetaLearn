using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ESEIM.Models
{
    [Table("LMS_TASK_COMMENT_LIST")]
    public class LmsTaskCommentList
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(255)]
        public string LmsTaskCode { get; set; }

        [StringLength(255)]
        public string CmtId { get; set; }

        public string CmtContent { get; set; }

        [StringLength(255)]
        public string MemberId { get; set; }

        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdatedTime { get; set; }

        [StringLength(255)]
        public string UpdatedBy { get; set; }

        public bool Flag { get; set; }
        public string JsonCanvas { get; set; }

        public int? RefParent { get; set; }
        public int? Like { get; set; }
        public int? Dislike { get; set; }
        public string LikeLog
        {
            get => JsonConvert.SerializeObject(ListLogLikes);
            set =>
                ListLogLikes = string.IsNullOrEmpty(value)
                    ? new List<LogLike>()
                    : JsonConvert.DeserializeObject<List<LogLike>>(value);
        }
        [NotMapped]
        public List<LogLike> ListLogLikes { get; set; }
    }
}
