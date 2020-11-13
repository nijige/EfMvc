using System;
using System.Collections.Generic;

namespace Nutri.Models
{
    public class FichaTecnica
    {

        public Guid Id { get; set; }

        public string NomePreparacao { get; set; }

        public string Ingredientes { get; set; }

        public string Descricao { get; set; }

        public string Image { get; set; }

        public int Quantidade { get; set; }

        public string ModoPreparo { get; set; }

        public int Rendimento { get; set; }

        public int CustoTotal { get; set; }

        public int CustoPorcao { get; set; }

        public DateTimeOffset? DataConclusão { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }




    }


}
