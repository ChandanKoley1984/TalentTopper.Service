using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Talent.Topper.Data;

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
        internal List<Company> GetCompanies(int? companyID = null)
        {
            return _companyDataAccessLayer.GetCompanies(companyID).ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_company"></param>
        /// <returns></returns>
        internal int CreateCompany(Company _company)
        {
            _company.CreatedOn = DateTime.Now;
            _company.IsActive = true;
            return _companyDataAccessLayer.CreateCompany(_company);
        }

    }
}