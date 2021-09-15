using Api.Models;

namespace Api.Interfaces
{ 
    public interface IEmployeeService
    {
        Employee GetEmployeeDetails(int id);
    }
}
