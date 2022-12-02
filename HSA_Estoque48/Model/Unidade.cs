using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Model
{
    public class Unidade : IUnidadeModel
    {
        [DisplayName("#")]
        public int id { get; set ; }
        [DisplayName("Nome")]
        public string name { get; set ; }
        [DisplayName("Mostrar")]
        public bool visible { get; set; }
    }
}
