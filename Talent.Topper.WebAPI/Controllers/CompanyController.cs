using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Talent.Topper.Data;
using Talent.Topper.WebAPI.Helpers;



namespace Talent.Topper.WebAPI.Controllers
{
    public class CompanyController : ApiController
    {
        CompanyHelper _companyHelper = new CompanyHelper();
        [HttpGet]
        public HttpResponseMessage GetCompanies(int? id = null)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                List<COMPANY> _companyEntitys = new List<COMPANY>();

                _companyEntitys = _companyHelper.GetCompanies(id);

                if (_companyEntitys != null)
                {
                    return response = Request.CreateResponse(HttpStatusCode.OK, _companyEntitys);
                }
                else
                {
                    return response = Request.CreateResponse(HttpStatusCode.NotFound, "Data is empty");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        /// <summary>
        /// This method is used to create company
        /// </summary>
        /// <param name="generatedIDEntity"></param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage CreateCompany([FromBody] COMPANY _company)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                int saveStatus = _companyHelper.CreateCompany(_company);

                if (saveStatus > 0)
                {
                    return response = Request.CreateResponse(HttpStatusCode.OK, _company);
                }
                else
                {
                    return response = Request.CreateResponse(HttpStatusCode.NotFound, "Unable to create company");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
