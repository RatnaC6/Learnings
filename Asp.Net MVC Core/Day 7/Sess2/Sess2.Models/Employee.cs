using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Design;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Sess2.Models
{
    public class Employee
    {
        //[Key] //Explicitly declare as Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Employee Id")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Title must be specified")]
        [MinLength(3)]
        [MaxLength(255)]
        [DisplayName("Designation")]
        public string Title { get; set; }

        [MinLength(3)]
        [Required(ErrorMessage = "Name must be specified")]
        [MaxLength(255)]
        [DisplayName("Employee Name")]
        public string Name { get; set; }
    }
}
