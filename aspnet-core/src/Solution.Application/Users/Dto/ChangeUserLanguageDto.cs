using System.ComponentModel.DataAnnotations;

namespace Solution.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}