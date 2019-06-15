using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Talent.Topper.Data;
using Talent.Topper.WebAPI.Helpers;
using System.Web.Http.Description;
using System.Threading.Tasks;

namespace Talent.Topper.WebAPI.Controllers
{
    public class GlobalController : ApiController
    {
        TalentTopperEntities _dbContext = new TalentTopperEntities();
        [Route("api/getCountryList")]
        [HttpGet]
        [ResponseType(typeof(CountryMaster))]
        public List<CountryMaster> GetCountryList()
        {
            return _dbContext.CountryMasters.Where(cm => cm.IsActive== true).ToList();
        }
        [Route("api/getStateList/{countryID}")]
        [HttpGet]
        [ResponseType(typeof(StateMaster))]
        public async Task<IHttpActionResult> GetStateList(int countryID)
        {
            var result = _dbContext.StateMasters.Where(sm => sm.CountryId == countryID).ToList();
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
