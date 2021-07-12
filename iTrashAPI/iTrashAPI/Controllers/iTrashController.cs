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
        public string Get(string username, string password)
        { 
            var user = _context.Users.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (user == null)
            {
                return "Datos incorrectos";
            }
            else
            {
                return "Bienvenido";
            }
        }
    }
}
