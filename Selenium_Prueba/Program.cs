using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Prueba
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www3.animeflv.net/";
            //var html = driver.PageSource;
            //Console.WriteLine(html);
            //File.WriteAllText("anime.html",html);

            //INavigation navigate = driver.Navigate();
            //navigate.GoToUrl("https://www.google.com");
            //navigate.Back();


            //IWebElement login = driver.FindElement(By.CssSelector("body > div.Wrapper > header > div > div > div > div.AFixed > nav > div.Login > label > span"));
            //login.Click();

            //IWebElement correo = driver.FindElement(By.Name("email"));
            //correo.SendKeys("correoejemplo@gmail.com");
            //IWebElement contraseña = driver.FindElement(By.Name("password"));
            //contraseña.SendKeys("password");

            //IWebElement button = driver.FindElement(By.CssSelector("body > div.Wrapper > header > div > div > div > div.AFixed > nav > div.Login > div > form > button"));
            //button.Click();

            var imgs = driver.FindElements(By.ClassName("Image"));
            List<string> links = new List<string>();

            foreach (var img_ in imgs)
            {
                if (img_.GetAttribute("class").Equals("Image"))
                {
                    links.Add(img_.FindElement(By.TagName("img")).GetAttribute("src"));
                    // Console.WriteLine(img_.FindElement(By.TagName("img")).GetAttribute("src"));
                }
            }

            foreach (var link in links)
            {
                Console.WriteLine(link);
            }


            //driver.Close();


        }
    }
}
