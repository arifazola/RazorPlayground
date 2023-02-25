using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPlayground.Data;

namespace RazorPlayground.Pages
{
    public class DataModel : PageModel
    {

        private readonly IEmployee IEmployee;

        public DataModel(IEmployee employee)
        {
            this.IEmployee = employee;
        }

        public IEnumerable<Employee> Employee { get; set; } = Enumerable.Empty<Employee>();

        public string HelloGuys { get; set; }
        public async void OnGet()
        {
            HelloGuys = "Hello Guys";
            Employee = await IEmployee.GetEmployee();
        }
    }
}
