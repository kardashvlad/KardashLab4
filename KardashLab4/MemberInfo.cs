using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KardashLab4
{
    internal class MemberInfo
    {
        public MemberInfo(string pIP, string age, string role)
        {
            PIP = pIP;
            if (int.TryParse(age + "", out int number))
            {
                Age = number;
            }
            else
            {
                throw new Exception("Поле віку повинно мати лише число");
            }
            Role = role;
        }
        public MemberInfo()
        {
            PIP = "";
            Age = 0;
            Role = "";
        }

        public string PIP { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
    }
}
