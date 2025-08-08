using Microsoft.Extensions.Configuration;

namespace SampleConsoleApp1
{
    internal class ex26ReadingConfig
    {
        public static IConfigurationRoot AppConfig { get; private set; }

        static void Main(string[] args)
        {
            var config =new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())//set base path to current direcdtory
                .AddJsonFile("appsettings.json",optional:false,reloadOnChange:true)//Add json file
                .Build();//Build the configuration

            AppConfig = config;//store the configuaration in static property for later use
            var appName = config["AppSettings:appName"];
            //var title = config["AppSettings.title"];
            Console.WriteLine($"______{appName.ToUpper()}_____________");

            //bind the the configuration to class
            var appSet=new AppSettings();
            config.GetSection("AppSettings").Bind(appSet);
            Console.WriteLine(appSet.Title);
            Console.ReadKey();
        }
        //we can also bind the the configuration to class.. using Microsoft.Configuration.Binder(widely used approach to read the configuarion settings
        class AppSettings
        {
            public string Name = "MY APP";
            public string Title = "My app Title";
        }
    }
}
