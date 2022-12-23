using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Model
{
    public class Usuario : IUsuarioModel
    {
        [DisplayName("#")]
        public int id { get; set; } 
        [DisplayName("Nome de usuário")]
        public string nome { get; set; }
        [DisplayName("Administrador")]
        public bool isAdmin { get; set; }

    }
}
