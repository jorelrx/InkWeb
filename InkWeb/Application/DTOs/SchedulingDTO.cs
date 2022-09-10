using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Application.DTOs
{
    public class SchedulingDTO
    {
        [DisplayName("Data para agendar")]
        [Required(ErrorMessage = "Selecione o dia para agendamento")]
        [DataType(DataType.DateTime)]
        public DateTime DateService { get; set; }

        [DisplayName("Forma de pagamento")]
        [Required(ErrorMessage = "Selecione a forma de pagamento")]
        public string PaymentMethod { get; set; }

        public string Description { get; set; }
    }
}
