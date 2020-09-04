using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SakilaProject1.Models
{
    public class Payment
    {
		[Key]
		public int Payment_id { get; set; }
		public int Customer_id { get; set; }
		public byte Staff_id { get; set; }
		public int? Rental_id { get; set; }
		public Decimal Amount { get; set; }
		public DateTime Payment_date { get; set; }
		public DateTime Last_update { get; set; }
	}
}
