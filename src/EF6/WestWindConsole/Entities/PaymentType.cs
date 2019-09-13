﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("PaymentTypes")]
    public class PaymentType
    {
        [Key]
        public int PaymentTypeID { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "PaymentTypeDescription cannot be more than 40 characters long")]
        public string PaymentTypeDescription { get; set; }
    }
}
