using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Model
{
    public interface ITipoModel
    {
        int id { get; set; }
        string name { get; set; }
        bool visible { get; set; }
    }
}
