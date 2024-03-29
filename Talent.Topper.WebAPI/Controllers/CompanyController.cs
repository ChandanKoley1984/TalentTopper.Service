﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Talent.Topper.Data;
using Talent.Topper.WebAPI.Helpers;
using Talent.Topper.WebAPI.Entity;

namespace Talent.Topper.WebAPI.Controllers
{
    public class CompanyController : ApiController
    {
        CompanyHelper _companyHelper = new CompanyHelper();

        [HttpGet]
        [Route("api/Company/GetCompanies")]
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
                    return response = Request.CreateResponse(HttpStatusCode.NotFound, "Data is empty.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        public HttpResponseMessage GetCompaniesEdit(int? id = null)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                List<CompanyEntity> _CompanyEntity = _companyHelper.GetCompanyByID(id);

                if (_CompanyEntity != null)
                {
                    return response = Request.CreateResponse(HttpStatusCode.OK, _CompanyEntity);
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
        public HttpResponseMessage CreateCompany([FromBody] CompanyEntity _CompanyEntity)
        {
            try
            {
                if (_companyHelper.CreateCompanyWithBranch(_CompanyEntity))
                    return Request.CreateResponse(HttpStatusCode.OK, _CompanyEntity);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

            return Request.CreateResponse(HttpStatusCode.InternalServerError, _CompanyEntity);
        }
    }
}
