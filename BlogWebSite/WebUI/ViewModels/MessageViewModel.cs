using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebUI.ViewModels
{
    public class MessageViewModel
    {
        [DisplayName("İsim")]
        [Required(ErrorMessage = "Name Alanı gereklidir.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Adres Alanı gereklidir")]
        [DisplayName("Email Adres")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Email Adresi Yanlış Bir Biçimde Girildi.")]
        public string EmailAddress { get; set; }

        
        [Required(ErrorMessage = "Telefon Numarası Alanı gereklidir")]
        [DisplayName("Telefon Numarası")]
        [DataType(DataType.PhoneNumber)]
        [Phone(ErrorMessage = "Hatalı Telefon Numarası Girildi.")]
        public string PhoneNumber { get; set; }

        [DisplayName("Mesaj")]
        [Required(ErrorMessage = "Mesaj Alanı Gereklidir.")]
        public string Text { get; set; }
    }
}