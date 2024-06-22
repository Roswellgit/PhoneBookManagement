using PhoneBookBusinessService;
using PhoneBookModels;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetService gs = new GetService();

            var users = gs.GetNum();

            foreach (var item in users)
            {
                Console.WriteLine(item.username);
                Console.WriteLine(item.password);
            }

        }
    }
}
