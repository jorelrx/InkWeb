using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Pessoa
{
    public class MUsuario
    {
        [DisplayName("ID")]
        public long Id { get; set; }
        [DisplayName("Usuário")]
        [Required(ErrorMessage = "Informe o nome de usuário")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Informe sua senha")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Informe o seu nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o seu sobrenome")]
        public string Sobrenome { get; set; }
        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Informe seu e-mail")]
        public string Email { get; set; }
        [DisplayName("Número de telefone")]
        public int Numero_Tell { get; set; }
        public string Instagram { get; set; }
        [DisplayName("Data de nascimento")]
        [Required(ErrorMessage = "Informe sua data de nascimento")]
        public DateTime Data_Nascimento { get; set; }
        public string[] Sexo { get; set; } = new[] { "Masculino", "Feminino", "Outro" };
        public virtual ICollection<MServico> Servicos { get; set; }

    }
}
