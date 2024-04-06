using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class AccountHelper : HelperBase
    {
        public AccountHelper(ApplicationManager manager) : base(manager)
        {
            this.manager = manager;
        }

        public AccountHelper AddAccount(AccountAddData account)
        {
            InitAccoutAdd();
            FillNewAccountInfo(account);
            SubmitAccountAdd();
            return this;
        }

        public AccountHelper SubmitAccountAdd()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[20]")).Click();
            return this;
        }

        public AccountHelper FillNewAccountInfo(AccountAddData account)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(account.Name);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(account.LastName);
            return this;
        }

        public AccountHelper InitAccoutAdd()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
    }
}
