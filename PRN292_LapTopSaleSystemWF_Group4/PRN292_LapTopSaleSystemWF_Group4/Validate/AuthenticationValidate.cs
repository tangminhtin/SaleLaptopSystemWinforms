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
            /*int score = 0;

            if (password.Length < 1)
                return "Blank";
            if (password.Length < 4)
                return "VeryWeak";

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

            switch (score)
            {
                case 1:
                    return "VeryWeak";
                    break;
                case 2:
                    return "Weak";
                    break;
                case 3:
                    return "Medium";
                    break;
                case 4:
                    return "Strong";
                    break;
                case 5:
                    return "VeryStrong";
                    break;
                default:
                    return "";
                    
            }*/

            
            string patdi = @"\d+"; //match digits
            string patupp = @"[A-Z]+"; //match upper cases
            string patlow = @"[a-z]+"; //match lower cases
            string patsym = @"[`~!@$%^&\\-\\+*/_=,;.':|\\(\\)\\[\\]\\{\\}]+"; //match symbols

            Match id = Regex.Match(password, patdi);
            Match upp = Regex.Match(password, patupp);
            Match low = Regex.Match(password, patlow);
            Match sym = Regex.Match(password, patsym);

            if(id.Success && upp.Success && low.Success && sym.Success)
            {
                return "VeryStrong";
            }
            else
            {
                return "";
            }
           
        }
    }
}
