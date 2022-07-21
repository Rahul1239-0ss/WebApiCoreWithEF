
namespace WebApiCoreWithEF.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        public string EmployeeFirstName { get; set; }

        public string EmployeeMiddleName { get; set; }

        public string EmployeeLastName { get; set; }

    }
}
