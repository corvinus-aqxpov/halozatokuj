using HajosTeszt.CimModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HajosTeszt.Controllers
{
    [Route("api/cim")]
    [ApiController]
    public class CimController : ControllerBase
    {
        // GET: api/<CimController>
        [HttpGet]
        public IEnumerable<Aqxpov> Get()
        {
            SzamhaloContext context = new SzamhaloContext();
            return context.Aqxpovs.ToList();
        }

        // GET api/konyvekcimei/5
        [HttpGet("{id}")]
        public Aqxpov Get(int id)
        {
            SzamhaloContext context = new SzamhaloContext();
            var keresettKonyvCime = (from x in context.Aqxpovs
                                     where x.CimId == id
                                     select x).FirstOrDefault();
            return keresettKonyvCime;
        }

        // POST api/konyvcimek
        [HttpPost]
        public void Post([FromBody] Aqxpov ujKonyv)
        {
            SzamhaloContext context = new SzamhaloContext();
            context.Aqxpovs.Add(ujKonyv);
            context.SaveChanges();
        }

        // PUT api/<CimController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/konyvcim/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            SzamhaloContext context = new SzamhaloContext();
            var törölhetőKönyv = (from x in context.Aqxpovs
                                  where x.CimId == id
                                  select x).FirstOrDefault();
            context.Remove(törölhetőKönyv);
            context.SaveChanges();
        }
    }
}
