using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sess2.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Customer Id")]
        public int Id { get; set; }

        [MinLength(3)]
        [Required(ErrorMessage = "Name must be specified")]
        [MaxLength(255)]
        [DisplayName("Customer Name")]
        public string Name { get; set; }

        [MaxLength(400)]
        [DisplayName("Customer Address")]
        public string Address { get; set; }
    }
}
