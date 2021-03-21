using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Pedido
    {
        public string Tamanho_Tattoo { get; set; }
        public string Local_Corpo { get; set; }
        public string Forma_Pagamento { get; set; }
        public DateTime Data_Agendamento { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }

    }
}
