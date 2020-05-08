using AutoMapper;
using BLL.DTO;
using BLL.Interfaces.IEFServices;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace BLL.Services.EF_Services
{
    public class EFUserService : IEFUserService
    {
        private readonly IEFUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EFUserService(IEFUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<string> Register(UserRegisterDTO user)
        {
            if(user.Password != user.ConfirmPassword)
            { return "Пароли не совпадают!"; }

            User _user = new User { Email = user.Email, UserName = user.UserName };

            var result = await _unitOfWork.UserManager.CreateAsync(_user, user.Password);

            if(result.Succeeded)
            { return "Пользователь был успешно зарегистрирован!"; }

            else
            {
                string ErrorMessage = "";
                foreach(var error in result.Errors)
                { ErrorMessage += error.Description + "\n"; }

                return ErrorMessage;
            }

        }

        public async Task<string> Login(UserLoginDTO user)
        {
            User _user = await _unitOfWork.UserManager.FindByNameAsync(user.UserName);

            if (_user != null)
            {
                var result = await _unitOfWork.SignInManager.PasswordSignInAsync(user.UserName, user.Password, user.RememberMe, false);

                if (result.Succeeded)
                { return "Успешный вход!"; }

                else
                { return "Неверный пароль!"; }
            }
            return "Пользователь не найден!";
        }

        public async Task<string> Logout()
        {
            await _unitOfWork.SignInManager.SignOutAsync();
            return "Выход успешен!";
        }

        public async Task<string> Create(UserCreateDTO user)
        {
            User _user = new User { Email = user.Email, UserName = user.UserName };

            var result = await _unitOfWork.UserManager.CreateAsync(_user, user.Password);

            if (result.Succeeded)
            {
                await _unitOfWork.SignInManager.SignInAsync(_user, false);
                return "Пользователь Зарегистрирован!";
            }
            else
            {
                string ErrorMessage = "";
                foreach(var error in  result.Errors)
                { ErrorMessage += error.Description + "\n"; }
                return ErrorMessage;
            }
        }

        public async Task<string> Edit(UserEditDTO user)
        {
            User _user = await _unitOfWork.UserManager.FindByIdAsync(Convert.ToString(user.Id));
            
            if(_user != null)
            {
                if(user.Email != "")
                _user.Email = user.Email;
                if(user.UserName != "")
                _user.UserName = user.UserName;

                var result = await _unitOfWork.UserManager.UpdateAsync(_user);

                if(result.Succeeded)
                { return "Данные пользователя успешно изменены!"; }
                else
                {
                    string ErrorMessage = "";
                    foreach (var error in result.Errors)
                    { ErrorMessage += error.Description + "\n"; }
                    return ErrorMessage;
                }
            }
            return "Такого пользователя не существует!";
        }

        public async Task<string> Delete(int id)
        {
            User _user = await _unitOfWork.UserManager.FindByIdAsync(Convert.ToString(id));

            if(_user != null)
            {
                var result = await _unitOfWork.UserManager.DeleteAsync(_user);

                if (result.Succeeded)
                { return "Пользователь был успешно удалён!"; }
                else
                {
                    string ErrorMessage = "";
                    foreach (var error in result.Errors)
                    { ErrorMessage += error.Description + "\n"; }
                    return ErrorMessage;
                }
            }
            return "Такого пользователя не существует!";
        }

        public async Task<string> ChangePassword(UserChangePasswordDTO user)
        {
            User _user = await _unitOfWork.UserManager.FindByIdAsync(Convert.ToString(user.Id));

            if(_user != null)
            {
                IdentityResult result =
                    await _unitOfWork.UserManager.ChangePasswordAsync(_user, user.OldPassword, user.NewPassword);

                if(result.Succeeded)
                {
                    return "Пароль был успещно изменен!";
                }
                else
                {
                    string ErrorMessage = "";
                    foreach (var error in result.Errors)
                    { ErrorMessage += error.Description + "\n"; }
                    return ErrorMessage;
                }
            }
            return "Данного пользователя не существует!";
        }
    }
}
