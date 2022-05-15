using Blazor_ConfirmationModal.dbcontext;
using Blazor_ConfirmationModal.Models;

namespace Blazor_ConfirmationModal.Serives
{
    public interface IEmployeeService
    {
        Task addNewEmployeeAsync(Employee emloyee);
    }

    public class EmployeeService : IEmployeeService
    {
        public async Task addNewEmployeeAsync(Employee emloyee)
        {
            using(var dbcontext=new ApplicationDbContext())
            {
                await dbcontext.employees.AddAsync(emloyee);
                await dbcontext.SaveChangesAsync();
            }
        }
    }
}
