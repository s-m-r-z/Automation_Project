using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation_Project
{
    public class AccountPage:Core
    {
        By account = By.XPath("//*[@id='toolMenu']/ul/li[9]/a");
        By submit = By.Id("eventSubmit_doModify");
        By pass = By.Id("user_pwcur");
        By confirm_pass = By.Id("user_pw");
        By verify_pass = By.Id("user_pw0");
        By save = By.Id("eventSubmit_doSave");




       public string password_old
        {
            get;
            set;
        }
       public string password_new
        {
            get;
            set;
        }

        public string password_confirm
        {
            get;
            set;
        }

        public void modify()
        {
            directlogin(); 
            clickbutton(account);
            clickbutton(submit);
            sendkeys(pass, password_old);
            sendkeys(confirm_pass, password_new);
            sendkeys(verify_pass, password_confirm);
            clickbutton(save);
            Thread.Sleep(1500);
            close();
        }

    }
}
