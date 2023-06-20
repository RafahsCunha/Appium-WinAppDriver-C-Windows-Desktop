using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcRunnerAppiumV4
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsDriver<WindowsElement> sessionCalculator;

            AppiumOptions appOptions = new AppiumOptions();

            appOptions.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App"); //ID da calculadora encontrado em propriedades WinAppDriverUiRecorder XML Nodes

            sessionCalculator = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"),appOptions);

           // Operação da calculadora

            var botaoDois = sessionCalculator.FindElementByName("Dois");//Botão 2
            botaoDois.Click();

           // var mais = sessionCalculator.FindElementByClassName("Mais");
            var mais = sessionCalculator.FindElementByAccessibilityId("plusButton");

            mais.Click();

            botaoDois.Click();

            var igual = sessionCalculator.FindElementByAccessibilityId("equalButton");

            igual.Click();

            var resultadotxt = sessionCalculator.FindElementByAccessibilityId("CalculatorResults");

            Console.WriteLine($"Valor mostrado no calculo: {resultadotxt.Text}");

            if (resultadotxt.Text.EndsWith("4"))
            {
                Console.WriteLine("O resultado está correto! ");
            }
            else
            {
                Console.WriteLine("O resultado está Incorreto!!! ");
            }
        }
    }
}
