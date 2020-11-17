using System;
using System.Collections.Generic;

namespace Nutri.Mvc.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string TipoPreparacao { get; set; }

        public IEnumerable<FichaTecnica> FichaTecnicas { get; set; }

    }
}