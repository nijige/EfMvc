using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nutri.Models
{
    public class FichaTecnicaViewModels
    {

        public Guid Id { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        public string NomePreparacao { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        public decimal? Rendimento { get; set; }

    }


}