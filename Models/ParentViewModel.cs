using System.ComponentModel.DataAnnotations;

namespace Test_Series.Models
{
    public class ParentViewModel
    {
        [Key]
        public int PlanId { get; set; }
        public string Name { get; set; }
        public string AdditionalBenefits { get; set; }
        public string PaperPatter { get; set; }
    }
}
