using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.FuntionalTestFramework
{
    public static class Pages
    {
       public static RegistrationPage RegistrationPage
        {
            get { return new RegistrationPage(); }
        }
    }

    public  class RegistrationPage
    {
        static string url = "http://localhost:5555/Account/Register";
        static string PageTitle = "Home Page - CRM";
        static Random random = new Random();

        public  void GoTo()
        {
            Browser.Init();
            Browser.GoTo(url);

        }
        public  void RegisterUser(string user)
        {
            int n = random.Next(1, 100000);

            Browser.FillElement("Email", "email" + n + "@gmail.com");
            Browser.FillElement("Password", "asdf1234ASDF!@#$");
            Browser.FillElement("ConfirmPassword", "asdf1234ASDF!@#$");
            Browser.ExecuteElement("register");
        }

        public  bool IsAt()
        {
            return Browser.Title == PageTitle;

        }
    }
}
