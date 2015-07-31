using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormsWithAutocomplete.SQLServer
{
    [Table("Products")]
    public class Product
    {
        [Required]
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(10)]
        public string Code { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime? CreateData { get; set; }
    }
}
