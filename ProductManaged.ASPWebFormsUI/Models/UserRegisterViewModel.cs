using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using Newtonsoft.Json;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace ProductManaged.ASPWebFormsUI.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen isim giriniz...")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyisim giriniz...")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz...")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen mail adresinizi giriniz...")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen bir şifre giriniz...")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen girdiğiniz şifreyi tekrar girerek doğrulayınız...")]
        [Compare("Password", ErrorMessage = "Lütfen şifrelerin eşleştiğinden emin olunuz...")]
        public string ConfirmPassword { get; set; }
    }
}
