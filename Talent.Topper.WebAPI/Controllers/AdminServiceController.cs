using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Talent.Topper.WebAPI.Helpers;
using Talent.Topper.WebAPI.Models;
using Talent.Topper.WebAPI.Service;

namespace Talent.Topper.WebAPI.Controllers
{
    public class AdminServiceController : ApiController, IAdminService
    {
        [HttpPost]
        public HttpResponseMessage CreateBranch()
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                var data = "Get Data From Database";

                if (data != null)
                {
                    return response = Request.CreateResponse(HttpStatusCode.OK, data);
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

        [HttpPost]
        public HttpResponseMessage CreateCompany([FromBody] CompanyEntity companyEntity)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                var data = "Get Data From Database";

                if (data != null)
                {
                    return response = Request.CreateResponse(HttpStatusCode.OK, data);
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

        [HttpGet]
        public HttpResponseMessage GetBranch(string id)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                var data = "Get Data From Database";

                if (data != null)
                {
                    return response = Request.CreateResponse(HttpStatusCode.OK, data);
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

        [HttpGet]
        public HttpResponseMessage GetCompany(string id)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                List<CompanyEntity> _companyEntitys = new List<CompanyEntity>();
                //CompanyEntity _companyEntity;
                //for (int i = 0; i < 10; i++)
                //{
                //    _companyEntity = new CompanyEntity();
                //    _companyEntity.CompanayName = "Test";
                //    _companyEntity.Email = "Test@test.com";
                //    _companyEntity.WebsiteURL = "www.test.com";
                //    _companyEntitys.Add(_companyEntity);
                //}

                _companyEntitys = AdminServiceHelper.GetCompanyList();

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
    }
}
