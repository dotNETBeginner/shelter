using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameShop.Interfaces
{
    public interface IGenres
    {
        int AddGenre(Genres genre);

        IEnumerable<Genres> GetAllGenres();

        Genres GetGenreById(int Id_Genre);

        int UpdateGenre(Genres genre);

        int DeleteGenre(int Id_Genre);
    }
}
