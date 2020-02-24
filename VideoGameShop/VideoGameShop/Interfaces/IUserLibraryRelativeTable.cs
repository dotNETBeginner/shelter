using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameShop.Interfaces
{
    public interface IUserLibraryRelativeTable
    {
        int AddPurchase(UserLibraryRelativeTable purchase);

        IEnumerable<UserLibraryRelativeTable> GetAllPurchase();

        UserLibraryRelativeTable GetPurchaseById(int Id_Purchase);

        int DeletePurchase(int Id_Purchase);
    }
}
