using NetcompanyWebApp.Helper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetcompanyWebApp.Pages
{
    public class LoginPage : BasePage
    {
        IWebElement userName => FindElementById("username");
        IWebElement password => FindElementById("password");
        IWebElement loginButton => FindElementByXPath("//button[contains(text(), 'Login')]");


        public LoginPage(IWebDriver driver) : base(driver)
        {

       }

        public void EnterUserId(string name)
        {
            userName.SendKeys(name);
        }

        public void EnterUserPassword(string name)
        {
            password.SendKeys(name);
        }
        public void SubmitLogin()
        {
            loginButton.Click();
        }


    }
}
