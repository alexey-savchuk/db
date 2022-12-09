using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library.Utils
{
    internal class Validation
    {

        public static bool IsValidPassword(string password)
        {
            string regex = @"[a-zA-Z]{5,}[a-zA-Z0-9]*";
            return Regex.Match(password, regex).Success;
        }

        public static bool IsValidEmail(string email)
        {
            string regex = @"[a-zA-Z]+(\.[a-zA-Z]+)*[0-9]*(@)[a-zA-Z]+(\.[a-zA-Z]+)+";
            return Regex.Match(email, regex).Success;
        }

        public static bool IsValidName(string name)
        {
            string regex = @"[a-zA-Zа-яА-Я]+";
            return Regex.Match(name, regex).Success;
        }

        public static bool IsValidYear(string year)
        {
            string regex = @"(1|2)[0-9]{3}";
            return Regex.Match(year, regex).Success;
        }
    }
}
