using ApiConciertosAWS.Data;
using ApiConciertosAWS.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace ApiConciertosAWS.Repositories
{
    public class RepositoryConciertos
    {
        private ConciertosContext context;

        public RepositoryConciertos(ConciertosContext context) 
        {
            this.context = context;
        }

        public async Task<List<Evento>> GetEventosAsync()
        {
            return await this.context.Eventos.ToListAsync();
        }

        public async Task<List<Categoria>> GetCategoriasAsync()
        {
            return await this.context.Categorias.ToListAsync();
        }

        public async Task<List<Evento>> GetEventosCategoriaAsync(int idcategoria)
        {
            List<Evento> eventos = await this.context.Eventos.Where(x => x.IdCategoria == idcategoria).ToListAsync();
            return eventos;
        }



    }
}
