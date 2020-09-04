using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SakilaProject1.Models
{
    public class Inventory
    {
        [Key]
        public int Inventory_id { get; set; }
        public int Film_id { get; set; }
        public int Store_id { get; set; }
        public DateTime Last_update { get; set; }
    }
}
