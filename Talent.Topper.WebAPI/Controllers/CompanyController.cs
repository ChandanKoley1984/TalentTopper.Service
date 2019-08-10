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
        BranchHelper _branchHelper = new BranchHelper();

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


                var query = from c in _dbContext.COMPANies
                            join b in _dbContext.BRANCHes on c.ID equals b.Company_ID into Joined_COMPANY_BRANCH
                            from bc in Joined_COMPANY_BRANCH.DefaultIfEmpty()
                            join cont in _dbContext.CONTACTs on new { _a = bc.Company_ID, _b = bc.ID } equals new { _a = cont.Company_ID, _b = (long)cont.Branch_ID } into Joined_COMPANY_CONTACT
                            from ccont in Joined_COMPANY_CONTACT.DefaultIfEmpty()
                            join add in _dbContext.ADDRESSes on new { _a = bc.Company_ID, _b = bc.ID, _c = ccont.ID } equals new { _a = add.Company_ID, _b = (long)add.Branch_ID, _c = (long)add.Contact_id } into Joined_CONTACT_ADDRESS
                            from cadd in Joined_CONTACT_ADDRESS.DefaultIfEmpty()
                            join r in _dbContext.ROLEs on new { _a = bc.Company_ID, _b = bc.ID, _c = (long)ccont.RoleId } equals new { _a = r.Company_ID, _b = (long)r.Branch_ID, _c = r.ID } into Joined_ROLE_CONTACT
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
                                CountryID = cadd.country_id == null ? null : cadd.country_id,
                                StateID = cadd.state_id == null ? null : cadd.state_id,
                                RoleId= ccont.RoleId,
                                City = cadd.city,
                                CompanyType = c.CompanyType,
                                Password = ccont.Password,
                                IsActive = c.IsActive,
                                Company_ID = ccont.Company_ID == null ? null : ccont.Company_ID,
                                Branch_ID = ccont.Branch_ID == null ? null : ccont.Branch_ID,
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
        public HttpResponseMessage CreateCompany([FromBody] CompanyEntity _CompanyEntity)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            try
            {
                //select* from company : done
                //select* from branch
                //select* from[dbo].[CONTACT]
                //d* from[dbo].[ADDRESS]

                COMPANY _company = new COMPANY();
                _company.ID = _CompanyEntity.ID;
                _company.CompanyName = _CompanyEntity.CompanyName;
                _company.CEOName = _CompanyEntity.CEOName;
                _company.WebsiteUrl = _CompanyEntity.WebsiteUrl;
                _company.LogoPath = _CompanyEntity.LogoPath;
                //_company.Contact_Id = _CompanyEntity.Contact_Id;
                _company.IsActive = _CompanyEntity.IsActive;
                _company.CreatedDate = _CompanyEntity.CreatedDate;
                _company.CreatedBy = _CompanyEntity.CreatedBy;
                //_company.UpdatedDate = _CompanyEntity.UpdatedDate;
                //_company.UpdatedBy = _CompanyEntity.UpdatedBy;
                _company.CompanyType = _CompanyEntity.CompanyType;


                int saveStatusCompany = _companyHelper.CreateCompany(_company);

                if (saveStatusCompany > 0)
                {

                    BRANCH _branch = new BRANCH();
                    _branch.ID = 0;
                    _branch.Name = _CompanyEntity.CompanyName;
                    _branch.HODName = _CompanyEntity.CEOName;
                    _branch.LogoPath = _CompanyEntity.LogoPath;
                    //_branch.Company_ID = 0;
                    //_branch.Contact_Id = 0;
                    _branch.IsActive = _CompanyEntity.IsActive;
                    _branch.CreatedDate = _CompanyEntity.CreatedDate;
                    _branch.CreatedBy = _CompanyEntity.CreatedBy;
                    //_branch.UpdatedDate = _CompanyEntity.UpdatedDate;
                    //_branch.UpdatedBy = _CompanyEntity.UpdatedBy;


                    int saveStatusBranch = _branchHelper.CreateBranch(_branch);

                    if (saveStatusBranch > 0)
                    {
                        CONTACT _contact = new CONTACT();
                        _contact.ID = 0;
                        _contact.Name = _CompanyEntity.CompanyName;
                        _contact.RoleId = 1;
                        _contact.MobileNo = _CompanyEntity.MobileNo;
                        _contact.PhoneNo = _CompanyEntity.PhoneNo;
                        _contact.Email = _CompanyEntity.Email;
                        _contact.Password = _CompanyEntity.Password;
                        //_contact.Gender = _CompanyEntity.Gender;
                        //_branch.Company_ID = 0;
                        //_branch.Contact_Id = 0;
                        _branch.IsActive = _CompanyEntity.IsActive;
                        _branch.CreatedDate = _CompanyEntity.CreatedDate;
                        _branch.CreatedBy = _CompanyEntity.CreatedBy;
                        //_branch.UpdatedDate = _CompanyEntity.UpdatedDate;
                        //_branch.UpdatedBy = _CompanyEntity.UpdatedBy;
                        // return response = Request.CreateResponse(HttpStatusCode.OK, _company);

                        int saveStatusContact = _branchHelper.CreateBranch(_branch);
                        if(saveStatusContact>0)
                        {
                            return response = Request.CreateResponse(HttpStatusCode.OK, _company);
                        }
                        else
                        {
                            return response = Request.CreateResponse(HttpStatusCode.NotFound, "Unable to create company");
                        }
                    }
                    else
                    {
                        return response = Request.CreateResponse(HttpStatusCode.NotFound, "Unable to create company");
                    }

                    //return response = Request.CreateResponse(HttpStatusCode.OK, _company);
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
