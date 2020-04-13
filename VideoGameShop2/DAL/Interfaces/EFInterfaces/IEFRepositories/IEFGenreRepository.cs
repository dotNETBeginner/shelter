using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFGenreRepository : IGenericRepository<Genre,int>
    {
        Task<IEnumerable<Genre>> GetAllGenres();

        Task<Genre> GetGenreById(int Id);

        Task AddGenre(Genre genre);

        Task DeleteGenre(int Id);

        Task UpdateGenre(Genre genre);
    }
}
