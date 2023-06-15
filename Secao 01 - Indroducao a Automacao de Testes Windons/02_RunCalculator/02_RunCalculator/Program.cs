using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunNotePad
{
    class Program
    {
        //MANIPULANDO CALCULADORA SEM EXECUTAR O WinAppDriver.exe EXPLICITAMENTE
        static void Main(string[] args)
        {
            var appiumLocalService = new AppiumServiceBuilder().UsingPort(4723).WithLogFile(new FileInfo(@"C:\Users\Rafa\Desktop\FACULDADE\Onboarding Totvs\Curso Testes Automatizados - Udemy\RunNotePad\RunNotePad\bin\Debug\TestLog.txt")).Build(); // Cria e Salva o log da execução do sistema em um arquivo .txt na pasta Debug

            appiumLocalService.Start();

            AppiumOptions ao = new AppiumOptions();

            ao.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App"); //Executa a canculadora

            WindowsDriver<WindowsElement> session = new WindowsDriver<WindowsElement>(appiumLocalService, ao);

            session.Quit();
        }

    }
}