using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InkWeb.Models
{
    public class Cliente
    {
        public long ClienteId { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Numero_Tell { get; set; }
        public string Instagram { get; set; }
        public string Data_Nascimento { get; set; }
        public string Sexo { get; set; }
    }
}