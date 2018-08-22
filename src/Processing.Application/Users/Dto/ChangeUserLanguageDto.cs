using System.ComponentModel.DataAnnotations;

namespace Processing.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}