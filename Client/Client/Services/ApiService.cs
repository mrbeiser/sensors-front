using Client.Components;
using Client.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Client.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        public ApiService(IHttpClientFactory httpClientFactory) 
        {
            _httpClient = httpClientFactory.CreateClient("SensorAPI");
        }

            public async Task<List<TemperatureData>?> GetTemperatureDataAsync()
            {
            return await
            _httpClient.GetFromJsonAsync<List<TemperatureData>>("https://my-wonderful-api-acgvdvaaa5d4b9ez.northeurope-01.azurewebsites.net/api/sensor/gettemperature");
        }
        public async Task<LockStateData?> GetLockStateDataAsync()
        {
            return await
            _httpClient.GetFromJsonAsync<LockStateData>("https://my-wonderful-api-acgvdvaaa5d4b9ez.northeurope-01.azurewebsites.net/api/sensor/getcurrentlockstate");
        }
    }
}

