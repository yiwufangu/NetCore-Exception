using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore.EntityFramework;
using NetCore.EntityFramework.Models;
using NetCore.Exception.Models;

namespace NetCore.Exception.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            ArtistRepository repo = new ArtistRepository();
            var all = repo.GetAll().ToList();

            return Ok(all);
        }

        [HttpPost]
        public bool InsertArtist([FromBody]Artist entity)
        {
            ArtistRepository repo = new ArtistRepository();
            return repo.Add(entity);
        }

        [HttpPost]
        public IActionResult EatApple([FromBody]Apple apple)
        {
            //string errorMessage = string.Empty;
            //if (!ModelState.IsValid)
            //{
            //    foreach(var item in ModelState.Values)
            //    {
            //        foreach(var error in item.Errors)
            //        {
            //            errorMessage += error.ErrorMessage + "|";
            //        }
            //    }
            //}
            //if (!string.IsNullOrEmpty(errorMessage))
            //{
            //    return BadRequest(errorMessage);
            //}
            Console.WriteLine(apple);
            return Ok();
        }

        // GET: api/Test
        [HttpGet]
        public IEnumerable<string> TestException()
        {
            //int cnt = dbContext.Albums.Count();
            throw new System.Exception("自定义异常！");
            return new string[] { "value1", "value2" };
        }

        // GET: api/Test/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
