using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSChinese.Models
{
    public class User:IdentityUser
    {

        public User()
        {
            this.Subjects = new List<UserSubject>();
            this.SubjectGroups = new List<SubjectGroupStudents>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateofBirth { get; set; }

        public IEnumerable<UserSubject> Subjects { get; set; }

        public IEnumerable<SubjectGroupStudents> SubjectGroups { get; set; }

       



    }
}
