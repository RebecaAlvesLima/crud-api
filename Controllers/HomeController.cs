using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace crud_react_api.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController
    {
        [HttpGet]
        public String Inicio(){
            return "funcionou";
        }   
    }
}