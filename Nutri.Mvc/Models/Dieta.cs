using System;
using System.Collections.Generic;

namespace Nutri.Mvc.Models
{
  public class Dieta
  {
    public Dieta()
    {
      this.Produtos = new List<Produto>();
    }

    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "*")]
    [StringLength(30, MinimumLength = 3, ErrorMessage = "Campo inválido")]
    public string Nome { get; set; }
    
    public ICollection<Produto> Produtos { get; set; }
  }
}