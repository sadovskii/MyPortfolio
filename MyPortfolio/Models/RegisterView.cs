using MyPortfolio.Models.WrapperAttributes;
using MyPortfolio.Resource;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Models
{
    public class RegisterView
    {
        [RequiredWrapper("Element")]
        public string Email { get; set; }

        [RequiredWrapper("Element")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [RequiredWrapper("Element")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }

        public RegisterView()
        {
            
        }
    }
}
