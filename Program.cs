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

            //Inicializa os parametros de busca
            string webSite = "https://e2etec.com.br";
            string searchPattern = "//div[@id='panel-w5f11b62f8fe0c-0-0-0']/div[1]/div[1]/p[1]";
            
            //Inicializa o recurso selenium
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(webSite);

            //Recupera via XPath a informação solicitada
            IWebElement telefoneEmail = driver.FindElement(By.XPath(searchPattern));
            Thread.Sleep(2000);

            //Prepara os dados para criar o arquivo txt
            string fileText = telefoneEmail.Text;
            string filePath = @"c:\temp";
            string fileName = "e2etec_csharp.txt";

            System.IO.Directory.CreateDirectory(filePath);

            // Cria o arquivo e insere o texto
            File.WriteAllText(Path.Combine(filePath, fileName), fileText);

            //Encerra o recurso selenium
            driver.Quit();
        }
    }
}