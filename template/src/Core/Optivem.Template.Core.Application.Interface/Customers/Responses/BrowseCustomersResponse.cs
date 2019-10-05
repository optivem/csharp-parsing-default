﻿using System.Collections.Generic;
using Optivem.Framework.Core.Common;

namespace Optivem.Template.Core.Application.Customers.Responses
{
    public class BrowseCustomersResponse : ICollectionResponse<BrowseCustomersRecordResponse, int>
    {
        public List<BrowseCustomersRecordResponse> Records { get; set; }

        public int TotalRecords { get; set; }
    }

    public class BrowseCustomersRecordResponse : IResponse<int>
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}