using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sess2.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Order Id")]
        public int Id { get; set; }
        public Customer Customer { get; set; } //Navigation Property (Foreign Key)
        public Employee Employee { get; set; } //Navigation Property (Foreign Key)

        [Required(ErrorMessage ="Amount must be specified")]
        [DisplayName("Order Amount")]
        public decimal Amount { get; set; }
    }
}
