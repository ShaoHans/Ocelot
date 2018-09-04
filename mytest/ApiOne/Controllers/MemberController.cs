using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiOne.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<List<Member>> Get()
        {
            return MemberService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Member> Get(int id)
        {
            return MemberService.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<BaseResult> Post(string name, string mobile = "", Gender gender = Gender.Male)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new BaseResult(false, "用户名不能为空");
            }

            MemberService.Add(name, mobile, gender);
            return new BaseResult(true);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
