using Microsoft.AspNetCore.Mvc;
using PhoneBookBusinessService;
using Microsoft.AspNetCore.Mvc.Formatters;
using PhoneBookModels;

namespace PhoneBookAPI.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class ContactController : ControllerBase
    {
        GetService _getservice;
        CUP _cup;

        public ContactController()
        {
            _getservice = new GetService();
            _cup = new CUP();
        }

        [HttpGet]
        public IEnumerable<PhoneBookAPI.Contacts> GetContacts()
        {
            var Contacts = _getservice.GetAllUsers();

            List<PhoneBookAPI.Contacts> cont = new List<Contacts>();

            foreach (var contact in Contacts)
            {
                cont.Add(new PhoneBookAPI.Contacts { Name = contact.c_name, Num = contact.c_num, Address = contact.c_add, Email = contact.c_email });
            }
            return cont;
        }
        [HttpPost]
        public JsonResult AddContact(Contacts request)
        {
            var result = _cup.CreateEntry(request.Name, request.Num, request.Email, request.Address);

            return new JsonResult(result);
        }
        [HttpPatch]
        public JsonResult UpdateContact(Contacts request)
        {
            var result = _cup.UpdateEntry(request.Name, request.Num, request.Email, request.Address);

            return new JsonResult(result);
        }
        [HttpDelete]
        public JsonResult DeleteContact(Contacts request)
        {
            var del = new PhoneBookModels.Contacts
            {
                   c_name = request.Name
            };
            var result = _cup.DeleteEntry(del);

            return new JsonResult(result);
        }

    }
}
