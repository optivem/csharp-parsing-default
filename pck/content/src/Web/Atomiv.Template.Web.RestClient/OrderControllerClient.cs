﻿using Atomiv.Core.Common.Http;
using Atomiv.Core.Common.Serialization;
using Atomiv.Template.Core.Application.Commands.Orders;
using Atomiv.Template.Core.Application.Queries.Orders;
using Atomiv.Template.Web.RestClient.Interface;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Atomiv.Template.Web.RestClient
{
    public class OrderControllerClient : BaseJsonControllerClient, IOrderControllerClient
    {
        public OrderControllerClient(HttpClient httpClient, IJsonSerializer jsonSerializer)
            : base(httpClient, jsonSerializer, "api/orders")
        {
        }

        #region Commands

        public Task<ObjectClientResponse<CancelOrderCommandResponse>> CancelOrderAsync(CancelOrderCommand request, HeaderData header)
        {
            var id = request.Id;
            return Client.PostAsync<CancelOrderCommandResponse>($"{id}/cancel", GetHeaders(header));
        }

        public Task<ObjectClientResponse<CreateOrderCommandResponse>> CreateOrderAsync(CreateOrderCommand request, HeaderData header)
        {
            return Client.PostAsync<CreateOrderCommand, CreateOrderCommandResponse>(request, GetHeaders(header));
        }

        public Task<ObjectClientResponse<EditOrderCommandResponse>> EditOrderAsync(EditOrderCommand request, HeaderData header)
        {
            return Client.PutByIdAsync<Guid, EditOrderCommand, EditOrderCommandResponse>(request.Id, request, GetHeaders(header));
        }

        public Task<ObjectClientResponse<SubmitOrderCommandResponse>> SubmitOrderAsync(SubmitOrderCommand request, HeaderData header)
        {
            var id = request.Id;
            return Client.PostAsync<SubmitOrderCommandResponse>($"{id}/submit", GetHeaders(header));
        }

        #endregion

        #region Queries

        public Task<ObjectClientResponse<BrowseOrdersQueryResponse>> BrowseOrdersAsync(BrowseOrdersQuery request, HeaderData header)
        {
            throw new NotImplementedException();
        }

        public Task<ObjectClientResponse<FilterOrdersQueryResponse>> FilterOrdersAsync(FilterOrdersQuery request, HeaderData header)
        {
            return Client.GetAsync<FilterOrdersQueryResponse>("filter", GetHeaders(header));
        }

        public Task<ObjectClientResponse<ViewOrderQueryResponse>> ViewOrderAsync(ViewOrderQuery request, HeaderData header)
        {
            var id = request.Id;
            return Client.GetByIdAsync<Guid, ViewOrderQueryResponse>(id, GetHeaders(header));
        }

        #endregion
    }
}
