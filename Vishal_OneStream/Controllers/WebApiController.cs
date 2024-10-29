using Microsoft.AspNetCore.Mvc;
using Vishal_OneStream.Contracts;
using Vishal_OneStream.Services;

namespace Vishal_OneStream.Controllers
{
  [ApiController]
  [Route("api/[controller]/")]
  public class WebApiController : ControllerBase
  {
    private readonly ILogger<WebApiController> _logger;
    private readonly IWebApiService _webApiControllerService;
    private readonly IWebApiTwoService _webApiTwoControllerService;

    public WebApiController(ILogger<WebApiController> logger, IWebApiService webApiControllerService, IWebApiTwoService webApiTwoControllerService)
    {
      _logger = logger;
      _webApiControllerService = webApiControllerService;
      _webApiTwoControllerService = webApiTwoControllerService;
    }

    [HttpGet]
    [Route("getwebapi1data")]
    public async Task<string>  GetWebApi1()
    {
      var result = await _webApiControllerService.GetWebApi1Data();
      return result;
    }

    [HttpPost]
    [Route("postwebapi1data")]
    public async Task<string> PostWebApi1([FromBody] string json)
    {
      var result = await _webApiControllerService.PostWebApi1Data(json);
      return result;
    }

    [HttpGet]
    [Route("getwebapi2data")]
    public async Task<string> GetWebApi2()
    {
      var result = await _webApiTwoControllerService.GetWebApi2Data();
      return result;
    }

    [HttpPost]
    [Route("postwebapi2data")]
    public async Task<string> PostWebApi2([FromBody] string json)
    {
      var result = await _webApiTwoControllerService.PostWebApi2Data(json);
      return result;
    }
  }
}
