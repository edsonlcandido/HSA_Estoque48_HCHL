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
#if DEBUG
            _showAll = (List<Model.Tipo>)_repository.findAll();
            if (_showAll.Count() ==0)
            {
                List<Model.Tipo> populate = new List<Model.Tipo>()
                    {
                        new Model.Tipo(){name="INSUMO SOLDA", visible = true},
                        new Model.Tipo(){name="LIMPEZA", visible = true},
                        new Model.Tipo(){name="FABRICA", visible = true},
                        new Model.Tipo(){name="SOLDA", visible = true},
                        new Model.Tipo(){name="LOGISTICA", visible = true},
                        new Model.Tipo(){name="CALDEIRARIA", visible = true},
                        new Model.Tipo(){name="FERRAMENTAS", visible = true},
                        new Model.Tipo(){name="ESCRITÓRIO", visible = true},
                        new Model.Tipo(){name="EPI", visible = true},
                        new Model.Tipo(){name="FERRAMENTA", visible = true},
                        new Model.Tipo(){name="EMBALAGEM", visible = true},
                        new Model.Tipo(){name="PINTURA", visible = true},
                        new Model.Tipo(){name="CALDERARIA", visible = true},
                        new Model.Tipo(){name="CAMINHÃO", visible = true},
                        new Model.Tipo(){name="JATO", visible = true}
                    };
                populate.ForEach(t => _repository.add(t));
            }
 #endif
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
