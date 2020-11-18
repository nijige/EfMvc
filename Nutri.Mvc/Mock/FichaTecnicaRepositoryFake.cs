using System;
using System.Collections.Generic;
using System.Linq;
using Nutri.Mvc.Models;

namespace Nutri.Mock
{
    public class FichaTecnicaRepositoryFake
    {
        private readonly List<FichaTecnica> List;
        private FichaTecnica fichaTecnica;

        public FichaTecnicaRepositoryFake()
        {
            List = new List<FichaTecnica>();

            for (int i = 0; i < 10; i++)
            {
                fichaTecnica = new FichaTecnica();
                fichaTecnica.Id = Guid.NewGuid();
                fichaTecnica.NomePreparacao = "item" + i.ToString();
                fichaTecnica.Ingredientes = "";

                List.Add(fichaTecnica);
            }

            fichaTecnica = new FichaTecnica();
            fichaTecnica.Id = new Guid("C56A4180-65AA-42EC-A945-5FD21DEC0537");
            fichaTecnica.NomePreparacao = "Product Teste";
            fichaTecnica.Ingredientes = "";

            List.Add(fichaTecnica);
        }

        public bool Exists(string name)
        {
            var item = List.FirstOrDefault(x => x.NomePreparacao == name);
            if (item != null)
                return true;

            return false;
        }

        public void Create(FichaTecnica model)
        {
            List.Add(model);
        }


        public void Delete(Guid id)
        {
            var item = List.FirstOrDefault(x => x.Id == id);
            if (item != null)
                List.Remove(item);
        }


        public List<FichaTecnica> GetAll()
        {
            return List;
        }

        public FichaTecnica GetById(Guid id)
        {
            return List.FirstOrDefault(x => x.Id == id);
        }

        public void Update(FichaTecnica model)
        {
            var item = List.FirstOrDefault(x => x.Id == model.Id);
            if (item != null)
            {
                List.Remove(item);
                List.Add(model);
            }

        }

        public List<FichaTecnica> Search(string parametro)
        {
            var lista = List.Where(x => x.NomePreparacao.Contains(parametro) || x.Ingredientes.ToString().Contains(parametro)).ToList();
            return lista;
        }
    }
}