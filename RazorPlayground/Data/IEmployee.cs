namespace RazorPlayground.Data
{
    public interface IEmployee
    {
        Task<IEnumerable<Employee>> GetEmployee();
        Task<Employee> AddEmployee(Employee employee);

        Task<Employee> DeleteEmployee(int Id);
    }
}
