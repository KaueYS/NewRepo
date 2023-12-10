using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using WebListaEsperaMentoria.Infra;
using WebListaEsperaMentoria.Interfaces;
using WebListaEsperaMentoria.Models;

namespace WebListaEsperaMentoria.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly AppDbContext _context;

        public UsuarioServices(AppDbContext context)
        {
            _context = context;
        }

        public List<UsuarioModel> BuscarUsuarios()
        {
            return _context.USUARIOS.ToList();
        }

        public UsuarioModel BuscarPorId(int id)
        {
            var usuario = _context.USUARIOS.FirstOrDefault(us => us.Id == id);
            if (usuario == null)
            {
                throw new Exception("Usuario nao encontrado");
            }
            return usuario;
        }

        public UsuarioModel CriarUsuario(UsuarioModel usuario)
        {
            _context.USUARIOS.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }

        public UsuarioModel DeletarUsuario(int id)
        {
            var usuario = _context.USUARIOS.FirstOrDefault(us => us.Id == id);
            if (usuario != null)
            {
                _context.USUARIOS.Remove(usuario);
                _context.SaveChanges();
                return usuario;
            }
            throw new Exception("Usuario nao encontrado");
        }

        public UsuarioModel EditarUsuario(UsuarioModel usuario)
        {
            _context.USUARIOS.Update(usuario);
            _context.SaveChanges();
            return usuario;
        }
    }
}
