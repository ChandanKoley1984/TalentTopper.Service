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
        internal List<COMPANY> GetCompanies(int? ID = null)
        {
            return _companyDataAccessLayer.GetCompanies(ID).ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_company"></param>
        /// <returns></returns>
        internal int CreateCompany(COMPANY _company)
        {            
            return _companyDataAccessLayer.CreateCompany(_company);
        }

    }
}