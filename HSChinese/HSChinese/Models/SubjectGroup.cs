using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSChinese.Models
{
    public class SubjectGroup
    {
        public SubjectGroup()
        {
            this.Subjects = new List<Subject>();
            this.GroupStudents = new List<SubjectGroupStudents>();
        }


        public string Id { get; set; }

        public User Teacher { get; set; }

        public string TeacherId { get; set; }

        public int MaxStudents { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EnlistDate { get; set; }

        public IEnumerable<Subject> Subjects { get; set; }

        public IEnumerable<SubjectGroupStudents> GroupStudents { get; set; }
    }
}
