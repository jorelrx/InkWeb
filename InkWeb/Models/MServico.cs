using Models.Pessoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MServico
    {
        public int ID { get; set; }
        [DisplayName("Tamanho da tatuagem")]
        [Required(ErrorMessage = "Selecione o tamanho da tattoo")]
        public string Tamanho_Tattoo { get; set; }
        public string[] Tamanhos_Tattoo = new[] { "Pequena", "Media", "Grande", "Extra_Grande" };
        [DisplayName("Local do corpo")]
        [Required(ErrorMessage = "Selecione o local do corpo")]
        public string Local_Corpo { get; set; }
        public string[] Locais_Corpo = new[] { "primeiro", "segundo", "terceiro", "quarto" };
        [DisplayName("Forma de pagamento")]
        [Required(ErrorMessage = "Selecione a forma de pagamento")]
        public string Forma_Pagamento { get; set; }
        public string[] Formas_Pagamento = new[] { "Dinheiro", "Cartao", "Transferencia" };
        [DisplayName("Data para agendar")]
        [Required(ErrorMessage = "Selecione o dia para agendamento")]
        public DateTime Data_servico { get; set; }
        public string Descricao { get; set; }
        public string Image_Perfil { get; set; }
        public bool Confirmar_Servico { get; set; } = false;

        public List<long> IdUsuario { get; set; }
        public List<MUsuario> mUsuarios { get; set; }

    }
}
