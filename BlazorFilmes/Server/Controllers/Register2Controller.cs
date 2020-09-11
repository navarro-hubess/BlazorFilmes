using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFilmes.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorFilmes.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Register2Controller : Controller
    {

        [HttpGet]
        [Route("List")]
        public IEnumerable<User> Get()
        {
            List<User> users = new List<User>()
            {
                new User(){Title = "Sr", FirstName = "Joao", LastName = "Das Cove",
                    Email = "teste@teste.com", DateOfBirth = DateTime.Now, Password="123456",
                    ConfirmPassword = "123456", AcceptTerms = true },

                new User(){Title = "Sr", FirstName = "Joao2", LastName = "Das Cove2",
                    Email = "teste@teste.com", DateOfBirth = DateTime.Now, Password="123456",
                    ConfirmPassword = "123456", AcceptTerms = true }
            };

            return users;
        }


        //Action/Método para Adicionar/Post um User
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> Post([FromBody] User user)
        {
            //TODO: Adicionar novo usuário (user) a uma lista
            Console.WriteLine("teste", user.ToString());
            return null;
        }

    }
}
