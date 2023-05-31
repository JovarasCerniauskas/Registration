using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Registration
{
    internal class RegistrationTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
          
        public void RegisterAccount()
        {
            RegistrationPage regPage = new RegistrationPage(driver);
            driver.Navigate().GoToUrl("https://op.akademijait.vtmc.lt/index.php?route=account/register");
            regPage.Register("karolis", "klizas", "karolis.klizas4@mailinator.com", "+37000000", "Password123!", "Password123!");
            Assert.True(driver.PageSource.Contains("Your Account Has Been Created!"));
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
