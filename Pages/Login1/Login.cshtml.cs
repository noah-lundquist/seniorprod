using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Seniorprod.Pages.Login
{
    public class LoginModel : PageModel
    {

        [BindProperty]
        public Credential Credential { get; set; }
        public void OnGet()
        {
            
        }
        public void OnPost()
        {
            
        }
    }

    public class Credential
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
