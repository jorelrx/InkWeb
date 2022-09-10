using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Tattoo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id { get; set; }

        [DisplayName("Tamanho da tatuagem")]
        [Required(ErrorMessage = "Selecione o tamanho da tattoo")]
        public string SizeTattoo { get; set; }

        [DisplayName("Local do corpo")]
        [Required(ErrorMessage = "Selecione o local do corpo")]
        public string BodyLocation { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }

        [InverseProperty(nameof(Domain.Entities.Scheduling.Tattoos))]
        public virtual Scheduling? Scheduling { get; set; }
    }
}
