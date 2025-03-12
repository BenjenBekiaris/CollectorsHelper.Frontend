using CollectorsHelper.Frontend.Models;

namespace CollectorsHelper.Frontend.Clients
{
    public class CountriesClient(HttpClient httpClient)
    {
        public async Task<Country[]> GetCountriesAsync() =>
            await httpClient.GetFromJsonAsync<Country[]>("countries") ?? [];
    }
}
