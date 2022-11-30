using HSA_Estoque.Model;
using HSA_Estoque.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Presenter
{
    public class Tipo : Model.ITipoModel
    {
        List<Model.Tipo> _showAll;
        ITipoRepository _repository;

        public List<Model.Tipo> showAll {
            get{
                _showAll = (List<Model.Tipo>)_repository.findAll();
                return _showAll; 
            } 
        }

        public Tipo()

        {            
            _repository = new Repository.Tipo();
            _showAll = (List<Model.Tipo>)_repository.findAll();
        }

        public int add()
        {
            Model.Tipo modelTipo = new Model.Tipo();
            modelTipo.name = this.name;
            modelTipo.visible = true;
            return _repository.add(modelTipo);
        }

        public void update()
        {
            Model.Tipo modelTipo = new Model.Tipo();
            modelTipo.id = this.id;
            modelTipo.name = this.name;
            modelTipo.visible = this.visible;
            _repository.update(modelTipo);
        }

        public void get(int id)
        {
            Model.Tipo modelTipo =  _repository.get(id);
            this.id = modelTipo.id;
            this.name = modelTipo.name; 
            this.visible = modelTipo.visible;
        }

        public int id { get; set; }
        public string name { get; set; }
        public bool visible { get; set ; }
    }
}
