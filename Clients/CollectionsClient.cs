using CollectorsHelper.Frontend.Models;

namespace CollectorsHelper.Frontend.Clients
{
    public class CollectionsClient(HttpClient httpClient)
    {
        public async Task<CollectibleItemSummary[]> GetCollectionAsync() =>
            await httpClient.GetFromJsonAsync<CollectibleItemSummary[]>("collectible_items") ?? [];

        public async Task AddItemAsync(CollectibleItemDetail item) =>
            await httpClient.PostAsJsonAsync("collectible_items", item);

        public async Task<CollectibleItemDetail> GetItemAsync(int id) =>
            await httpClient.GetFromJsonAsync<CollectibleItemDetail>($"collectible_items/{id}") ?? throw new Exception("Could not find the item");

        public async Task UpdateItemAsync(CollectibleItemDetail updatedItem) =>
            await httpClient.PutAsJsonAsync($"collectible_items/{updatedItem.Id}", updatedItem);

        public async Task DeleteItemAsync(int id) =>
            await httpClient.DeleteAsync($"collectible_items/{id}");

    }
}
