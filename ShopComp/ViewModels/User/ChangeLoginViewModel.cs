﻿using System.ComponentModel.DataAnnotations;

namespace ShopComp.ViewModels
{
    public class ChangeLoginViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[mail|gmail]*\.(ru|com)$", ErrorMessage = "Некорректный адрес. Только mail.ru или gmail.com")]
        [StringLength(100, ErrorMessage = "Длина строки должна быть до 100 символов")]
        public string NewLogin { get; set; }
    }
}
