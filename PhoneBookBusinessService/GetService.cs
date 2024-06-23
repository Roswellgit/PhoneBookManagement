using PhoneBookModels;
using PhoneBookData;

namespace PhoneBookBusinessService
{
    public class GetService
    {
        public List<Contacts> GetAllUsers()
        {
            Functions functions = new Functions();
            return functions.GetUsers();
        }

        public Contacts GetName(string c_name)
        {
            Contacts fc = new Contacts();

            foreach (var cont  in GetAllUsers())
            {
                if(cont.c_name == c_name)
                {
                    fc = cont;
                }
            }
            return fc;
        }

        public Contacts GetNum(string c_num)
        {
            Contacts fc = new Contacts();

            foreach (var cont in GetAllUsers())
            {
                if (cont.c_num == c_num)
                {
                    fc = cont;
                }
            }
            return fc;
        }

    }
}
