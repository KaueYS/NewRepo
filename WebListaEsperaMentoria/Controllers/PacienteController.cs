using Microsoft.AspNetCore.Mvc;
using WebListaEsperaMentoria.Interfaces;
using WebListaEsperaMentoria.Models;

namespace WebListaEsperaMentoria.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPacienteServices _services;

        public PacienteController(IPacienteServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            var pacientes = _services.BuscarPacientes();
            return View(pacientes);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(PacienteModel paciente)
        {
            _services.CriarPaciente(paciente);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id) 
        {
            var pacientes = _services.BuscarPorId(id);
            return View(pacientes);
        }

        [HttpPost]
        public IActionResult Edit(PacienteModel paciente)
        {
            _services.EditarPaciente(paciente);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _services.DeletarPaciente(id);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteConfirmed(int id)
        {
            var paciente = _services.BuscarPorId(id);
            return View(paciente);
        }


    }
}
