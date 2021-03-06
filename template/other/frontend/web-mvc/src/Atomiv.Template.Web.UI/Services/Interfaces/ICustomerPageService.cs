﻿using Atomiv.Web.AspNetCore.RazorPages;
using Atomiv.Template.Web.UI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Atomiv.Template.Web.UI.Services.Interfaces
{
    public interface ICustomerPageService : IPageService
    {
        Task<IList<Customer>> ListCustomers();

        Task CreateCustomer(Customer customer);
    }
}