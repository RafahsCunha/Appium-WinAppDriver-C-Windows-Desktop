using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using Xunit;


namespace TestProject1
{
    public class Relogio_Alarme
    {
        [Fact]
        [Obsolete] // Correção
        public void TesteExecRelogioeAlarme()
        {
            WindowsDriver<WindowsElement> sessionCalculator;

            AppiumOptions appOptions = new AppiumOptions();

            appOptions.AddAdditionalCapability("app", "Microsoft.WindowsAlarms_8wekyb3d8bbwe!App"); //ID do Alarme

            sessionCalculator = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);

            Assert.Equal("Relógio", sessionCalculator.Title);

        }
    }
}
