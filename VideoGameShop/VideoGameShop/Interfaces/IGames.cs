using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameShop.Interfaces
{
    public interface IGames
    {
        int AddGame(Games game);

        IEnumerable<Games> GetAllGames();

        Games GetGameById(int Id_Game);

        int UpdateGame(Games game);

        int DeleteGame(int Id_Game);
    }
}
