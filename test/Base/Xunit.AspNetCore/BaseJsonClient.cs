﻿using Optivem.Common.Http;
using Optivem.Common.Serialization;
using Optivem.Infrastructure.Http.System;
using Optivem.Infrastructure.Serialization.Json.NewtonsoftJson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Test.Xunit.AspNetCore
{
    public class BaseJsonClient<TStartup> : BaseClient<TStartup> where TStartup : class
    {
        protected override IControllerClientFactory CreateControllerClientFactory()
        {
            var serializationService = CreateSerializationService();
            return new JsonControllerClientFactory(Client, serializationService);
        }

        protected virtual IJsonSerializationService CreateSerializationService()
        {
            return new JsonSerializationService();
        }   
    }
}
