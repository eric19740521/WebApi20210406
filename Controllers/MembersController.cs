using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapi03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {

        private static List<Members> _p = new List<Members>();

        // GET: api/<MembersController>
        [HttpGet]
        public List<Members> Get()
        {

            return _p;
        }

        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public string Get(string id)//括號內的參數 .須為 HttpGet("{id}")
        {
            var ret = "查詢失敗";
            var i = 0;

            ret = "ID=" + id + ",查詢失敗";
            i = _p.FindIndex((Members m) => m.ID == id); //找不到.回傳-1
            //var _m = _p.FirstOrDefault((Members m) => m.ID == id);
            if (i >= 0)
            {

                ret = _p[i].ID + "->" + _p[i].Name + ",查詢OK";


                //ret="ok";

            }


            return ret;
        }

        // POST api/<MembersController>
        [HttpPost]
        public string Post([FromBody] Members _m)
        {

            var ret = "新增失敗";

            _p.Add(new Members { ID = _m.ID, Name = _m.Name });

            ret = "ID=" + _m.ID + ",新增OK";
            return ret;

        }

        // PUT api/<MembersController>/5
        [HttpPut("{id}")]
        public string Put(string id, [FromBody] Members _m)
        {

            var ret = "修改失敗";
            var i = 0;

            ret = "ID=" + id + ",修改失敗";
            i = _p.FindIndex((Members m) => m.ID == id); //找不到.回傳-1

            //var _m = _p.FirstOrDefault((Members m) => m.ID == id);
            if (i >= 0)
            {
                _p[i].Name = _m.Name;
                ret = "ID=" + id + "->Name=" + _m.Name + ",修改OK";
            }

            return ret;
        }

        // DELETE api/<MembersController>/5
        [HttpDelete("{id}")]
        public string Delete(string id)
        {

            var ret = "刪除失敗";
            var i = 0;

            ret = "ID=" + id + ",刪除失敗";
            i = _p.FindIndex(x => x.ID == id); //找不到.回傳-1
            if (i >= 0)
            {
                _p.RemoveAt(i);

                ret = "ID=" + id + ",刪除OK";
            }

            return ret;
        }
    }
}
