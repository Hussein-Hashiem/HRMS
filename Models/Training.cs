
namespace HRMS.Models
{
    public class Training
    {
        public int id { get; set; }

        public string name { get; set; }

        public List<Employee> employees { get; set; }   
    }
}