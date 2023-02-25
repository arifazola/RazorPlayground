using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPlayground.Data;

namespace RazorPlayground.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IEmployee IEmployee;
        public CreateModel(IEmployee employee)
        {
            this.IEmployee = employee;
        }

        [BindProperty]
        public Employee Employee { get; set; } = new();
        public async Task <IActionResult> OnPost ()
        {
            await IEmployee.AddEmployee(Employee);
            return RedirectToPage("Data");
        }
    }
}
