using System.Configuration;

namespace POMGit
{
    public class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string SignInPageUrl = ConfigurationManager.AppSettings["signinpage_url"];
        public static readonly string SignUpPageUrl = ConfigurationManager.AppSettings["signuppage_url"];
    }
}
