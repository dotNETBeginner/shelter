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
    public class EFUserService : IEFUserService
    {
        IEFUnitOfWork _efUnitOfWork;
        private readonly IMapper _mapper;

        public EFUserService(IEFUnitOfWork efunitOfWork, IMapper mapper)
        {
            _efUnitOfWork = efunitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsers()
        {
            var x = await _efUnitOfWork.EFUserRepository.GetAll();
            List<UserDTO> res = new List<UserDTO>();
            foreach (var i in x)
                res.Add(_mapper.Map<User, UserDTO>(i));

            return res;
        }

        public async Task<UserDTO> GetUserById(int Id)
        {
            var x = await _efUnitOfWork.EFUserRepository.Get(Id);
            UserDTO res = _mapper.Map<User, UserDTO>(x);

            return res;
        }

        public async Task AddUser(UserDTO user)
        {
            var x = _mapper.Map<UserDTO, User>(user);
            await _efUnitOfWork.EFUserRepository.Add(x);
        }

        public async Task DeleteUser(int Id)
        { await _efUnitOfWork.EFUserRepository.Delete(Id); }

        public async Task UpdateUser(UserDTO user)
        {
            var x = _mapper.Map<UserDTO, User>(user);
            await _efUnitOfWork.EFUserRepository.Update(x);
        }
    }
}