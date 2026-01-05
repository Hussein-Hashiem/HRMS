
namespace HRMS.Models
{
    public class Payroll
    {
        public int id { get; set; }
        public decimal salary { get; set; }
        public decimal netpay { get; set; }

        public int employeeId { get; set; } 
        public Employee employee { get; set; }
    }
}