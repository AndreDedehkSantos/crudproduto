﻿using CrudProduto.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudProduto.Dal
{
	public class ProdutoDal : IDal
	{
		private readonly CrudProdutoContext _context;

		public ProdutoDal(CrudProdutoContext context)
		{
			_context = context;
		}

        public void Alterar(EntidadeDominio entidadeDominio)
        {
            
        }

        public void Inativar(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<EntidadeDominio> Listar()
        {
            ICollection<EntidadeDominio> listaEnt = new List<EntidadeDominio>();
            var lista = _context.Produto.ToList();
            foreach(Produto item in lista)
            {
                listaEnt.Add((EntidadeDominio)item);
            }
            return listaEnt;
        }

        public void Salvar(EntidadeDominio entidadeDominio)
		{
            Produto produto = (Produto)entidadeDominio;
			_context.Add(produto);
			_context.SaveChanges();
		}
    }
}
