using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NettbutikkSharp.Entities;
using Abp.Json;

namespace NettbutikkSharp.Services.Product
{
    public class ProductService : NettbutikkService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductService" />.
        /// </summary>
        /// <param name="storeUrl">store url</param>
        /// <param name="apiKey">App Secret Api Key</param>
        public ProductService(string storeUrl, string apiKey) : base(storeUrl, apiKey)
        {
        }

        /// <summary>
        /// Retrieve a list of products by executing a GET request
        /// </summary>
        /// <param name="limit">The number of elements which shall be returned</param>
        /// <param name="offset">The offset at which the returning array starts</param>
        /// <param name="flat"></param>
        /// <param name="from">The earliest requested modified date (Unix timestamp)</param>
        /// <param name="to">The latest requested modified date (Unix timestamp)</param>
        /// <returns></returns>
        public virtual async Task<ProductsQueryResponse> QueryProductsAsync(int limit, int offset, byte flat, int? from = null, int? to = null)
        {
            var requestBuilder = new StringBuilder();
            requestBuilder.Append($"{limit}/{offset}");

            if (from.HasValue) requestBuilder.Append($"/{from}");
            if (to.HasValue) requestBuilder.Append($"/{to}");

            var req = PrepareProductRequest($"products/{requestBuilder.ToString()}", flat);
            return await ExecuteGetAsync<ProductsQueryResponse>(req);
        }

        /// <summary>
        /// Retrieve one single product
        /// </summary>
        /// <returns></returns>
        public virtual async Task<ProductsQueryResponse> GetProductAsync(string productId, byte flat)
        {
            var requestBuilder = new StringBuilder();
            var req = PrepareProductRequest($"products/{productId}", flat);
            return await ExecuteGetAsync<ProductsQueryResponse>(req);
        }

        /// <summary>
        /// Update specific fields in a product. 
        /// </summary>
        /// <param name="productId">product Id</param>
        /// <param name="request">product to be updated</param>
        /// <returns>The <see cref="Entities.Product"/>.</returns>
        public virtual async Task UpdateAsync(string productId, UpdateInventoryRequest request, int flat)
        {
            var req = PrepareProductRequest($"products/{productId}", flat);
            await ExecutePostAsync<object>(request.ToJsonString(), true, req);
        }
    }
}
