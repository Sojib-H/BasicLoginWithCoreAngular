using BasicLogin.Infrastructure;

namespace BasicLogin.ApiDictionary
{
    public class ApiUrl
    {
        public static string GetUrl
        {
            get { return ConfigOption.GetValueFromSharedSettings("ConfigurationOption:WebUrl"); }
        }

        public static string GetAllEmployeeInfo
        {
            get
            {
                return GetUrl + "api/EmployeeInfo/GetAllEmployee";
            }
        }
    }
}
