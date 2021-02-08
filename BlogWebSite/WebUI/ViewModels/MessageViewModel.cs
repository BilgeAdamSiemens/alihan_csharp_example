using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebUI.ViewModels
{
    public class MessageViewModel
    {
        [Required(ErrorMessage = "Name Alanı gereklidir.")]
        [DisplayName("İsim")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Adres Alanı Gereklidir.")]
        [DisplayName("Email Adres")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Telefon Numarası Alanı Gereklidir.")]
        [DisplayName("Telefon Numarası")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Mesaj Alanı Gereklidir.")]
        [DisplayName("Mesaj")]
        public string Text { get; set; }
    }
}