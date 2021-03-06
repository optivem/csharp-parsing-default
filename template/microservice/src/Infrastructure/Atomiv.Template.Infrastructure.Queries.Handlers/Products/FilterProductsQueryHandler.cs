﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Atomiv.Template.Core.Application.Queries.Products;
using Atomiv.Template.Infrastructure.Domain.Persistence.Common;
using Atomiv.Template.Infrastructure.Domain.Persistence.Records;

namespace Atomiv.Template.Infrastructure.Queries.Handlers.Products
{
    public class FilterProductsQueryHandler : QueryHandler<FilterProductsQuery, FilterProductsQueryResponse>
    {
        public FilterProductsQueryHandler(DatabaseContext context) : base(context)
        {
        }

        public override async Task<FilterProductsQueryResponse> HandleAsync(FilterProductsQuery query)
        {
            var productRecords = await Context.Products.AsNoTracking()
                .OrderBy(e => e.ProductCode)
                .ToListAsync();

            var resultRecords = productRecords.Select(GetIdNameResult).ToList();
            var totalRecords = await Context.Products.LongCountAsync();

            return new FilterProductsQueryResponse
            {
                Records = resultRecords,
                TotalRecords = totalRecords,
            };
        }

        private static ListProductsRecordQueryResponse GetIdNameResult(ProductRecord productRecord)
        {
            var name = $"{productRecord.ProductCode} - {productRecord.ProductName}";

            return new ListProductsRecordQueryResponse
            {
                Id = productRecord.Id,
                Name = name,
            };
        }
    }
}