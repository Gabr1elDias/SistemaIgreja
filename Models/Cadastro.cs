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

        [Column("Email")]
        [Display(Name = "E-mail")]
        public string Email { get; set; } = string.Empty;

        [Column("Celular")]
        [Display(Name = "Celular")]
        public string Celular { get; set; } = string.Empty;

        [Column("DataNascimento")]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }



    }
}
