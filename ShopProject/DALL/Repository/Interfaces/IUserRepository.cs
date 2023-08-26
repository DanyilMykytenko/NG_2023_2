﻿using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        IQueryable GetUserByOrderId(int id);
        IQueryable GetUserByLogin(string login);
    }
}
