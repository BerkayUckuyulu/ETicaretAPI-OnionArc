﻿using ETİcaretAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETİcaretAPI.Application.Repositories
{
    public interface IWriteRepository<T>:IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> datas);
        bool RemoveRange(List<T> datas);
        bool Remove(T model);
        Task<bool> RemoveAsync(string id);

        bool Update(T model);
        Task<int> SaveAsync();
    }
}
