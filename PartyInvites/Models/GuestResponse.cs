using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Пожалуйста, введите Ваше имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Ваш почтовый адрес")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Пожалуйста, введите корректный адрес")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите Ваш номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите, будете ли Вы присутствовать")]
        public bool? WillAttend { get; set; }
    }
}