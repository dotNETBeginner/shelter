using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces.EFInterfaces.IEFRepositories
{
    public interface IEFDeveloperRepository : IGenericRepository<Developer, int>
    {
    }
}
