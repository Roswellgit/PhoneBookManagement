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
            bool result = s.GetName(c_name) != null;
            return result;
        }
        public bool VibeDeck(string c_num)    
        {
            bool result = s.GetNum(c_num) != null;
            return result;
        }
    }
}
