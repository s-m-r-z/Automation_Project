using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Automation_Project
{
    public class ProfilePage:Core
    {

        public string image_loc
        {
            get;
            set;
        }

        By profile = By.XPath("/html/body/div[3]/div[9]/div[1]/div/nav/ul/li[2]/a/div[1]");
        By pic = By.XPath("/html/body/div[3]/div[9]/div[2]/main/div/div/ul/li[3]/span/a");
        By img = By.XPath("/html/body/div[3]/div[9]/div[2]/main/div/div/div/div/div/div/div/form[2]/section/div/div[1]/input");
        By tab1 = By.XPath("/html/body/div[3]/div[9]/div[2]/main/div/div/div/div/div/div/div/form[2]/section/div/input");
        By tab2 = By.XPath("/html/body/div[3]/div[9]/div[2]/main/div/div/ul/li[4]/span/a");
        By tab3 = By.XPath("/html/body/div[3]/div[9]/div[2]/main/div/div/ul/li[5]/span/a");
        By tab4 = By.XPath("/html/body/div[3]/div[9]/div[2]/main/div/div/div/div/div/div/form/input[2]");
        By btn = By.XPath("//*[@id='id38']");

        public void upload()
        {
            directlogin();
            clickbutton(profile);
            clickbutton(pic);
            sendkeys(img, image_loc);
            clickbutton(btn);
            Thread.Sleep(22000);
            close();
        }

        public void tabs()
        {
            directlogin();
            clickbutton(profile);
            clickbutton(tab2);
            clickbutton(tab3);
            clickbutton(tab4);
            close();
        }



    }
}
