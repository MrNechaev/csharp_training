using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        public IWebDriver driver;
        protected StringBuilder verificationErrors;
        protected string baseURL;
        protected bool acceptNextAlert = true;


        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected AccountHelper accountHelper;


        public ApplicationManager()
        {

            driver = new ChromeDriver("C:/Users/igorn/chromedriver.exe");
            baseURL = "http://localhost/addressbook";
            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            accountHelper = new AccountHelper(this);

        }

        public IWebDriver Driver 
        { 
            get { return driver; }
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper Auth
        {
            get { return loginHelper; }
        }

        public NavigationHelper Navigator
        {
            get { return navigationHelper; }
        }

        public GroupHelper Groups 
        {
            get { return groupHelper; }
        }
        
        public AccountHelper AccHelp
        {
            get { return accountHelper; }
        }

    }
}
