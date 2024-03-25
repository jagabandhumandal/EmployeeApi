using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Models
{
    public class Employee {

        [Key]
        public int empid { get; set; }
        public string Name { get; set; }
        public string department { get; set; }
        public string designation { get; set; }
    }
}
