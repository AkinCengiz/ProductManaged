using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace ProductManaged.ASPWebFormsUI.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen isim giriniz...")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyisim giriniz...")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen cinsiyet giriniz...")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz...")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Lütfen bir şifre giriniz...")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen girdiğiniz şifreyi tekrar girerek doğrulayınız...")]
        [Compare("Password", ErrorMessage = "Lütfen şifrelerin eşleştiğinden emin olunuz...")]
        public string ConfirmPassword { get; set; }
    }
}
