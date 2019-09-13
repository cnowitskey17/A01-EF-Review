using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Territories")]
    public class Territory
    {
        [Key]
        [Required]
        [StringLength(20, ErrorMessage = "TerritoryID cannot be more than 20 characters long")]
        public string TerritoryID { get; set; }

    }
}
