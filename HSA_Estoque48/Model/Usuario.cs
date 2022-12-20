using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Model
{
    public class Usuario : IUsuario
    {
        [DisplayName("#")]
        public int id { get; set; } 
        [DisplayName("Nome de usuário")]
        public string Nome { get; set; }
        [DisplayName("Administrador")]
        public bool isAdmin { get; set; }

    }
}
