using DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces.IEFServices
{
    public interface IEFGenreService
    {
        Task AddGenre(Genre genre);

        Task UpdateGenre(Genre genre);

        Task DeleteGenre(Genre genre);

        Task<Genre> GetGenreById(int Id);

        Task<IEnumerable<Genre>> GetAllGenres();
    }
}
