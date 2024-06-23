using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PhoneBookData;
using PhoneBookModels;

namespace PhoneBookBusinessService
{
    public class CUP
    {
        VS val = new VS();
        Functions f = new Functions();

        public bool CreateEntry(Contacts contacts)
        {
            bool rs = false;

            if (val.VibeCheck(contacts.c_name))
            {
                rs = f.AddContact(contacts) > 0;
            }
            return rs;
        }

        public bool CreateEntry(string name, string num, string email, string add)
        {
            Contacts c = new Contacts { c_name = name, c_num = num, c_email = email, c_add = add};

            return CreateEntry(c);
        }

        public bool UpdateEntry(Contacts contacts)
        {
            bool rs = false;

            if (val.VibeCheck(contacts.c_name))
            {
                rs = f.AddContact(contacts) > 0;
            }
            return rs;
        }

        public bool UpdateEntry(string name, string num, string email, string add)
        {
            Contacts c = new Contacts { c_name = name, c_num = num, c_email = email, c_add = add };

            return UpdateEntry(c);
        }

        public bool DeleteEntry(Contacts contacts)
        {
            bool rs = false;

            if (val.VibeCheck(contacts.c_name))
            {
                rs = f.AddContact(contacts) > 0;
            }
            return rs;
        }

      
    }
}
