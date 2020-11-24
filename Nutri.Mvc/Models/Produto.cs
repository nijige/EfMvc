using System;
using System.Collections.Generic;

namespace Nutri.Mvc.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Campo inválido")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "*")]
        public int Carboidrato { get; set; }

        [Required(ErrorMessage = "*")]
        public int Proteina { get; set; }

        [Required(ErrorMessage = "*")]
        public int Gordura { get; set; }

        [Required(ErrorMessage = "*")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "*")]
        public int Valor { get; set; }

        public Dieta Dieta { get; set; }
    }
}