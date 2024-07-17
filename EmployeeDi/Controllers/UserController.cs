using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDi.Model;
using EmployeeDi.Sevices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeDi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IuserInterface _Iuser;
        public UserController(IuserInterface value)
        {
            _Iuser = value;
        }
        // GET: api/values
        [HttpGet]
        public IActionResult LogIn(User user)
        {
            /*try
            {
                if (user == null)
                {
                    throw new("invalid user");
                }
                return Ok(_Iuser.LogIn(user));
            }catch(Exception ex)
            {
                throw new(ex.Message);
            }*/
            return Ok(_Iuser.LogIn(user));
            
            
        }

       

        // POST api/values
        [HttpPost]
        public IActionResult Register(User user)
        {
            return Ok("Registration Successfull");
        }



    }
}

