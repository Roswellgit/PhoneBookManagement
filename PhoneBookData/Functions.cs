using PhoneBookModels;
using System.Reflection.Metadata;
namespace PhoneBookData
{
    public class Functions
    {

        List<Contacts> contacts;
        SqlDbData sqlData;

        public PhoneBookData()
        {
            contacts = new List<Contacts>();
            sqlData = new SqlDbData();
        }

        public List<Contacts> GetUsers()
        {
            contacts = sqlData.GetUsers();
                return contacts;
        }

        public int AddContact(Contacts contact)
        {
            return sqlData.AddUser(contact.c_name, contact.c_num, contact.c_email, contact.c_add);
        }
        public int UpdateContact(Contacts contact)
        {
            return sqlData.Update(contact.c_name, contact.c_num, contact.c_email, contact.c_add);
        }
        public int DeleteContact(Contacts contact)
        {
            return sqlData.DeleteUser(contact.c_num);
        }





    }
}
