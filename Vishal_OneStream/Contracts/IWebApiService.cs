namespace Vishal_OneStream.Contracts
{
  public interface IWebApiService
  {
    Task<string> GetWebApi1Data();
    Task<string> PostWebApi1Data(string json);
  }
}
