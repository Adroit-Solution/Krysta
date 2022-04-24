using System.ComponentModel.DataAnnotations;

namespace Test_Series.Models
{
    public class IssueModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(200,ErrorMessage ="Maximum Length is 200")]
        public string Issue { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Email")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
