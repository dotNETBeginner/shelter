using AutoMapper;
using BLL.DTO;
using BLL.Interfaces.IEFServices;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Threading.Tasks;

namespace BLL.Services.EF_Services
{
    public class EFRoleService : IEFRoleService
    {
        private readonly IEFUnitOfWork _eFUnitOfWork;
        private readonly IMapper _mapper;

        public EFRoleService(IEFUnitOfWork eFUnitOfWork, IMapper mapper)
        {
            _eFUnitOfWork = eFUnitOfWork;
            _mapper = mapper;
        }

        public async Task CreateRole(RoleDTO role)
        {
            var _role = _mapper.Map<RoleDTO, MyRole>(role);
            await _eFUnitOfWork.RoleManager.CreateAsync(_role);
        }

        public async Task AppointRole(int userId, string role)
        {
            User user = await _eFUnitOfWork.UserManager.FindByIdAsync(Convert.ToString(userId));

            await _eFUnitOfWork.UserManager.AddToRoleAsync(user, role);
        }
    }
}
