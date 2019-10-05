﻿using Optivem.Framework.Core.Common.Mapping;
using Optivem.Framework.Infrastructure.EntityFrameworkCore;
using Optivem.Template.Core.Domain.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Template.Infrastructure.EntityFrameworkCore.Products.Handler
{
    public class RemoveProductsHandler : RemoveAggregateRootHandler<DatabaseContext, Product, ProductIdentity, ProductRecord, int>
    {
        public RemoveProductsHandler(DatabaseContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
