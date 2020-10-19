using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using _24NettbutikkSharp.Entities;
using _24NettbutikkSharp.Services.Product;
using Abp.Extensions;
using Abp.Json;

namespace _24NettbutikkSharp.Services.Order
{
    public class OrderService : NettbutikkService
    {
        /// <summary>
        /// Creates a new instance of <see cref="OrderService" />.
        /// </summary>
        /// <param name="storeUrl">store url</param>
        /// <param name="apiKey">App Secret Api Key</param>
        public OrderService(string storeUrl, string apiKey) : base(storeUrl, apiKey)
        {
        }

        /// <summary>
        /// Retrieve a list of orders
        /// </summary>
        /// <param name="limit">The number of elements which shall be returned</param>
        /// <param name="offset">The offset at which the returning array starts</param>
        /// <param name="from">	The earliest requested modified date (Unix timestamp)</param>
        /// <param name="to">The latest requested modified date (Unix timestamp)</param>
        /// <returns></returns>
        public virtual async Task<OrdersQueryResponse> QueryOrdersAsync(int limit, int offset, string from = null, string to = null)
        {
            var requestBuilder = new StringBuilder();
            requestBuilder.Append($"{limit}/{offset}");

            if (!from.IsNullOrEmpty()) requestBuilder.Append($"/{from}");
            if (!to.IsNullOrEmpty()) requestBuilder.Append($"/{to}");

            var req = PrepareOrderRequest($"orders/{requestBuilder.ToString()}");
            return await ExecuteGetAsync<OrdersQueryResponse>(req);
        }

        /// <summary>
        /// Retrieve a list of orders
        /// </summary>
        /// <returns></returns>
        public virtual async Task<CustomersQueryResponse> CustomersQueryResponse(string customerId = null)
        {
            var requestBuilder = new StringBuilder();
            requestBuilder.Append("customers");
            if (!string.IsNullOrEmpty(customerId)) requestBuilder.Append($"/{customerId}");

            var req = PrepareOrderRequest(requestBuilder.ToString());
            return await ExecuteGetAsync<CustomersQueryResponse>(req);
        }

        /// <summary>
        /// Retrieve one single order
        /// </summary>
        /// <param name="orderId">order id</param>
        /// <returns></returns>
        public virtual async Task<OrdersQueryResponse> GetOrder(string orderId)
        {
            var req = PrepareOrderRequest($"orders/{orderId}");
            return await ExecuteGetAsync<OrdersQueryResponse>(req);
        }

        /// <summary>
        /// Update specific fields in an order line
        /// </summary>
        /// <param name="orderNumber">order number</param>
        /// <param name="orderLineId">order line item id</param>
        /// <param name="request">Line item to update</param>
        /// <returns></returns>
        public virtual async Task UpdateOrderLine(string orderNumber, string orderLineId, LineItemUpdateRequest request)
        {
            var req = PrepareOrderRequest($"orders/{orderNumber}/lines/{orderLineId}");
            await ExecutePostAsync<object>(request.ToJsonString(), true, req);
        }

        /// <summary>
        /// Update specific fields in an order
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <param name="request">order status update request</param>
        /// <returns></returns>
        public virtual async Task UpdateOrderStatus(string orderNumber, OrderUpdateStatusRequest request)
        {
            var req = PrepareOrderRequest($"orders/{orderNumber}");
            await ExecutePostAsync<object>(request.ToJsonString(), true, req);
        }
    }
}
