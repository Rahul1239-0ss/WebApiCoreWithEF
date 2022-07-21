
namespace WebApiCoreWithEF
{
    using System.Linq;
    using WebApiCoreWithEF.Context;
    using WebApiCoreWithEF.Models;

    public static class InitialData
    {
        public static void Seed(this CompanyContext dbContext)
        {
            if (!dbContext.Employees.Any())
            {
                dbContext.Employees.Add(new Employee
                {
                    EmployeeId = 1,
                    EmployeeFirstName = "Rah",
                    EmployeeMiddleName = "bill",
                    EmployeeLastName="killa"

                });
              

                dbContext.SaveChanges();
            }
        }
    }
}
