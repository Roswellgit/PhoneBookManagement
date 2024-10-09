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
        Email _email;
     
        public ContactController()
        {
            _getservice = new GetService();
            _cup = new CUP();
            _email = new Email();
           
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
            var resultt = _cup.CreateEntry(request.Name, request.Num, request.Email, request.Address);
            if (resultt)
            {
                _email.Email2(request.Email);
            }

            return new JsonResult(resultt);
        }
        [HttpPatch]
        public JsonResult UpdateContact(Contacts request)
        {
            var result = _cup.UpdateEntry(request.Name, request.Num, request.Email, request.Address);
            if (result)
            {
                _email.Email3(request.Email);
            }
            
            

            return new JsonResult(result);
        }
        [HttpDelete]
        public JsonResult DeleteContact(Contacts request)
        {
            var del = new PhoneBookModels.Contacts
            {
                   c_name = request.Name
            };
            var resulttt = _cup.DeleteEntry(del);
            if (resulttt)
            {
                _email.Email4(request.Email);
            }

            return new JsonResult(resulttt);
        }

    }
}
