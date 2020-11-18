using System;
using System.ComponentModel.DataAnnotations;


namespace Nutri.Mvc.ViewModels
{
    public class FichaTecnica
    {


        public Guid Id { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        public string NomePreparacao { get; set; }

        [Required(ErrorMessage = "Preenchimento obrigatório")]
        public decimal? Quantidade { get; set; }
    }
}


