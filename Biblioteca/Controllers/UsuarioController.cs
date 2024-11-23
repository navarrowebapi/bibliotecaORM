using Biblioteca.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public static List<User> Users { get; set; } = new List<User>();

        //POST
        [HttpPost(Name = "PostUser")]
        public ActionResult PostUser(User user)
        {
            Users.Add(user);
            return Ok("User Adicionado com sucesso");
        }

        //GETALL
        [HttpGet(Name = "GetUsers")]
        public ActionResult<List<User>> GetAll()
        {
            return Ok(Users);
        }

        //GETBYID
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var user = Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        //PUT
        [HttpPut("{id}")]
        public ActionResult Put(int id, User user)
        {
            var usuario = Users.FirstOrDefault(x => x.Id == id);
            if (usuario == null)
                return NotFound();

            //Update
            usuario.Email= user.Email;
            usuario.Name= user.Name;

            return Ok(user);
        }

        //DELETE
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var usuario= Users.FirstOrDefault(x => x.Id == id);
            if (usuario == null)
                return NotFound();
            Users.Remove(usuario);
            return Ok("Usuario deletado com sucesso");

        }
    }
}
