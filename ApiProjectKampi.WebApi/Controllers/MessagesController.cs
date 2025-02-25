using ApiProjectKampi.WebApi.Context;
using ApiProjectKampi.WebApi.Controllers.Entities;
using ApiProjectKampi.WebApi.Dtos.MessageDtos;
using AutoMapper;
using Microsoft.AspNetCore.Http;            
using Microsoft.AspNetCore.Mvc;

namespace ApiProjectKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {

        private readonly Mapper _mapper;
        private readonly ApiContext _context;

        public MessagesController(Mapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]

        public IActionResult Messagelist()
        {

            var value =_context.Messages.ToList();
            return Ok(_mapper.Map<List<ResultMessageDto>>(value));
        }



        [HttpPost]


        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {

            var value = _mapper.Map<Message>(createMessageDto);
            _context.Messages.Add(value);
            _context.SaveChanges();
            return Ok("başarılı olusturuldu");
            
        }

        [HttpDelete]

        public IActionResult DeleteMessage(int id)
        {
            var value = _context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return Ok("sildindi");

        }


        [HttpGet("GetMessege")]
        public IActionResult GetMessage(int id)
        {

            var value = _context.Messages.Find(id);
            return Ok(_mapper.Map<GetByIdMessageDto>(value));
        }



        [HttpPut]
        public IActionResult UpdateMessega(UpdateMessageDto updateMessageDto)
        {
            var value =_mapper.Map<Message>(updateMessageDto);
            _context.Messages.Update(value);
            _context.SaveChanges();
            return Ok("mesaj gücenlledndi");

        }

    }
}
