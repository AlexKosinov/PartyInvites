using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Пожалуйста, введите Ваше имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Ваш электронный адрес")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Пожалуйста, введите правильный электронный адрес")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Ваш номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите, будете ли Вы присутствовать")]
        public bool? WillAttend { get; set; }
    }
}