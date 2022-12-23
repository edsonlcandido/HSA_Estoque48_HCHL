using System.Collections.Generic;

namespace HSA_Estoque.Repository
{
    public interface IUsuarioRepository
    {
        int add(Model.Usuario modelUsuario);
        void update(Model.Usuario modelUsuario);
        IEnumerable<Model.Usuario> getAll();
    }
}