using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public int Numero_Tell { get; set; }
        public string Instagram { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string[] Sexo { get; set; } = new[] { "Masculino", "Feminino", "Unspecified" };
        public bool TypeAccount { get; set; }
        
        public void Login(string userName, string senha)
        {

        }
    }
}
