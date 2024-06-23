using PhoneBookBusinessService;
using PhoneBookModels;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetService gs = new GetService();

            var contacts = gs.GetAllUsers();

            foreach (var item in contacts)
            {
                Console.WriteLine(item.c_name);
                Console.WriteLine(item.c_num);
                Console.WriteLine(item.c_email);
                Console.WriteLine(item.c_add);
            }

        }
    }
}
