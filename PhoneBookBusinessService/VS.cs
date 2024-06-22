using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookData;
using PhoneBookModels;

namespace PhoneBookBusinessService
{
    public class VS
    {
        GetService s = new GetService();

        public bool VibeCheck(string c_name)
        {
            bool result = s.GetUser(c_name) != null;
            return result;
        }
        public bool VibeCheck(int c_num)    
        {
            bool result = s.GetUser(c_num) != null;
            return result;
        }
    }
}
