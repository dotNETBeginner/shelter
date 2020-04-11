using BLL.Interfaces.IEFServices;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.EF_Services
{
    public class EFGenreService : IEFGenreService
    {
        IEFUnitOfWork _efUnitOfWork;

        public EFGenreService(IEFUnitOfWork efunitOfWork)
        { _efUnitOfWork = efunitOfWork; }

        public async Task<IEnumerable<Genre>> GetAllGenres()
        { return await _efUnitOfWork.EFGenreRepository.GetAll(); }

        public async Task<Genre> GetGenreById(int Id)
        { return await _efUnitOfWork.EFGenreRepository.Get(Id); }

        public async Task AddGenre(Genre genre)
        { await _efUnitOfWork.EFGenreRepository.Add(genre); }

        public async Task DeleteGenre(Genre genre)
        { await _efUnitOfWork.EFGenreRepository.Delete(genre); }

        public async Task UpdateGenre(Genre genre)
        { await _efUnitOfWork.EFGenreRepository.Update(genre); }
    }
}
