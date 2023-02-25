namespace RazorPlayground.Data
{
    public class EmployeeRepository : IEmployee
    {

        private List<Employee> employees = new()
        {
            new Employee
            {
                Id = 1,
                Name = "Cristiano Ronaldo",
                Age = 38
            },

            new Employee
            {
                Id = 2,
                Name = "Lionel Messi",
                Age = 38
            },

            new Employee
            {
                Id = 3,
                Name = "Maradona",
                Age = 38
            }
        };

        public async Task<Employee> AddEmployee(Employee employee)
        {
            employee.Id = employees.Count + 1;
            await Task.Run(() => employees.Add(employee));
            return employee;
        }

        public async Task<Employee> DeleteEmployee(int Id)
        {
            var index = employees.FindIndex(e => e.Id == Id);
            Employee result = employees[index];
            employees.RemoveAt(index);
            return result;

        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            return await Task.Run(() => employees);
        }
    }
}
