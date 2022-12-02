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
#if DEBUG
            _showAll = (List<Model.Unidade>)_repository.findAll();
            if (_showAll.Count() == 0)
            {
                List<Model.Unidade> populate = new List<Model.Unidade>()
                    {
                        new Model.Unidade(){name="KG", visible = true},
                        new Model.Unidade(){name="PÇ", visible = true},
                        new Model.Unidade(){name="RL", visible = false},
                        new Model.Unidade(){name="MTS", visible = true},
                        new Model.Unidade(){name="MT", visible = false},
                        new Model.Unidade(){name="PAR", visible = true},
                        new Model.Unidade(){name="PCT", visible = false},
                        new Model.Unidade(){name="PC", visible = false},
                        new Model.Unidade(){name="CONJ", visible = true},
                        new Model.Unidade(){name="GL", visible = true},
                        new Model.Unidade(){name="UNI.", visible = false},
                        new Model.Unidade(){name="CX", visible = true},
                        new Model.Unidade(){name="KIT", visible = true},
                        new Model.Unidade(){name="ROLO", visible = true},
                        new Model.Unidade(){name="PACOTE", visible = true},
                        new Model.Unidade(){name="LT", visible = false},
                        new Model.Unidade(){name="LTA", visible = true},
                    };
                populate.ForEach(t => _repository.add(t));
            }
#endif
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
