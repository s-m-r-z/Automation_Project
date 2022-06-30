using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Project
{
    public class WelcomePage:Core
    {

        By id = By.Id("eid");
        By pass = By.Id("pw");
        By button = By.Id("submit");
        By about = By.XPath(" //*[@id='toolMenu']/ul/li[2]/a");
        By features = By.XPath("//*[@id='toolMenu']/ul/li[3]/a");
        By sitebrowser = By.XPath("//*[@id='toolMenu']/ul/li[4]/a");
        By training = By.XPath("//*[@id='toolMenu']/ul/li[5]/a");
        By acknowledgement=By.XPath("//*[@id='toolMenu']/ul/li[6]/a");
        By help = By.XPath("//*[@id='toolMenu']/ul/li[7]/a");


        public string userid
        {
            get;
            set;
        }

        public string password
        {
            get;
            set;
        }

        public void Login()
        {
            
            sendkeys(id, userid);
            sendkeys(pass, password);
            clickbutton(button);
            close();
        }

        public void tabs()
        {
            clickbutton(about);
            clickbutton(features);
            clickbutton(sitebrowser);
            clickbutton(training);
            clickbutton(acknowledgement);
            close();
        }

    }
}
