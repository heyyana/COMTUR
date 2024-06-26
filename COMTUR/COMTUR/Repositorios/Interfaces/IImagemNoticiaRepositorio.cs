﻿using COMTUR.Models;

namespace COMTUR.Repositorios.Interfaces
{
	public interface IImagemNoticiaRepositorio
	{
		Task<List<ImagemNoticiaModel>> BuscarImagemNoticia();
		Task<ImagemNoticiaModel> GetByIdNoticia(int id);
		Task<ImagemNoticiaModel> GetByIdUsuario(int id);
		Task<ImagemNoticiaModel> BuscarPorId(int id);
		Task<ImagemNoticiaModel> Adicionar(ImagemNoticiaModel imagemNoticia);
		Task<ImagemNoticiaModel> Atualizar(ImagemNoticiaModel imagemNoticia, int id);
		Task<bool> Apagar(int id);

    }
}
