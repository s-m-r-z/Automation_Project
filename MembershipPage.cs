using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Project
{
    public class MembershipPage:Core
    {

        By checkbox3= By.XPath("//*[@id='check-3']");
        By checkbox2 = By.XPath("//*[@id='check-1']");
        By membership = By.XPath("//*[@id='toolMenu']/ul/li[3]/a");
        By s = By.Id("searchFilter1");
        By s_button = By.Id("btnSearch_searchFilter1");
        By enrollement = By.XPath("//*[@id='col1']/div/div/ul/li[2]/span");
        By joinable = By.XPath("//*[@id='col1']/div/div/ul/li[3]/span");
        public void tick()
        {
            directlogin();
            clickbutton(membership);
            clickbutton(checkbox3);
            close();
        }
        public void untick()
        {
            directlogin();
            clickbutton(membership);
            clickbutton(checkbox3);
            clickbutton(checkbox2);
            clickbutton(checkbox3);
            clickbutton(checkbox2);
            
        }

        public string sr
        {
            get;
            set;
        }

        public void search()
        {
            directlogin();
            clickbutton(membership);
            sendkeys(s, sr);
            clickbutton(s_button);
        }

        public void tabs()
        {
            directlogin();
            clickbutton(membership);
            clickbutton(enrollement);
            clickbutton(joinable);
            
        }

    }
}
