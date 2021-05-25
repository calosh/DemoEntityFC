using System.ComponentModel.DataAnnotations;

namespace PruebaEntity.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}