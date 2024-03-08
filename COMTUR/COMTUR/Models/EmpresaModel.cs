﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace COMTUR.Models
{
	[Table("empresa")]
	public class EmpresaModel
	{
		[Key]
		[Column("empresaid")]
		public int Id { get; set; }

		[Column("nome")]
		public string Nome { get; set; }

		[Column("cnpj")]
		public long CNPJ { get; set; }

		[Column("endereco")]
		public string Endereco { get; set; }

		[Column("imagem")]
		public string? Imagem { get; set; }

		[Column("legendaImagem")]
		public string LegendaImagem { get; set; }

		[Column("descricao")]
		public string Descricao { get; set; }

        [BindNever]
        [NotMapped]
        public UsuarioModel? UsuarioModel { get; set; }

		[Column("usuarioid")]
		[ForeignKey("usuarioid")]
		public int IdUsuario { get; set; }

	}
}







