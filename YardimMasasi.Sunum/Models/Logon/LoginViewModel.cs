using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace YardimMasasi.Sunum.Models.Logon
{
    public class LoginViewModel
    {
        [Required()]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir e-posta adrersi giriniz")]
        public string Eposta { get; set; }

        [Required()]
        [MinLength(4, ErrorMessage = "En az 4 karakter")]
        public string Sifre { get; set; }
    }
}
