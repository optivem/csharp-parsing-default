﻿using Optivem.Core.Application;
using Optivem.Core.Domain;
using Optivem.Template.Core.Application.Customers.Requests;
using Optivem.Template.Core.Application.Customers.Responses;
using Optivem.Template.Core.Domain.Customers;

namespace Optivem.Template.Core.Application.Customers.UseCases
{
    public class FindCustomerUseCase : FindAggregateUseCase<FindCustomerRequest, FindCustomerResponse, Customer, CustomerIdentity, int>
    {
        public FindCustomerUseCase(IResponseMapper responseMapper, IReadonlyRepository<Customer, CustomerIdentity> repository)
            : base(responseMapper, repository)
        {
        }

        // TODO: VC: Common factory, optional, unless reflection
        protected override CustomerIdentity GetIdentity(int id)
        {
            // TODO: VC: Do this via reflection
            return new CustomerIdentity(id);
        }
    }
}