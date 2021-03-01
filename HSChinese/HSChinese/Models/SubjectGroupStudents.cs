using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HSChinese.Models
{
    public class SubjectGroupStudents
    {

        [Key]
        public string UserId { get; set; }

        public User User { get; set; }

        [Key]
        public string SubjectGroupId { get; set; }

        public SubjectGroup SubjectGroup { get; set; }
    }
}
