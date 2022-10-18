using System.ComponentModel.DataAnnotations;

namespace BTL_CNPM.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}