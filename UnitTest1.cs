using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Chrome;
using System.Configuration;

namespace Automation_Project
{


    [TestClass]
    public class UnitTest1
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        [TestMethod]
        [DataRow("k180210", "mehdiraza")]
        public void ValidUser_TC001(string id, string password)
        {
            log.Info("Running Test Case Login with valid credentials");
            WelcomePage w = new WelcomePage();
            w.userid = id;
            w.password = password;
            w.Login();
            log.Info("Valid User Test Case Successfully Run");
        }

        [TestMethod]
        [DataRow("k190123", "abcdefg")]
        public void InvalidUser_TC002(string id, string password)
        {

            log.Info("Running Test Case Login with Invalid credentials");
            WelcomePage w = new WelcomePage();
            w.userid = id;
            w.password = password;
            w.Login();
            log.Info("InValid User Test Case Successfully Run");

        }


        [TestMethod]

        public void tabscheck_TC003()
        {
            log.Info("Tabs Changing Test Case on WelcomePage Running");

            WelcomePage w = new WelcomePage();
            w.tabs();
            log.Info("Test Case Successfully Run");

        }
        [TestMethod]
        public void tick_TC004()
        {

            log.Info("Membership Test Case Tick selected option running");

            MembershipPage m = new MembershipPage();
            m.tick();

            log.Info("Membership Test Case Successfully Run");

        }

        [TestMethod]

        public void untick_TC005()
        {

            log.Info("Membership Test Case UnTick selected option running");
            MembershipPage m = new MembershipPage();
            m.untick();
            log.Info("Membership Test Case Successfully Run");

        }


        [TestMethod]
        [DataRow("CS")]
        public void search_TC006(string s)
        {
            log.Info("Membership Test Case search from the available list running");
            MembershipPage m = new MembershipPage();
            m.sr = s;
            m.search();
            log.Info("Membership Test Case Successfully Run");
        }


        [TestMethod]
        public void tabs_membership_TC007()
        {

            log.Info("Memebership Test to switch tabs Successfully Run");
            MembershipPage m = new MembershipPage();
            m.tabs();

            log.Info("Memebership Test Case Successfully Run");
        }

        [TestMethod]

        public void resource_tab_TC008()
        {


            log.Info("ResourcePage Test Case to switch tabs Successfully Run");
            ResourcesPage r = new ResourcesPage();
            r.tab_switch();

            log.Info("ResourcePage Test Case Successfully Run");
        }

        [TestMethod]
        [DataRow("CS")]
        public void worksite_search_TC009(string input)
        {

            log.Info("WorksitePageSetupPage Case search from the available list running");
            WorksiteSetupPage w = new WorksiteSetupPage();
            w.sr = input;

            w.search();

            log.Info("WorksitePageSetupPage Test Case Successfully Run");
        }

        [TestMethod]
        public void worksite_view_TC010()
        {

            log.Info("WorksitePageSetupPage Test Case to dropdown the view and term options runing");
            WorksiteSetupPage w = new WorksiteSetupPage();

            w.view();


            log.Info("WorksitePageSetupPage Test Case Successfully Run");

        }

        [TestMethod]
        [DataRow("mehdiraz","mehdi","mehdi")]
        public void account_modify_negative_TC011(string cur, string n, string verify)
        {

            log.Info("AccountPage test case to change password runing");
            AccountPage a = new AccountPage();

            a.password_old = cur;
            a.password_new = n;
            a.password_confirm = verify;

            a.modify();

            log.Info("AccountPage Test Case Successfully Run");
        }

        [TestMethod]

        public void overview_tabs_TC012()
        {

            log.Info("OverviewPage switch tab test case runing");
            OverviewPage o = new OverviewPage();

            o.tabs();
            log.Info("OverviewPage Test Case Successfully Run");


        }

        [TestMethod]

        public void logout_TC013()
        {
            log.Info("OverviewPage LogOut test case runing");
            OverviewPage o = new OverviewPage();
            o.logout();

            log.Info("OverviewPage LogOut Test Case Successfully Run");

        }
        [TestMethod]
        [DataRow(@"C:\Users\mehdi\OneDrive\Pictures\dd.jpg")]
        public void profile_picupload_TC014(string img)
        {

            log.Info("ProfilePage pictureupload test case runing");
            ProfilePage p = new ProfilePage();
            p.image_loc = img;
            p.upload();
            log.Info("ProfilePage Test Case Successfully Run");


        }
        [TestMethod]
        public void profile_tabs_TC015()
        {

            log.Info("ProfilePage tabs switching test case runing");
            ProfilePage p = new ProfilePage();
            p.tabs();
            log.Info("ProfilePage Test Case Successfully Run");
        }
       

    }

    
}
