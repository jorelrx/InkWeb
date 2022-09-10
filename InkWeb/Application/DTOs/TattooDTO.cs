using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Application.DTOs
{
    public class TattooDTO
    {
        [DisplayName("Tamanho da tatuagem")]
        [Required(ErrorMessage = "Selecione o tamanho da tattoo")]
        public string SizeTattoo { get; set; }
        [DisplayName("Local do corpo")]
        [Required(ErrorMessage = "Selecione o local do corpo")]
        public string BodyLocation { get; set; }
        [DisplayName("Descrição")]
        public string Description { get; set; }
    }
}
