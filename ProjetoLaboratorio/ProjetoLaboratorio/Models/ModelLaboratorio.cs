using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoLaboratorio.Models
{
    public class ModelLaboratorio
    {

        public int Id { get; set; }

        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "Informe o nome.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter no minimo 3 caracteres!")]
        public string Nome { get; set; }

        [Display(Name = "Quantidade de Computadores:")]
        [Required(ErrorMessage = "A sala deve ter mais de UM Computador")]
        [Range(2, 100, ErrorMessage = "A sala deve ter mais de UM computadores.")]
        public int qtdComputadores { get; set; }

        [Display(Name = "Quantidade de Alunos:")]
        [Range(4, 100, ErrorMessage = "A sala deve ter no minimo 4 alunos.")]
        [Required(ErrorMessage = "A sala deve ter no minimo 4 alunos.")]
        public int qtdAlunos { get; set; }

        [Display(Name = "Projetor:")]
        public bool Projetor { get; set; }

        [Display(Name = "Software 1:")]
        [Required(ErrorMessage = "Informe o Software 1.")]
        public string Software1 { get; set; }

        [Display(Name = "Software 2:")]
        [Required(ErrorMessage = "Informe o Software 2.")]
        public string Software2 { get; set; }

        [Display(Name = "Software 3:")]
        [Required(ErrorMessage = "Informe o Software 3.")]
        public string Software3 { get; set; }

        [Display(Name = "Sistema Operacional:")]
        [Required(ErrorMessage = "Informe o Sistema Operacional.")]
        public string SistemaOperacional { get; set; }
    }
}