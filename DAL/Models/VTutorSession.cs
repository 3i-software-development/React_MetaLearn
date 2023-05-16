using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Newtonsoft.Json;

namespace ESEIM.Models
{
    [Table("V_TUTOR_SESSION")]
    public class VTutorSession
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SessionCode { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string MeetingId { get; set; }
        public string Password { get; set; }
        public string JoinUrl { get; set; }
        public string ClassCode { get; set; }

        [NotMapped]
        public List<UserApprovedTutoring> ListUserObject { get; set; }

        public string ListUserApproved
        {
            get
            {
                return JsonConvert.SerializeObject(ListUserObject);
            }
            set
            {
                ListUserObject = string.IsNullOrEmpty(value)
                    ? new List<UserApprovedTutoring>()
                    : JsonConvert.DeserializeObject<List<UserApprovedTutoring>>(value);
            }
        }
        public string Teacher { get; set; }
        public string TeacherName { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public decimal? Price { get; set; }
        public string PathNotepad { get; set; }
        // IsMember Deleted

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedTime { get; set; }
        public string HostClaimCode { get; set; }
    }

    public class VTutorSessionClone
    {
        public bool? IsMember { get; set; }
    }
}
