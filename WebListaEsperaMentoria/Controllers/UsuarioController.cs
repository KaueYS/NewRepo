using Microsoft.AspNetCore.Mvc;
using WebListaEsperaMentoria.Interfaces;
using WebListaEsperaMentoria.Models;

namespace WebListaEsperaMentoria.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioServices _services;

        public UsuarioController(IUsuarioServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            var usuario = _services.BuscarUsuarios();
            return View(usuario);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UsuarioModel usuario)
        {
            _services.CriarUsuario(usuario);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _services.DeletarUsuario(id);
            return RedirectToAction("Index");

        }

        public IActionResult DeleteConfirmed(int id)
        {
            var usuario = _services.BuscarPorId(id);
            return View(usuario);

        }

        public IActionResult Edit(int id)
        {
            var usuario = _services.BuscarPorId(id);
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Edit(UsuarioModel usuario)
        {
            _services.EditarUsuario(usuario);
            return RedirectToAction("Index");
        }



    }
}
