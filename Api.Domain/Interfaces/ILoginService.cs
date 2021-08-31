using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Dtos;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto user);
    }
}
