using FruitVegBasketMaui.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ProductsService : BaseApiService
    {
        public ProductsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
        public async Task<IEnumerable<ProductDto>> GetPopularProductsAsync()
        {
            var response = await HttpClient.GetAsync("/popular-products");
            return await HandleApiResponseAsync(response, Enumerable.Empty<ProductDto>());
        } 
        public async Task<IEnumerable<ProductDto>> GetCategoryProductsAsync(short categoryId)
        {
            var response = await HttpClient.GetAsync($"/categories/{categoryId}/products");
            return await HandleApiResponseAsync(response, Enumerable.Empty<ProductDto>());
        }
    }
}
