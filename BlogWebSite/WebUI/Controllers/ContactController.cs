using AutoMapper;
using Data;
using Entity;
using Microsoft.AspNetCore.Mvc;
using WebUI.ViewModels;

namespace WebUI.Controllers
{
    public class ContactController : Controller
    {
        private IMapper _mapper;
        private MyDbContext _myDbContext;

        public ContactController(IMapper mapper, MyDbContext myDbContext)
        {
            _mapper = mapper;
            _myDbContext = myDbContext;
        }


        public IActionResult Index(){
            
            MessageViewModel message = new MessageViewModel();
            return View(message);
        }

        [HttpPost]
        public IActionResult Index(MessageViewModel messageViewModel){

            if(ModelState.IsValid){
                Message message = _mapper.Map<MessageViewModel, Message>(messageViewModel);
                _myDbContext.Messages.Add(message);
                _myDbContext.SaveChanges();
                
                ViewBag.Message = "Mesajınız alındı. Teşekkür ederiz.";
                return View(new MessageViewModel());
            }

            return View(messageViewModel);


        }
    }
}