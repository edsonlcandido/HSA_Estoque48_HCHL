using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Model
{
    public interface IUsuario
    {
        int id { get; set; }
        string Nome { get; set; }
        bool isAdmin { get; set; }
    }
}
