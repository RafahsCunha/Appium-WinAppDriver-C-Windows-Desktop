using Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine.ClientProtocol;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Diagnostics;
using Xunit;
using Assert = Xunit.Assert;

namespace TestProject1
{
    public class Relogio_Alarme
    {
        static WindowsDriver<WindowsElement> sessionCalculator;

        [ClassInitialize]
        public static void PreparaParaTestarAlarme(TestExecutionContext testContex)
        {
            Debug.WriteLine("Classe de Inilialização");

            AppiumOptions appOptions = new AppiumOptions();

            appOptions.AddAdditionalCapability("app", "Microsoft.WindowsAlarms_8wekyb3d8bbwe!App"); //ID do Alarme

            sessionCalculator = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);
        }

        [ClassCleanup]
        public static void LimpezaDepoisdeTodosOsAlermesdeTestes()
        {
            Debug.WriteLine("Classe de Limpeza");
            if (sessionCalculator != null)
            {
                sessionCalculator.Quit();
            }
        }
        [TestInitialize]
        public void AntesTeste()
        {
            Debug.WriteLine("Antes");

        }
        [ClassCleanup]
        public void DepoisTeste()
        {
            Debug.WriteLine("Depois");

        }
        [TestMethod]
        public void OutroTeste()
        {
            Debug.WriteLine("Outro");

        }

        [Fact]
        [Obsolete] // Correção
        public void TesteExecRelogioeAlarme()
        {

            Assert.Equal("Relógio", sessionCalculator.Title);

        }
    }
}
