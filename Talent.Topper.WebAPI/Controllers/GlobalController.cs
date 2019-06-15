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
        [ResponseType(typeof(COUNTRY_MASTER))]
        public List<COUNTRY_MASTER> GetCountryList()
        {
            return _dbContext.COUNTRY_MASTER.Where(cm => cm.STATUS== 1).ToList();
        }
        [Route("api/getStateList/{countryID}")]
        [HttpGet]
        [ResponseType(typeof(STATE_MASTER))]
        public async Task<IHttpActionResult> GetStateList(int countryID)
        {
            var result = _dbContext.STATE_MASTER.Where(sm => sm.COUNTRY_ID == countryID).ToList();
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
