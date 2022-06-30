using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Project
{
    class OverviewPage:Core
    {

        By alert = By.XPath("//*[@id='Mrphs-bullhorn']");
        By view = By.XPath("//*[@id='mastLogin']/div[2]/a/i");
        By profile = By.XPath("//*[@id='loginUser']/a");
        By lout=By.XPath("//*[@id='loginLink1']");
        By cross = By.XPath("//*[@id='otherSitesMenu']/li[3]/a/span[2]");


        public void tabs()
        {
            directlogin();
            clickbutton(alert);
            clickbutton(view);
            clickbutton(cross);
        
            //close();
        }

        public void logout()
        {
            directlogin();
            clickbutton(profile);
            clickbutton(lout);
        }

}
}
