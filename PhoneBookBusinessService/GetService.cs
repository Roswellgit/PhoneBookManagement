using PhoneBookModels;
using PhoneBookData;

namespace PhoneBookBusinessService
{
    public class GetService
    {
        private List<Contacts> GetAllUsers()
        {
            Functions functions = new Functions();
            return functions.GetUsers();
        }

        public Contacts GetUser(string c_name)
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

        public Contacts GetUser(int c_num)
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
