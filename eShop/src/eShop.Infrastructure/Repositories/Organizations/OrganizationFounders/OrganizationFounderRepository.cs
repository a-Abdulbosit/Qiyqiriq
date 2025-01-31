﻿using eShop.Domain.Enitities.Organizations;
using eShop.Infrastructure.Context;
using eShop.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Repositories.Organizations.OrganizationFounders
{
    public class OrganizationFounderRepository : BaseRepository<OrganizationFounder>, IOrganizationFounderRepository
    {
        public OrganizationFounderRepository(eShopDbContext context) : base(context)
        {
        }
    }
}
