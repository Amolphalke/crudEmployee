using System.ComponentModel.DataAnnotations;

namespace crudemployee.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public DateTime dob { get; set; }
    }
}
