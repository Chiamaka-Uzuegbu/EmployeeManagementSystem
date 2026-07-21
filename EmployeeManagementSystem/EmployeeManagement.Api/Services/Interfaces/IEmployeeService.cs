using EmployeeManagement.Domain.Entities;

namespace EmployeeManagement.Api.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllAsync();
    }
}
