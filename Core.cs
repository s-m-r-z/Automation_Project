using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Project
{
    public class Core
    {

        public static IWebDriver driver;


        public Core()
        {
            driver = new ChromeDriver();

            driver.Url = "http://slate.nu.edu.pk/portal";

            driver.Manage().Window.Maximize();
        }


        public void sendkeys(By by, string input)
        {
            try
            {
                driver.FindElement(by).SendKeys(input);
            }
            catch(Exception e)
            {
                Console.WriteLine("The current element is untracebale \n"+e);
            }
        }

        public void clickbutton(By by)
        {
            try
            {
                driver.FindElement(by).Click();
            }
            catch(Exception e)
            {
                Console.WriteLine("The given element is not found\n"+e);
            }
        }

        public void navigate(string location)
        {
            driver.Navigate().GoToUrl(location);
        }


        public static void close()
        {
            driver.Close();
        }


        public void directlogin()
        {
            driver.FindElement(By.Id("eid")).SendKeys("k180210");
            driver.FindElement(By.Id("pw")).SendKeys("mehdiraza");
            driver.FindElement(By.Id("submit")).Click();
        }
    }
}
