using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace Automation_Project
{
    public class WorksiteSetupPage:Core
    {

        By worksite = By.XPath("//*[@id='toolMenu']/ul/li[7]/a");
        By s = By.Id("searchFilter1");
        By button = By.Id("btnSearch_searchFilter1");
        By v = By.Id("view-top");
        By term = By.Id("termview-top");
        By apply=By.XPath("//*[@id='col1']/div/div/div/div[1]/div[1]/form/div[2]/input[2]");



       public string sr
        {
            get;
            set;
        }

        public void search()
        {
            directlogin();

            clickbutton(worksite);
            sendkeys(s, sr);
            clickbutton(button);
            Thread.Sleep(2200);
            close();

        }

        public void view()
        {
            directlogin();
            clickbutton(worksite);
            var selectdrpdown = new SelectElement(driver.FindElement(v));
            selectdrpdown.SelectByIndex(1);

            var s = new SelectElement(driver.FindElement(term));
            s.SelectByIndex(2);

            clickbutton(apply);


        }


    }
}
