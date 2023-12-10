using WebListaEsperaMentoria.Models;

namespace WebListaEsperaMentoria.Interfaces
{
    public interface IUsuarioServices
    {
        public List<UsuarioModel> BuscarUsuarios();
        public UsuarioModel CriarUsuario(UsuarioModel usuario);
        public UsuarioModel DeletarUsuario(int id);
        public UsuarioModel BuscarPorId(int id);
        public UsuarioModel EditarUsuario(UsuarioModel usuario);

    }
}
