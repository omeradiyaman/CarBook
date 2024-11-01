using System.ComponentModel.DataAnnotations;

namespace CarBook.WebApi.ViewModels
{
    public class LoginErrorViewModel
    {
        [Required]
        public string Message { get; set; }
        public string RedirectUrl { get; set; }
    }
}
