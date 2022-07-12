using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserManager
    {
        public bool AddUser(string ad, string mail, string telefon)
        {
            if (ad.Length < 4)
                return false;

            if (!Regex.IsMatch(telefon, "[0-9]"))
                return false;

            if (!mail.Contains("@"))
                return false;

            return true;
        }
    }
}
