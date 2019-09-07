﻿using Optivem.Framework.Core.Application.Mappers;
using Optivem.Framework.Core.Application.UseCases.Base;
using Optivem.Framework.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Optivem.Framework.Core.Application
{
    public class ListAggregatesUseCase<TRepository, TRequest, TResponse, TRecordResponse, TAggregateRoot, TIdentity, TId> 
        : RepositoryUseCase<TRepository, TRequest, TResponse>
        where TRepository : IFindAllAggregatesRepository<TAggregateRoot, TIdentity>
        where TRequest : IRequest
        where TResponse : ICollectionResponse<TRecordResponse, TId>, new()
        where TRecordResponse : IResponse<TId>
        where TAggregateRoot : IAggregateRoot<TIdentity>
        where TIdentity : IIdentity<TId>
    {
        public ListAggregatesUseCase(IUseCaseMapper mapper, TRepository repository)
            : base(mapper, repository)
        {
        }

        public override async Task<TResponse> HandleAsync(TRequest request)
        {
            var aggregateRoots = await Repository.GetAsync();

            return Mapper.Map<IEnumerable<TAggregateRoot>, TResponse>(aggregateRoots);
        }
    }
}