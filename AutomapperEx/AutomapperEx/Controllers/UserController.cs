using AutoMapper;
using AutomapperEx.Domain;
using AutomapperEx.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutomapperEx.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var user = GetUserDetails();

            UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);
            return View(userViewModel);
        }

        private static User GetUserDetails()
        {
            return new User()
            {
                Id = 1,
                FirstName = "Test",
                LastName = "123",
                Email = "T@gmail.com",
                Address = new Address()
                {
                    Country = "BD"
                }
            };
        }
    }
}
