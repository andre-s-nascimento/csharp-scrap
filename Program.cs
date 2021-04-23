using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

using System.Threading;
using System.IO;

namespace selenium
{
    class Program
    {
        static void Main(string[] args)
        {


            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("https://e2etec.com.br");

            IWebElement telefoneEmail = driver.FindElement(By.XPath("//div[@id='panel-w5f11b62f8fe0c-0-0-0']/div[1]/div[1]/p[1]"));

            //Debug.WriteLine("Recuperei" + telefoneEmail.Text);
            Thread.Sleep(2000);

            string fileText = telefoneEmail.Text;
            string filePath = @"c:\temp";
            string fileName = "e2etec_csharp.txt";

            System.IO.Directory.CreateDirectory(filePath);

            // Cria o arquivo e insere o texto
            File.WriteAllText(Path.Combine(filePath, fileName), fileText);

            driver.Quit();
        }
    }
}