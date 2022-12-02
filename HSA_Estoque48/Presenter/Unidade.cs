using HSA_Estoque.Model;
using HSA_Estoque.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Presenter
{
    public class Unidade : Model.IUnidadeModel
    {
        List<Model.Unidade> _showAll;
        IUnidadeRepository _repository;

        public List<Model.Unidade> showAll {
            get{
                _showAll = (List<Model.Unidade>)_repository.findAll();
                return _showAll; 
            } 
        }

        public Unidade()

        {            
            _repository = new Repository.Unidade();
            _showAll = (List<Model.Unidade>)_repository.findAll();
        }

        public int add()
        {
            Model.Unidade modelUnidade= new Model.Unidade();
            modelUnidade.name = this.name;
            modelUnidade.visible = true;
            return _repository.add(modelUnidade);
        }

        public void update()
        {
            Model.Unidade  modelUnidade = new Model.Unidade();
            modelUnidade.id = this.id;
            modelUnidade.name = this.name;
            modelUnidade.visible = this.visible;
            _repository.update(modelUnidade);
        }

        public void get(int id)
        {
            Model.Unidade modelUnidade =  _repository.get(id);
            this.id = modelUnidade.id;
            this.name = modelUnidade.name; 
            this.visible = modelUnidade.visible;
        }

        public int id { get; set; }
        public string name { get; set; }
        public bool visible { get; set ; }
    }
}
