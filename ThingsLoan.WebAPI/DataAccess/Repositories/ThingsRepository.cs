﻿using ThingsLoan.WebAPI.DataAccess.Context;
using ThingsLoan.WebAPI.DataAccess.RepoInterfaces;
using ThingsLoan.WebAPI.Entities;

namespace ThingsLoan.WebAPI.DataAccess.Repositories
{
    public class ThingRepository : GenericRepository<Things>, IThingRepository
    {
        public ThingRepository(ThingsContext context) : base(context)
        {

        }
    }
}
