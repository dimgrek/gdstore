﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GDStore.DAL.Interface.Domain;

namespace GDStore.DAL.Interface.Services
{
    public interface ISuitRepository : ISQLRepository<Suit>
    {
        Task<List<Suit>> GetAllByCustomerId(Guid customerId);
    }
}