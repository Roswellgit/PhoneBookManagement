using PhoneBookModels;
using System.Reflection.Metadata;
namespace PhoneBookData
{
    public class Functions
    {

        List<Contacts> contacts;
        SqlDb sqlData;

        public Functions()
        {
            contacts = new List<Contacts>();
            sqlData = new SqlDb();
        }

        public List<Contacts> GetUsers()
        {
            contacts = sqlData.GetUsers();
                return contacts;
        }

        public int AddContact(Contacts contact)
        {
            return sqlData.AddContact(contact.c_name, contact.c_num, contact.c_email, contact.c_add);
        }
        public int UpdateContact(Contacts contact)
        {
            return sqlData.UpdateContact(contact.c_name, contact.c_num, contact.c_email, contact.c_add);
        }
        public int DeleteContact(Contacts contact)
        {
            return sqlData.DeleteContact(contact.c_name);
        }





    }
}
