using HSA_Estoque.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSA_Estoque.Presenter
{
    public class Usuario : Model.IUsuarioModel
    {
        List<Model.Usuario> _showAll;
        IUsuarioRepository _repository;

        public Usuario()
        {
            _repository = new Repository.Usuario();
            _showAll= (List<Model.Usuario>)_repository.getAll();
        }

        public int add()
        {
            Model.Usuario modelUsuario = new Model.Usuario();
            modelUsuario.nome = this.nome;
            modelUsuario.isAdmin = true;
            return _repository.add(modelUsuario);
        }

        public void update()
        {
            Model.Usuario modelUsuario = new Model.Usuario();
            modelUsuario.id = this.id;
            modelUsuario.nome = this.nome;
            modelUsuario.isAdmin = this.isAdmin;
            _repository.update(modelUsuario);
        }

        public List<Model.Usuario> showAll
        {
            get{
                _showAll = (List<Model.Usuario>)_repository.getAll();
                return _showAll;
            }
        }
        public int id { get; set; }
        public string nome { get; set; }
        public bool isAdmin { get; set; }
    }
}
