using APImysqlTest.Model;
using APImysqlTest.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APImysqlTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        private readonly IService _service;

        public Controller(IService service)
        {
            this._service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<testCsharp>>> GetAll()
        {
            var t = await _service.getAll();
            if (t == null)
            {
                return NotFound();
            }
            else { return t; }
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var t = await _service.delete(id);
            if(t)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<ActionResult<testCsharp>> post(testCsharp t)
        {
            var resp = await _service.create(t);
            return Ok( resp );
        }
        [HttpPut]
        public async Task<ActionResult<testCsharp>> put(testCsharp t)
        {
            var response = await _service.update(t);
            if (response == null)
            {
                return NotFound();
            }
            return Ok( response );
        }

    }
}
