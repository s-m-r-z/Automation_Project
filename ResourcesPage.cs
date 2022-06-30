using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Project
{
    public class ResourcesPage:Core
    {

        By resources = By.XPath("//*[@id='toolMenu']/ul/li[5]/a");
        By s_resources = By.XPath("//*[@id='contentMenu']/li[1]/span");
        By transfer=By.XPath("//*[@id='contentMenu']/li[2]/span");
        By options = By.XPath("//*[@id='contentMenu']/li[3]/span");
        By quota = By.XPath("//*[@id='contentMenu']/li[4]/span");
        By trash= By.XPath("//*[@id='contentMenu']/li[5]/span");


        public void tab_switch()
        {
            directlogin();
            clickbutton(resources);
            clickbutton(transfer);
            clickbutton(options);
            clickbutton(quota);
            clickbutton(trash);
        }
    }
}
