using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HSChinese.Models
{
    public class UserSubject
    {
       [Key]
        public string  UserId { get; set; }
        public User Student { get; set; }
        public string  SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
