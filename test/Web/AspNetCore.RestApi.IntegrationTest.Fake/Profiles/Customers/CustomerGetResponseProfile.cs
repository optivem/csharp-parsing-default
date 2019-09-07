﻿using AutoMapper;
using Optivem.Framework.Infrastructure.AutoMapper;
using Optivem.Framework.Web.AspNetCore.RestApi.IntegrationTest.Fake.Entities;
using Optivem.Framework.Web.AspNetCore.RestApi.IntegrationTest.Fake.Models;

namespace Optivem.Framework.Web.AspNetCore.RestApi.IntegrationTest.Fake.Profiles.Customers
{
    public class CustomerGetResponseProfile : Profile
    {
        public CustomerGetResponseProfile()
        {
            CreateMap<Customer, CustomerGetResponse>();
        }
    }
}