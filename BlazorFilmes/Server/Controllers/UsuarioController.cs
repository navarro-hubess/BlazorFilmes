using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFilmes.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorFilmes.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        // GET: UsuarioController
        public ActionResult Index()
        {
            return View();
        }

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

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult> Post([FromBody] User user)
        {
            try
            {
                //Inserção do usuário em uma lista/BD
                return null;
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
