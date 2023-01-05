using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Model
{
    public interface IUsuarioModel
    {
        int id { get; set; }
        string nome { get; set; }
        bool isAdmin { get; set; }
    }
}
