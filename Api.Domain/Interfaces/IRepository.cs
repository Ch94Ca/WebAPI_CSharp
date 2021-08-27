﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<T> SelectAsync(Guid id);
        Task<bool> DeleteAsync(Guid id);
        Task<IEnumerable<T>> SelectAsync();
    }
}