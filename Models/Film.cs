using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SakilaProject1.Models
{
    public class Film
    {
        [Key]
        public int Film_id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Release_year { get; set; }
        public byte Language_id { get; set; }
        public byte? Original_language_id { get; set; }
        public byte Rental_duration { get; set; }
        public Decimal Rental_rate { get; set; }
        public Int16? Length { get; set; }
        public Decimal Replacement_cost { get; set; }
        public string Rating { get; set; }
        public string Special_features { get; set; }
        public DateTime Last_update { get; set; }
    }
}
