using Models.Gerenciamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Tattoo
{
    public class MServico
    {
        public int ID { get; set; }
        [DisplayName("Tamanho da tatuagem")]
        [Required(ErrorMessage = "Selecione o tamanho da tattoo")]
        public string Tamanho_Tattoo { get; set; }
        [DisplayName("Local do corpo")]
        [Required(ErrorMessage = "Selecione o local do corpo")]
        public string Local_Corpo { get; set; }
        [DisplayName("Forma de pagamento")]
        [Required(ErrorMessage = "Selecione a forma de pagamento")]
        public string Forma_Pagamento { get; set; }
        [DisplayName("Data para agendar")]
        [Required(ErrorMessage = "Selecione o dia para agendamento")]
        [DataType(DataType.Date)]
        public DateTime Data_servico { get; set; }
        public string Descricao { get; set; }
        public string Image_Perfil { get; set; }
        public bool Confirmar_Servico { get; set; } = false;
        public long IdUsuario { get; set; }

    }
}
