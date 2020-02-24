using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameShop.Interfaces
{
    public interface IDevelopers
    {
        int AddDeveloper(Developers developer);

        IEnumerable<Developers> GetAllDevelopers();

        Developers GetDeveloperById(int Id_Dev);

        int UpdateDeveloper(Developers developer);

        int DeleteDeveloper(int Id_Dev);
    }
}
