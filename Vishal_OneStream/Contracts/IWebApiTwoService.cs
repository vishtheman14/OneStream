namespace Vishal_OneStream.Contracts
{
  public interface IWebApiTwoService
  {
    Task<string> GetWebApi2Data();
    Task<string> PostWebApi2Data(string json);
  }
}
