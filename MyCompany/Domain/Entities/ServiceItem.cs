using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Wpisz nazwę usługi")]
        [Display(Name = "Nazwa serwisu")]
        public override string Title { get; set; }

        [Display(Name = "Krótki opis usługi")]
        public override string Subtitle { get; set; }

        [Display(Name = "Pełny opis usługi")]
        public override string Text { get; set; }
    }
}
