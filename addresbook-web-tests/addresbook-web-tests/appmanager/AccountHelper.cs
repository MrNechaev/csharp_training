using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            FillAccountInfo(account);
            SubmitAccountAdd();
            GoToAccountsPage();
            return this;
        }

        private void GoToAccountsPage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
        }

        public bool NoAccountsToAction()
        {
            return !IsElementPresent(By.CssSelector("img[title = Edit]"));
        }

        public AccountHelper SubmitAccountAdd()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[20]")).Click();
            return this;
        }

        public AccountHelper FillAccountInfo(AccountAddData account)
        {
            Type(By.Name("firstname"), account.Name);
            Type(By.Name("lastname"), account.LastName);
            return this;
        }

        public AccountHelper InitAccoutAdd()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public AccountHelper InitAccoutModify()
        {
            driver.FindElement(By.CssSelector("img[title=Edit]")).Click();
            return this;
        }

        public AccountHelper SubmitAccountModify()
        {
            driver.FindElement(By.CssSelector("input[value=Update]")).Click();
            accountCache = null;
            return this;

        }

        public AccountHelper SubmitAccountRemove()
        {
            driver.FindElement(By.CssSelector("input[value=Delete]")).Click();
            accountCache = null;
            return this;
        }

        //Удаление третьей запипи
        public AccountHelper SelectAccount()
        {
            driver.FindElement(By.Name("selected[]")).Click();
            return this;
        }

        public AccountHelper Modify(AccountAddData newAccountData, AccountAddData account)
        { 
            if (NoAccountsToAction())
            {
                AddAccount(account);
            }
            InitAccoutModify();
            FillAccountInfo(newAccountData);
            SubmitAccountModify();
            return this;
        }

        public AccountHelper RemoveFromEditPage()
        {
            InitAccoutModify();
            SubmitAccountRemove();
            return this;
        }

        public AccountHelper RemoveFromMainPage()
        {
            SelectAccount();
            SubmitAccountRemove();
            return this;
        }

        private List<AccountAddData> accountCache = null;
         


        public List<AccountAddData> GetAccountList()
        {
            if (accountCache == null)
            {
                List<AccountAddData> accounts = new List<AccountAddData>();
                manager.Navigator.OpenHomePage();
                ICollection<IWebElement> elements = driver.FindElements(By.Name("entry"));
                foreach (IWebElement element in elements)
                {
                    accounts.Add(new AccountAddData(element.FindElement(By.CssSelector("td:nth-child(3)")).Text, element.FindElement(By.CssSelector("td:nth-child(2)")).Text));
                }
            }
            
            return accountCache;
        }
    }
}
