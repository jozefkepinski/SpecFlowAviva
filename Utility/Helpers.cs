using Microsoft.Extensions.Configuration;

public static class ConfigurationHelper
{
    public static IConfigurationRoot GetConfiguration()
    {
        string fileName = "settings.json";
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory() + "\\..\\..\\..\\Settings\\")
            .AddJsonFile(fileName, optional: false, reloadOnChange: true);

        return builder.Build();
    }
}