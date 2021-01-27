using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BDD
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        IWebDriver driver = new ChromeDriver(@"C:\driver\chromedriver_win32");
        [Given(@"i am navigate to""(.*)""")]
        public void GivenIAmNavigateTo(string p0)

        {
            driver.Url = p0;
            
        }
        
        [Given(@"i enter the below information")]
        public void GivenIEnterTheBelowInformation(Table table)
        {
            var tableData = table.CreateDynamicSet();
            foreach (var item in tableData)
            {
              
                driver.FindElement(By.XPath("//input[@placeholder='First Name']")).SendKeys((string)item.FirstName);
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//input[@placeholder='First Name']")).Clear();
                driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).SendKeys((string)item.LastName);
                Thread.Sleep(3000);
                driver.FindElement(By.XPath("//input[@placeholder='Last Name']")).Clear();
                driver.FindElement(By.TagName("textarea")).SendKeys((string)item.Address);
                Thread.Sleep(3000);
                driver.FindElement(By.TagName("textarea")).Clear();
                driver.FindElement(By.XPath("//input[@type='email']")).SendKeys((string)item.EmailAddress);
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//input[@type='email']")).Clear();
                driver.FindElement(By.XPath("//input[@type='tel']")).SendKeys((string)item.Phone);
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//input[@type='tel']")).Clear();
                Thread.Sleep(2000); Console.WriteLine("abcd");
                
                Thread.Sleep(2000);
            }
        }
    }
}
