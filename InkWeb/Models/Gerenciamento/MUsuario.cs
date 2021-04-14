using Models.Tattoo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Gerenciamento
{
    public class MUsuario
    {
        public long ID { get; set; }
        [DisplayName("Usuário")]
        [Required(ErrorMessage = "Informe o nome de usuário")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Informe sua senha")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Informe o seu nome")]
        public string Nome { get; set; }
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Informe seu e-mail")]
        public string Email { get; set; }
        [DisplayName("Número de telefone")]
        public int Numero_Tell { get; set; }
        public string Instagram { get; set; }
        [DisplayName("Data de nascimento")]
        [Required(ErrorMessage = "Informe sua data de nascimento")]
        [DataType(DataType.Date)]
        public DateTime Data_Nascimento { get; set; }
        [Required(ErrorMessage ="Informe seu sexo")]
        public string Sexo { get; set; }
        public long IdPerfil { get; set; }
        public virtual ICollection<MServico> Servicos { get; set; }
    }
}
