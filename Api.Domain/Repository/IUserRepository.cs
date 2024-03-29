﻿using System.Threading.Tasks;
using System.Transactions;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Repository
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserEntity> FindByLogin(string email);
    }
}
