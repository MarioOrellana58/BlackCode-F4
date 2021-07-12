using iTrashAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace iTrashAPI.Controllers
{
    public class iTrashController : ApiController
    {
        iTrashDB _context;
        public iTrashController()
        {
            _context = new iTrashDB();
        }
        [Route("api/iTrash")]
        public string Get()
        { 
            var users = _context.Users.ToList();
            return "Hello World";
        }
    }
}
