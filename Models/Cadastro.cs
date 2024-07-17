using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaIgreja.Models
{
    public class Cadastro
    {
        [Column("Id")]
        [Display(Name = "Matrícula")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; } = string.Empty;
    }
}
