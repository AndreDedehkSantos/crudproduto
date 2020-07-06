﻿using System.ComponentModel.DataAnnotations;

namespace CrudProduto.Models
{
	public class FichaTecnica : EntidadeDominio
	{
		[Display(Name = "*Descrição")]
		public string descricao { get; set; }
		[Display(Name = "*Componente Básico")]
		public string componenteBasico { get; set; }
		[Display(Name = "*Componente primário")]
		public string componentePrimario { get; set; }
		[Display(Name = "*Componente Secundário")]
		public string componenteSecundario { get; set; }
		[Display(Name = "*Categoria")]
		public string categoria { get; set; }
		[Display(Name = "observações")]
		public string observacoes { get; set; }
		[Display(Name = "*Sub-Categoria")]
		public string subCategoria { get; set; }

        public FichaTecnica()
		{

		}

		public FichaTecnica(string descricao, string componenteBasico, string componentePrimario, string componenteSecundario, string categoria, string subCategoria)
		{
			this.descricao = descricao;
			this.componenteBasico = componenteBasico;
			this.componentePrimario = componentePrimario;
			this.componenteSecundario = componenteSecundario;
			this.categoria = categoria;
			this.subCategoria = subCategoria;
		}
	}

}
