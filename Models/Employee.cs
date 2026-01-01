
using System.ComponentModel.DataAnnotations;

namespace HRMS.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string? name { get; set; }
        public string? position { get; set; }
        public DateTime? hire_date { get; set; }
    }
}