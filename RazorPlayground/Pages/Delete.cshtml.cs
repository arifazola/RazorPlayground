using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPlayground.Data;

namespace RazorPlayground.Pages
{
    public class DeleteModel : PageModel
    {

        private readonly IEmployee IEmployee;

        public string Message { get; set; } 

        public DeleteModel(IEmployee IEmployee)
        {
            this.IEmployee = IEmployee;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            //var id = RouteData.Values["id"];
            IEmployee.DeleteEmployee(id);
            //RedirectToPage("Data");
            //Console.WriteLine(id);
            return RedirectToPage("Data");
        }
    }
}
