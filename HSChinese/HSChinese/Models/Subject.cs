using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSChinese.Models
{
    public class Subject
    {
        public Subject()
        {
            this.Users = new List<UserSubject>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Lenght { get; set; }

        public byte[] Image { get; set; }

        public IEnumerable<UserSubject> Users { get; set; }

        public string SubjectGroupId { get; set; }

        public SubjectGroup SubjectGroup { get; set; }
    }
}
