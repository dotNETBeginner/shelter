using BLL.DTO;
using BLL.Interfaces.IEFServices;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL.Services.EF_Services
{
    public class EFGenreService : IEFGenreService
    {
        IEFUnitOfWork _efUnitOfWork;
        private readonly IMapper _mapper;

        public EFGenreService(IEFUnitOfWork efunitOfWork, IMapper mapper)
        {
            _efUnitOfWork = efunitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GenreDTO>> GetAllGenres()
        {
            var x = await _efUnitOfWork.EFGenreRepository.GetAll();
            List<GenreDTO> res = new List<GenreDTO>();
            foreach (var i in x)
                res.Add(_mapper.Map<Genre, GenreDTO>(i));

            return res;
        }

        public async Task<GenreDTO> GetGenreById(int Id)
        {
            var x = await _efUnitOfWork.EFGenreRepository.Get(Id);
            GenreDTO res = _mapper.Map<Genre, GenreDTO>(x);

            return res;
        }

        public async Task AddGenre(GenreDTO genre)
        {
            var x = _mapper.Map<GenreDTO, Genre>(genre);
            await _efUnitOfWork.EFGenreRepository.Add(x);
        }

        public async Task DeleteGenre(int Id)
        { await _efUnitOfWork.EFGenreRepository.Delete(Id); }

        public async Task UpdateGenre(GenreDTO genre)
        {
            var x = _mapper.Map<GenreDTO, Genre>(genre);
            await _efUnitOfWork.EFGenreRepository.Update(x);
        }
    }
}