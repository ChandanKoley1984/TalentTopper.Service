using System;
using System.Collections.Generic;
using System.Linq;

using Talent.Topper.Data;
using Talent.Topper.WebAPI.Entity;

namespace Talent.Topper.WebAPI.Helpers
{
    public class CompanyHelper
    {
        CompanyDataAccessLayer _companyDataAccessLayer = new CompanyDataAccessLayer();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="companyID"></param>
        /// <returns></returns>
        internal List<COMPANY> GetCompanies(int? ID = null)
        {
            return _companyDataAccessLayer.GetCompanies(ID).ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_company"></param>
        /// <returns></returns>
        internal Dictionary<string, string> CreateCompany(COMPANY _company)
        {
            return _companyDataAccessLayer.CreateCompany(_company);
        }


        internal List<CompanyEntity> GetCompanyByID(int? id)
        {
            return _companyDataAccessLayer.GetCompanyByID(id).ToList();
        }


        public bool CreateCompanyWithBranch(CompanyEntity _CompanyEntity)
        {            
            return _companyDataAccessLayer.CreateCompanyWithBranch(_CompanyEntity); 
        }
    }
}