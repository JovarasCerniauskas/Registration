using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Registration
{
    internal class RegistrationPage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "input-firstname")]
        private IWebElement firstnameTextbox;

        [FindsBy(How = How.Id, Using = "input-lastname")]
        private IWebElement lastnameTextbox;

        [FindsBy(How = How.Id, Using = "input-email")]
        private IWebElement emailTextbox;

        [FindsBy(How = How.Id, Using = "input-telephone")]
        private IWebElement telephoneTextbox;

        [FindsBy(How = How.Id, Using = "input-password")]
        private IWebElement passwordTextbox;

        [FindsBy(How = How.Id, Using = "input-confirm")]
        private IWebElement confirmPasswordTextbox;

        [FindsBy(How = How.Name, Using = "agree")]
        private IWebElement privacyPolicyCheckbox;

        [FindsBy(How = How.XPath, Using = "//input[@value='Continue']")]
        private IWebElement continueButton;

        public RegistrationPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void Register(string firstName, string lastName, string email, string telephoneNumber, string password, string confirmPassword)
        {
            firstnameTextbox.SendKeys(firstName);
            lastnameTextbox.SendKeys(lastName);
            emailTextbox.SendKeys(email);
            telephoneTextbox.SendKeys(telephoneNumber);
            passwordTextbox.SendKeys(password);
            confirmPasswordTextbox.SendKeys(confirmPassword);
            privacyPolicyCheckbox.Click();
            continueButton.Click();

        }
    }
}
