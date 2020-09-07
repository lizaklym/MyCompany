using System.ComponentModel.DataAnnotations;

namespace MyCompany.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Tytuł strony")]
        public override string Title { get; set; } = "Strona informacyjna";

        [Display(Name = "Zawartość strony")]
        public override string Text { get; set; } = "Treść uzupełnia administrator";
    }
}
