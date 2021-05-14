using BLL.Interfaces;
using Common;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DescriptionInArticleController : ControllerBase
    {
        private readonly IDescriptionInArticleService _service;

        public DescriptionInArticleController(IDescriptionInArticleService service)
        {
            _service = service;
        }

        // GET: api/<ArticleController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var entities = await _service.GetAllAsync();
            return Ok(entities);
        }

        // GET api/<ArticleController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(string id)
        {
            var guidId = Guid.Parse(id);
            var entity = await _service.GetByIdAsync(guidId);
            return Ok(entity);
        }

        // POST api/<ArticleController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] DescriptionInArticleDto value)
        {
            var created = await _service.CreateAsync(value);
            return Ok(created);
        }

        // PUT api/<ArticleController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, [FromBody] DescriptionInArticleDto value)
        {
            var guidId = Guid.Parse(id);
            var updated = await _service.UpdateAsync(value, guidId);
            return Ok(updated);
        }

        // DELETE api/<ArticleController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var guidId = Guid.Parse(id);
            var deleted = await _service.DeleteAsync(guidId);
            return Ok(deleted);
        }
    }
}
