using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaSecao02
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsDriver<WindowsElement> filmesTvs;
            AppiumOptions appOptions = new AppiumOptions();

            appOptions.AddAdditionalCapability("app", "Microsoft.ZuneVideo_8wekyb3d8bbwe!Microsoft.ZuneVideo");

            filmesTvs = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), appOptions);
        }
    }
}
