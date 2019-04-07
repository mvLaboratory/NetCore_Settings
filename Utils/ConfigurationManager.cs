using System.IO;
using Microsoft.Extensions.Configuration;

namespace Utils
{
  public class ConfigurationManager
  {
    public ConfigurationManager()
    {
      var configurationBuilder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json");
      var configuration = configurationBuilder.Build();
      configuration.GetSection("GeneralSettings").Bind(GeneralSettings);
    }

    public AppConfig GeneralSettings { get; } = new AppConfig();
  }
}