using System.Text;
using Vishal_OneStream.Contracts;

namespace Vishal_OneStream.Services
{
  public class WebApiService : IWebApiService
  {
    private readonly HttpClient _httpClient;

    public WebApiService(HttpClient httpClient)
    {
      _httpClient = httpClient;
    }

    public async Task<string> GetWebApi1Data()
    {
      HttpResponseMessage response = await _httpClient.GetAsync($"");
      response.EnsureSuccessStatusCode();
      return "test";
    }

    public async Task<string> PostWebApi1Data(string json)
    {
      using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(json),
  Encoding.UTF8, "application/json");

      using HttpResponseMessage response = await _httpClient.PostAsync("", jsonContent, CancellationToken.None);
      response.EnsureSuccessStatusCode();
      return await response.Content.ReadAsStringAsync();

    }
  }
}
