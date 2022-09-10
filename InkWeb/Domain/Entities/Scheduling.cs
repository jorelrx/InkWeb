using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Scheduling
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string Id { get; set; }

        [DisplayName("Data para agendar")]
        [Required(ErrorMessage = "Selecione o dia para agendamento")]
        [DataType(DataType.DateTime)]
        public DateTime DateService { get; set; }

        [DisplayName("Forma de pagamento")]
        [Required(ErrorMessage = "Selecione a forma de pagamento")]
        public string PaymentMethod { get; set; }

        public string Description { get; set; }

        public bool ConfirmService { get; set; } = false;

        [InverseProperty(nameof(Domain.Entities.Tattoo.Scheduling))]
        public virtual ICollection<Tattoo> Tattoos { get; set; }
    }
}
