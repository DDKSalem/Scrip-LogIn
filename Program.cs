using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Scrip_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();

            // escribir user name
            IWebElement input = driver.FindElement(By.Id("user-name"));
            input.SendKeys("standard_user");

            //esperate un rato
            Thread.Sleep(3000);

            // escribir password
            IWebElement pass = driver.FindElement(By.Id("password"));
            pass.SendKeys("secret_sauce");

            //

            IWebElement btn = driver.FindElement(By.Id("login-button"));
            btn.Click();


            //Esperate otro rato
            Thread.Sleep(3000);

            //entra al cuarto objeto de la lista.
            IWebElement prod = driver.FindElement(By.Id("item_5_title_link"));
            prod.Click();

            //esperate otro rato
            Thread.Sleep(3000);

            //Agrega el objeto al carro
            IWebElement buy = driver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
            buy.Click();

            //esperate otro rato
            Thread.Sleep(3000);

            //Revisar el carro de compras
            IWebElement shop = driver.FindElement(By.Id("shopping_cart_container"));
            shop.Click();

            // dale un momento
            Thread.Sleep(3000);

            //Paga
            IWebElement checkout = driver.FindElement(By.Id("checkout"));
            checkout.Click();


        }
    }
}
