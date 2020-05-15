﻿using AutoMapper;
using Optivem.Atomiv.Template.Core.Application.Commands.Orders;
using Optivem.Atomiv.Template.Core.Domain.Orders;

namespace Optivem.Atomiv.Template.Infrastructure.Commands.Mapping.Orders
{
    public class ArchiveOrderCommandResponseProfile : Profile
    {
        public ArchiveOrderCommandResponseProfile()
        {
            CreateMap<Order, ArchiveOrderCommandResponse>();
        }
    }
}
