using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Talent.Topper.Data;
using Talent.Topper.WebAPI.Helpers;
using Talent.Topper.WebAPI.Models;

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
        [HttpGet]
        public HttpResponseMessage GetCompaniesEdit(int? id = null)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                TalentTopperEntities _dbContext = new TalentTopperEntities();
                List<CompanyEntity> _CompanyEntity = new List<CompanyEntity>();


                var query = from c in _dbContext.COMPANY
                            join b in _dbContext.BRANCH on c.ID equals b.Company_ID into Joined_COMPANY_BRANCH
                            from bc in Joined_COMPANY_BRANCH.DefaultIfEmpty()
                            join cont in _dbContext.CONTACT on new { _a = bc.Company_ID, _b = bc.ID } equals new { _a = cont.Company_ID, _b = (long)cont.Branch_ID } into Joined_COMPANY_CONTACT
                            from ccont in Joined_COMPANY_CONTACT.DefaultIfEmpty()
                            join add in _dbContext.ADDRESS on new { _a = bc.Company_ID, _b = bc.ID, _c = ccont.ID } equals new { _a = add.Company_ID, _b = (long)add.Branch_ID, _c = (long)add.Contact_id } into Joined_CONTACT_ADDRESS
                            from cadd in Joined_CONTACT_ADDRESS.DefaultIfEmpty()
                            join r in _dbContext.ROLE on new { _a = bc.Company_ID, _b = bc.ID, _c = (long)ccont.RoleId } equals new { _a = r.Company_ID, _b = (long)r.Branch_ID, _c = r.ID } into Joined_ROLE_CONTACT
                            from cr in Joined_ROLE_CONTACT.DefaultIfEmpty()
                            where (c.IsActive == true) && (c.ID == (long)id)
                            orderby c.ID
                            select new CompanyEntity()
                            {
                                ID = c.ID,

                                CompanyName = c.CompanyName,
                                addressline = cadd.addressline,                              
                                MobileNo = ccont.MobileNo,
                                PhoneNo = ccont.PhoneNo,
                                Email = ccont.Email,
                                WebsiteUrl = c.WebsiteUrl,
                                LogoPath = c.LogoPath,
                                CEOName = c.CEOName,
                                //CountryID = cadd.country_id == null ? null : cadd.country_id,
                                //StateID = cadd.state_id == null ? null : cadd.state_id,
                                City = cadd.city,
                                CompanyType = c.CompanyType,
                                Password = ccont.Password,
                                IsActive =  c.IsActive
                            };

                _CompanyEntity = query.ToList();


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
