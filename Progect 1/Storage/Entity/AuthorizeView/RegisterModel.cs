using System.ComponentModel.DataAnnotations;

namespace Progect_1.Storage.Entity.AuthorizeView
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Такое имя уже существует!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ошибка!")]
        public string? Lastname { get; set; }

        [Required(ErrorMessage = "Ошибка пароля!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Неверный номер телефона!")]
        public string? NumberOfPhone { get; set; }
    }
}
