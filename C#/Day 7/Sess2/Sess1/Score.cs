using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Sess1
{
    public partial class Score
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Studentid { get; set; }
        public int? Subject1 { get; set; }
        public int? Subject2 { get; set; }

        public virtual Student Student { get; set; }
    }
}
