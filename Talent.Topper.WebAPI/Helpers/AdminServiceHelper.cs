using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Talent.Topper.WebAPI.Models;

namespace Talent.Topper.WebAPI.Helpers
{
    public static class AdminServiceHelper
    {
        internal static List<CompanyEntity> GetCompanyList(int companyID = 0)
        {
            //call Database
            MongoHelper.MongoHelper _mongoHelperobj = new MongoHelper.MongoHelper("TalentTopper");
            List<CompanyEntity> companyMasterList = _mongoHelperobj.SelectAll<CompanyEntity>("CompanyMaster");
            return companyMasterList;
        }
    }
}