using Microsoft.AspNetCore.Mvc;
using Utils;

namespace RD_SolidPatterns.Controllers
{
  public class SettingsController : Controller
  {
    public SettingsController(ConfigurationManager config)
    {
      _config = config;
    }

    [HttpGet]
    [Route("api/settings")]
    public string Index()
    {
      return _config.GeneralSettings.Environment;
    }

    private readonly ConfigurationManager _config;
  }
}
