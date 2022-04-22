using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Sess1
{
    public partial class Student
    {
        public Student()
        {
            Scores = new HashSet<Score>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int Rollno { get; set; }

        public virtual ICollection<Score> Scores { get; set; }
    }
}
