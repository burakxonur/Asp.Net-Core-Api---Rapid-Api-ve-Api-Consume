using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContacMService _contactMService;
        public ContactController(IContacMService contactMService)
        {
            _contactMService = contactMService;
        }
        [HttpPost]
        public IActionResult AddContact(ContactM contactM)
        {
            contactM.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactMService.TInsert(contactM);
            return Ok();
        }
        [HttpGet]
        public IActionResult inboxListContact()
        {
            var values = _contactMService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _contactMService.TGetByID(id);
            return Ok(values);
        }
        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount()
        {
            return Ok(_contactMService.TGetContactCount());
        }
    }
}
