using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PRN292_LapTopSaleSystemWF_Group4.Validate
{
    class AuthenticationValidate
    {
        public Boolean checkEmail(String input)
        {
            try
            {
                var format = new System.Net.Mail.MailAddress(input);
                return format.Address == input;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public String checkPassword(String password)
        {
            int score = 0;

            /*if (password.Length < 1)
                return "Blank";
            if (password.Length < 4)
                return "VeryWeak";*/

            if (password.Length >= 8)
                score++;
            if (password.Length >= 12)
                score++;
            if (Regex.Match(password, @"/\d+/", RegexOptions.ECMAScript).Success)
                score++;
            if (Regex.Match(password, @"/[a-z]/", RegexOptions.ECMAScript).Success &&
              Regex.Match(password, @"/[A-Z]/", RegexOptions.ECMAScript).Success)
                score++;
            if (Regex.Match(password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success)
                score++;

            if(score >= 1)
            {
                return "VeryWeak";
            }
            if(score >= 2)
            {
                return "Weak";
            }
            if (score >= 3)
            {
                return "Medium";
            }
            if (score >= 4)
            {
                return "Strong";
            }
            if (score >= 5)
            {
                return "VeryStrong";
            }
            return "";
        }
    }
}
