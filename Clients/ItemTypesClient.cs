using CollectorsHelper.Frontend.Models;

namespace CollectorsHelper.Frontend.Clients
{
    public class ItemTypesClient(HttpClient httpClient)
    {
        public async Task<ItemType[]> GetItemTypesAsync() =>
            await httpClient.GetFromJsonAsync<ItemType[]>("item_types") ?? [];
    }
}
