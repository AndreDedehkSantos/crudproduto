﻿using CrudProduto.Bussiness;
using CrudProduto.Dal;
using CrudProduto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudProduto.Controllers.Fachada
{
    public class UsuarioFachada
    {
        private readonly CrudProdutoContext _context;

        public UsuarioFachada(CrudProdutoContext context)
        {
            _context = context;
        }

        public void Salvar(Usuario usuario)
        {
            UsuarioDal uDal = new UsuarioDal(_context);
            uDal.salvar(usuario);
        }

        public ICollection<string> Validarusuario(string nome, string senha1, string senha2)
        {
            ValidarDadosUsuario vUsuario = new ValidarDadosUsuario();
            return vUsuario.processar(nome, senha1, senha2);
        }
    }
}