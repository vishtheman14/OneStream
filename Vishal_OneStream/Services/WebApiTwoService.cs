using System.Text;
using Vishal_OneStream.Contracts;

namespace Vishal_OneStream.Services
{
  public class WebApiTwoService : IWebApiTwoService
  {
    private readonly HttpClient _httpClient;

    public WebApiTwoService(HttpClient httpClient)
    {
      _httpClient = httpClient;
    }

    public async Task<string> GetWebApi2Data()
    {
      HttpResponseMessage response = await _httpClient.GetAsync($"");
      response.EnsureSuccessStatusCode();
      return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> PostWebApi2Data(string json)
    {
      using StringContent jsonContent = new(System.Text.Json.JsonSerializer.Serialize(json),
  Encoding.UTF8, "application/json");

      using HttpResponseMessage response = await _httpClient.PostAsync("", jsonContent, CancellationToken.None);
      response.EnsureSuccessStatusCode();
      return await response.Content.ReadAsStringAsync();

    }
  }
}
