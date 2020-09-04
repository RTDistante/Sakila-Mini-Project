using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SakilaProject1.Models
{
	public class Rental
	{
        [Key]
		public int Rental_id { get; set; }
		public DateTime Rental_date { get; set; }
		public int Inventory_id { get; set; }
		public int Customer_id { get; set; }
		public DateTime? Return_date { get; set; }
		public byte Staff_id { get; set; }
		public DateTime Last_update { get; set; }
	}
}
