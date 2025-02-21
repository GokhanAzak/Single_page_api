using ApiProjectKampi.WebApi.Context;
using ApiProjectKampi.WebApi.Controllers.Entities;
using ApiProjectKampi.WebApi.Dtos.ContactDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjectKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {

        private readonly ApiContext _context;


        public ContactsController(ApiContext context)
        {

            _context = context;
        }

        [HttpGet]
        public IActionResult ContatcList()
        {
            var values = _context.Contacts.ToList();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateContact(CreateContatcDto createContatcDto)
        {
            Contact contact = new Contact();

            contact.Email = createContatcDto.Email;
            contact.Adrres = createContatcDto.Adrres;
            contact.Phone = createContatcDto.Phone;
            contact.MapLocation = createContatcDto.MapLocation;
            contact.OpenHours = createContatcDto.OpenHours;
            contact.Email = createContatcDto.Email;

            _context.SaveChanges();
            return Ok("KAyıtooldu");


        }


        [HttpDelete]

        public IActionResult DeleteContact(int id)
        {
            var value=_context.Contacts.Find(id);

            _context.Contacts.Remove(value);
            _context.SaveChanges();

            return Ok("silme başarılı");




        }


        [HttpGet("GetContact")]

        public IActionResult GetContact(int id)
        {
            var value = _context.Contacts.Find(id);

            return Ok(value);

        }


        [HttpPut]


        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {

            Contact contact= new Contact();
            contact.Email = updateContactDto.Email;
            contact.Adrres= updateContactDto.Adrres;    
            contact.Phone = updateContactDto.Phone;
            contact.ContactID = updateContactDto.ContactID;
            contact.MapLocation= updateContactDto.MapLocation;
            contact.OpenHours= updateContactDto.OpenHours;
            _context.Contacts.Update(contact);

            _context.SaveChanges();
            return Ok("Guncelleme olumlu");

        }

    }
}
