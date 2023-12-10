using System.ComponentModel.DataAnnotations;

namespace WebListaEsperaMentoria.Models
{
    public class PacienteModel
    {
        public int Id { get; set; }


        
        public string Nome { get; set; }


        
        public string Email { get; set; }


       
        public string Telefone { get; set; }


        
        public DateTime DataCadastro { get; set; }


        public string? Observacao { get; set; }


        public bool Finalizado { get; set; } = false;

        public UsuarioModel Usuario { get; set; }

        public int? UsuarioId { get; set; }
    }
}
