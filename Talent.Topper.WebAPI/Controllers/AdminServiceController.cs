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
        public HttpResponseMessage CreateBranch([FromBody] BranchEntity branchEntity)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                MongoHelper.MongoHelper _mongoHelperobj = new MongoHelper.MongoHelper("TalentTopper");
                List<BranchEntity> branchMasterList = new List<BranchEntity>();
                branchMasterList.Add(branchEntity);

                bool data = _mongoHelperobj.InsertMany("BranchMaster", branchMasterList);

                if (data)
                {
                    return response = Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return response = Request.CreateResponse(HttpStatusCode.NotFound, "Unable to save data");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
       /// <summary>
       /// create company
       /// </summary>
       /// <param name="companyEntity"></param>
       /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage CreateCompany([FromBody] CompanyEntity companyEntity)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                MongoHelper.MongoHelper _mongoHelperobj = new MongoHelper.MongoHelper("TalentTopper");
                List<CompanyEntity> companyMasterList = new List<CompanyEntity>();
                companyMasterList.Add(companyEntity);

                bool data = _mongoHelperobj.InsertMany("CompanyMaster", companyMasterList);

                if (data)
                {
                    return response = Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return response = Request.CreateResponse(HttpStatusCode.NotFound, "Unable to save data");
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
                List<BranchEntity> _branchEntities = new List<BranchEntity>();

                _branchEntities = AdminServiceHelper.GetBranchList();

                if (_branchEntities != null)
                {
                    return response = Request.CreateResponse(HttpStatusCode.OK, _branchEntities);
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
        /// <summary>
        /// create company
        /// </summary>
        /// <param name="GeneratedIDEntity"></param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage CreateIDs([FromBody] GeneratedIDEntity generatedIDEntity)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                MongoHelper.MongoHelper _mongoHelperobj = new MongoHelper.MongoHelper("TalentTopper");
                List<GeneratedIDEntity> IDMasterList = new List<GeneratedIDEntity>();
                IDMasterList.Add(generatedIDEntity);

                bool data = _mongoHelperobj.InsertMany("IDMaster", IDMasterList);

                if (data)
                {
                    return response = Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return response = Request.CreateResponse(HttpStatusCode.NotFound, "Unable to save data");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        public HttpResponseMessage GetGeneratedIDs(string id)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                List<GeneratedIDEntity> _GeneratedIDEntity = new List<GeneratedIDEntity>();

                _GeneratedIDEntity = AdminServiceHelper.GetGeneratedIDsList();

                if (_GeneratedIDEntity != null)
                {
                    return response = Request.CreateResponse(HttpStatusCode.OK, _GeneratedIDEntity);
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
        public HttpResponseMessage GetCountry(string id)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                List<CountryEntity> _CountryEntities = new List<CountryEntity>();

                _CountryEntities = AdminServiceHelper.GetCountryList();

                if (_CountryEntities != null)
                {
                    return response = Request.CreateResponse(HttpStatusCode.OK, _CountryEntities);
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
