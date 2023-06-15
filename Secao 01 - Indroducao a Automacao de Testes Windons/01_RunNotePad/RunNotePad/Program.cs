using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunNotePad
{
    class Program
    {
        //MANIPULANDO BLOCO DE NOTAS E SALVANDO PRINT DA TELA - OBS PRIMEIRO RODAR WinAppDriver.exe
        static void Main(string[] args)
        {
            WindowsDriver<WindowsElement> notePadSession; //Objeto WindwosDriver com o tipo genérico WindowsElement 
            AppiumOptions desiredCapabilities = new AppiumOptions();
            desiredCapabilities.AddAdditionalCapability("app", @"C:\Windows\system32\notepad.exe");

            notePadSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), desiredCapabilities);//Porta onde o WinAppDriver está rodando, :4723

            if (notePadSession == null)
            {
                Console.WriteLine("O App não foi iniciado!! ");
                return;
            }

            Console.WriteLine($"Titulo da aplicação: {notePadSession.Title}");

            notePadSession.Manage().Window.Maximize();

            var screenShot = notePadSession.GetScreenshot();
            screenShot.SaveAsFile($".\\Screenshot{DateTime.Now.ToString("ddMMyyyyhhmmss")}.png",
                OpenQA.Selenium.ScreenshotImageFormat.Png);

            notePadSession.Quit();



        }
    }
}