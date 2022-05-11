using System.ComponentModel.DataAnnotations;

namespace Progect_1.Storage.Entity.AuthorizeView
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Password required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
