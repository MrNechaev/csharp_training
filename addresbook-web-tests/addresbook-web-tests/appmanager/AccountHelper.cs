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
            return this;
        }

        public AccountHelper SubmitAccountAdd()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[20]")).Click();
            return this;
        }

        public AccountHelper FillAccountInfo(AccountAddData account)
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

        public AccountHelper InitAccoutModify()
        {
            driver.FindElement(By.CssSelector("tbody:last-child tr:last-child img[title=Edit]")).Click();
            return this;
        }

        public AccountHelper SubmitAccountModify()
        {
            driver.FindElement(By.CssSelector("input[value=Update]")).Click();
            return this;

        }

        public AccountHelper SubmitAccountRemove()
        {
            driver.FindElement(By.CssSelector("input[value=Delete]")).Click();
            return this;
        }

        //Удаление третьей запипи
        public AccountHelper SelectAccount()
        {
            driver.FindElement(By.XPath("//table[@id='maintable']/tbody/tr[4]/td/input")).Click();
            return this;
        }

        public AccountHelper Modify(AccountAddData newAccountData)
        {
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
    }
}
