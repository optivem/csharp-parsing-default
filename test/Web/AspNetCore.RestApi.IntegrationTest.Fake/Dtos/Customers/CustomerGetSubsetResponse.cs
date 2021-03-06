﻿using System;
using System.Collections.Generic;

namespace Atomiv.Web.AspNetCore.RestApi.IntegrationTest.Fake.Dtos.Customers
{
    public class CustomerGetSubsetResponse
    {
        public List<CustomerGetSubsetRecordResponse> Records { get; set; }

        public int TotalRecords { get; set; }
    }

    public class CustomerGetSubsetRecordResponse
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime ModifiedDateTime { get; set; }

        public int CardCount { get; set; }
    }
}